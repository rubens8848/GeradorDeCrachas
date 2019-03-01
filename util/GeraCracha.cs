using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ExercicioEvenJunior
{

    /// <summary>
    /// Classe utilizada para a escrever os dados do participante no modelo de crachá selecionado
    /// </summary>
    public class GeraCracha
    {

        private Image imagemSelecionada;

        /// <summary>
        /// Construtor que recebe a imagem que será usada como modelo do crachá
        /// </summary>
        /// <param name="image">Imagem do crachá</param>
        public GeraCracha(Image image)
        {
            
            this.imagemSelecionada = image;
        }

        
        /// <summary>
        /// Método
        /// </summary>
        /// <param name="textoComTags">Texto contendo as informações a serem escritas no crachá</param>
        /// <param name="fonte">Dados sobre as configurações do texto, como:  tamanho, fonte, estilo,  etc..</param>
        /// <returns> retorna a imagem que representa o crachá com os dados do participante</returns>
        public Image PopulaCracha(String textoComTags, Font fonte)
        {
            
            if (imagemSelecionada != null)
            {
                using (Graphics grafico = Graphics.FromImage(imagemSelecionada))
                {

                    Brush pincel = new SolidBrush(Color.Black);

                    grafico.Clip = new Region(new Rectangle(0,700,900,400));
                    grafico.Clear(Color.White);
                    grafico.DrawString(textoComTags, fonte, pincel, 0, 700);
                }

            }
            return imagemSelecionada;
            
            
        }
    }
}
