using BatimentoPontoHomeOffice.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatimentoPontoHomeOffice
{ 
    public partial class FormSobreescritaContinuacao : Form
    {
        int retornoPopUp;
        bool escolhaContinuacao;

        public FormSobreescritaContinuacao(bool continuacao)
        {
            InitializeComponent();
            escolhaContinuacao = continuacao;
        }

        /// <summary>
        /// Método de inicio do form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormSobreescritaContinuacao_Load(object sender, EventArgs e)
        {
            lbTextoContinuacao.Visible = escolhaContinuacao;
            btContinuar.Visible = escolhaContinuacao;
        }

        /// <summary>
        /// Método de click que retorna opção de sobreescrita
        /// </summary>dd
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSobreescrever_Click(object sender, EventArgs e)
        {
            //Retorna ação de sobreescrita referente ao enum TipoServiço
            retornoPopUp = 1;
            this.Close();
        }


        /// <summary>
        /// Método de click que retorna a opção de continuação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btContinuar_Click(object sender, EventArgs e)
        {
            //Retorna ação de continuação referente ao enum TipoServiço
            retornoPopUp = 2;
            this.Close();
        }

        /// <summary>
        /// Método de click que retorna a opção de não
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btNao_Click(object sender, EventArgs e)
        {
            //Retorna ação de não referente ao enum TipoServiço
            retornoPopUp = 3;
            this.Close();
        }

        /// <summary>
        /// Método que faz o retorna o que foi escolhido pelo cliente
        /// </summary>
        /// <returns></returns>
        public int RetornoPopUp() { return retornoPopUp; }
    }
}
