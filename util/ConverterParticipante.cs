using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace ExercicioEvenJunior
{
    /// <summary>
    /// Classe responsável pela conversão da planilha em participantes
    /// </summary>
    public class ConverterParticipante
    {

        private  String textoColadoDaPlanilha;
        private const String caminhoArquivoParticipantes = "participantes.txt";
        private  static List<Participante> participantes = new List<Participante>();
       
        /// <summary>
        /// Construtor que recebe o texto da planilha com as informações dos participantes
        /// </summary>
        /// <param name="textoPlanilha">texto da planilha</param>
        public ConverterParticipante(String textoPlanilha)
        {
            textoPlanilha.Replace("/", " - ");
            textoColadoDaPlanilha = textoPlanilha;
        } 

        /// <summary>
        /// Método para criar um arquivo txt com os dados que foram colados da planilha
        /// </summary>
        public void CriaArquivo()
        {

            using (var fluxoDeArquivo = new FileStream(caminhoArquivoParticipantes, FileMode.Create))
            {

                var encoding = Encoding.UTF8;

                var bytes = encoding.GetBytes(textoColadoDaPlanilha);

                fluxoDeArquivo.Write(bytes, 0, bytes.Length);

            }
        }

        /// <summary>
        /// Método para pegar a lista de  participantes com os dados do arquivo
        /// </summary>
        /// <returns> Retorna a uma lista do tipo Participante, com todos os participantes contidos no arquivo </returns>
        public List<Participante> PopulaListaDeParticipantes()
        {
            using (var fluxoDoArquivo = new FileStream(caminhoArquivoParticipantes, FileMode.Open))
            using (var leitor = new StreamReader(fluxoDoArquivo))
            {
                ConverteArquivoEmParticipantes(leitor);
                return participantes;
            }
        }

        /// <summary>
        /// Método para transformar uma linha do arquivo em um participante
        /// </summary>
        /// <param name="linhaDaTabela"> Linha com informações do participante </param>
        private void CriaParticipante(String linhaDaTabela)
        {
            Participante participante =  new Participante();
             var campos = linhaDaTabela.Split('\t');

            if(campos.Length >= 5) { 

            participante.Nome = campos[0];
            participante.Pais = campos[1];
            participante.Instituicao = campos[2];
            participante.Email = campos[3];
            participante.Inscricao = campos[4];

            participantes.Add(participante);
            }
        }

        /// <summary>
        /// Método que gera a lista completa com todos os participantes
        /// </summary>
        /// <param name="leitor"></param>
        private void ConverteArquivoEmParticipantes(StreamReader leitor)
        {
            
            while (!leitor.EndOfStream)
            {
                    var linha = leitor.ReadLine();
                    CriaParticipante(linha);
            }


            if (participantes[0].Nome.Equals("Nome"))
            {
                
               participantes.Remove(participantes[0]); // remove cabeçalhos da tabela
            } 
        }

    }
}
