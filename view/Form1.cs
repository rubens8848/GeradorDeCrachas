using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace ExercicioEvenJunior
{

    /// <summary>
    /// Representa a tela de interação do usuário para gerar crachás
    /// </summary>
    public partial class Form1 : Form
    {
        private readonly String tagNome = "{{nome}}";
        private readonly String tagPais = "{{país}}";
        private readonly String tagInstituicao = "{{instituição}}";
        private readonly String tagEmail = "{{email}}";
        private readonly String tagInscricao = "{{inscrição}}";
        private String textoComTagsOriginal;
        private String tagInvalida;
        private String area_tags_convertido;
        private const String dicasCrachas = "https://bit.ly/2XomIF1";
        private Boolean salvou = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            link_dica_template.Links.Add(0, 0, dicasCrachas);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void btn_imagem_fundo_Click(object sender, EventArgs e)
        {
            string caminhoDasImagens = System.AppDomain.CurrentDomain.BaseDirectory.ToString();

            ofd_busca_cracha.FileName = "";
            ofd_busca_cracha.InitialDirectory = caminhoDasImagens;
            ofd_busca_cracha.Title = "selecione um modelo de Crachá";
            ofd_busca_cracha.Filter = "PNG|*.png";
            ofd_busca_cracha.ShowDialog();
          
        }

        private void ofd_busca_cracha_FileOk(object sender, CancelEventArgs e)
        {
            pic_imagem_cracha.Image = System.Drawing.Image.FromFile(ofd_busca_cracha.FileName);
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_baixar_crachas_Click(object sender, EventArgs e)
        {

            if (area_tabela.Text != null)
            {
                ConverterParticipante conversorDeParticipante = new ConverterParticipante(area_tabela.Text);
                conversorDeParticipante.CriaArquivo();
                List<Participante> participantes = conversorDeParticipante.PopulaListaDeParticipantes();
                textoComTagsOriginal = area_tags.Text;

                for (int indiceDoLaco = 0; indiceDoLaco < participantes.Count; indiceDoLaco++)
                {
                    area_tags.Text = textoComTagsOriginal;
                    ConverteTagsEmInformacoes(participantes, indiceDoLaco);
                    CriaPDFComCracha(participantes, indiceDoLaco);

                }

                if (pic_imagem_cracha.Image == null)
                {
                    MessageBox.Show("Selecione um modelo de carachá");
                }

                notificaTagInválida();

                if (salvou == true)
                {
                    MessageBox.Show("Os crachás foram criados com sucesso");
                }

            }

        }

        private void pic_imagem_cracha_Click(object sender, EventArgs e)
        {

        }

        private void area_tags_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowColor = true;

            if (fd.ShowDialog() == DialogResult.OK & !String.IsNullOrEmpty(area_tags.Text))
            {
                area_tags.SelectionFont = fd.Font;
                area_tags.SelectionColor = fd.Color;
                area_tags.Font = fd.Font;
            }



        }

        private void area_tags_TextChanged_2(object sender, EventArgs e)
        {
        }

        private void pic_preview_Click(object sender, EventArgs e)
        {

        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            txt_preview.Visible = true;
            CriaPreview();
        }


        /// <summary>
        /// Mostra uma mensagem na tela caso seja encontrada uma tag inválida
        /// </summary>
        private void notificaTagInválida()
        {
            if (VerificaTagInvalida() == true)
            {
                MessageBox.Show(tagInvalida + " Não é uma Tag válida - As tags válidas são:\n" +
                tagNome + "  -  " + tagPais + "  -  " + tagInstituicao + "  -  " + tagEmail + "  -  " + tagInscricao);
                area_tags.Text = textoComTagsOriginal;
            }
        }

        /// <summary>
        /// Método para criar o arquivo PDF com as informações do participante
        /// </summary>
        /// <param name="participantes"> Lista dos participantes, usada para salvar o nome do arquivo como o email do participante </param>
        /// <param name="indiceDoLaco">índice usado para percorrer a lista de participantes</param>
        private void CriaPDFComCracha(List<Participante> participantes, int indiceDoLaco)
        {
            if (VerificaTagInvalida() == false)
            {

                System.Drawing.Image imagemComTexto = new GeraCracha(pic_imagem_cracha.Image).PopulaCracha(area_tags.Text,area_tags.Font);

                Document doc = new Document(PageSize.A4);

                //Cria o arquivo pdf no  diretório do projeto" 
                PdfWriter.GetInstance(doc, new FileStream(participantes[indiceDoLaco].Email + ".pdf", FileMode.Create));
                doc.Open();

                if (imagemComTexto != null)
                {
                    //Pega a imagem do crachá finalizado e salva como uma referência de imagem aceita pelo iTextSharp
                    iTextSharp.text.Image pdfImage =
                        iTextSharp.text.Image.GetInstance(imagemComTexto, System.Drawing.Imaging.ImageFormat.Png);

                    //define tamanho e alinhamento do crachá  na página
                    pdfImage.ScaleToFit(700f, 700f);
                    pdfImage.Alignment = Element.ALIGN_JUSTIFIED;

                    doc.Add(pdfImage);
                    doc.Close();

                    salvou = true;
                }
            }
        }

        /// <summary>
        /// Método para converter as tags em dados dos participantes
        /// </summary>
        /// <param name="participantes">Lista de participantes, usada para pegar os dados que irão substituir as tags</param>
        /// <param name="indice"> Índice utilizado para percorrer a lista de participantes</param>
        private void ConverteTagsEmInformacoes(List<Participante> participantes, int indice)
        {
            SubstituiTag(tagNome, participantes[indice].Nome);
            SubstituiTag(tagPais, participantes[indice].Pais);
            SubstituiTag(tagInstituicao, participantes[indice].Instituicao);
            SubstituiTag(tagEmail, participantes[indice].Email);
            SubstituiTag(tagInscricao, participantes[indice].Inscricao);
            SubstituiTag("/", "-");
        }

        private void area_tags_TextChanged(object sender, EventArgs e)
        {

        }

        private void area_tags_convertido_TextChanged(object sender, EventArgs e)
        {

        }

       /// <summary>
       /// Método verificar a ocorrência de uma tag inválida
       /// </summary>
       /// <returns> retorna um Boolean, caso encontre uma tag inválida retorna true, caso contrário retorna false</returns>
        private Boolean VerificaTagInvalida()
        {
            if ((area_tags.Text.Contains("{{")) && (area_tags.Text.Contains("}}")))
            {
                tagInvalida = area_tags.Text;

                int comeco = tagInvalida.IndexOf("{{");
                int fim = tagInvalida.LastIndexOf("}}");
                tagInvalida = tagInvalida.Substring(comeco, (fim +2 ) - comeco);

                return true;
            }
            else
            {
                return false;
            }
            
        }

        /// <summary>
        /// Método para trocar as tags no texto por informações
        /// </summary>
        /// <param name="tag"> referencia um texto que contenha os caracteres {{ }} </param>
        /// <param name="substituicao">Texto que será usado para substituir a tag </param>
        private void SubstituiTag(String tag, String substituicao)
         {
             if (area_tags.Text.Contains(tag))
             {

              area_tags_convertido = area_tags.Text;
              area_tags_convertido = area_tags.Text.Replace(tag, substituicao);
                area_tags.Text = area_tags_convertido;
             }
             else
             {
                 area_tags_convertido = area_tags.Text;
             }

         }

       

        /// <summary>
        /// Método para criar uma preview do crachá com as informações definidas pelo usuário
        /// </summary>
        private void CriaPreview()
        {
            textoComTagsOriginal = area_tags.Text;
            SubstituiTag(tagNome, "José Rubens dos Santos Silva");
            SubstituiTag(tagPais, "Brasil");
            SubstituiTag(tagInstituicao, "UPE");
            SubstituiTag(tagEmail, "rubens_884@hotmail.com");
            SubstituiTag(tagInscricao, "Ativo");
            VerificaTagInvalida();
            notificaTagInválida();

            pic_preview.Image = new GeraCracha(pic_imagem_cracha.Image).PopulaCracha(area_tags.Text, area_tags.Font);
            area_tags.Text = textoComTagsOriginal;
            pic_preview.Image = pic_imagem_cracha.Image;
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
