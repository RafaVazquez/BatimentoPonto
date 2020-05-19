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
    public partial class FormVerificacaoHorario : Form
    {
        MetodosInternos.TipoHorario retornoPopUp;
        string textoApresentado;

        public FormVerificacaoHorario(string textoPopUpVerificacaoHorario)
        {
            textoApresentado = textoPopUpVerificacaoHorario;
            InitializeComponent();
        }

        private void FormVerificacaoHorario_Load(object sender, EventArgs e)
        {
            //Atribui o texto a ser apresentado no popup
            lbTextHorario.Text = textoApresentado;
        }

        private void btSim_Click(object sender, EventArgs e)
        {
            retornoPopUp = MetodosInternos.TipoHorario.Sim;
            this.Close();
        }

        private void btNao_Click(object sender, EventArgs e)
        {
            retornoPopUp = MetodosInternos.TipoHorario.Nao;
            this.Close();
        }

        /// <summary>
        /// Método que retorna o que foi escolhido no PopUp
        /// </summary>
        /// <returns></returns>
        public int RetornoPopUpVerificaHorario()
        {
            return Convert.ToInt32(retornoPopUp);
        }
    }
}
