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
    public partial class FormMotivoHorario : Form
    {
        string motivoHorario;

        public FormMotivoHorario()
        {
            InitializeComponent();
        }

        private void btFinalizar_Click(object sender, EventArgs e)
        {
            motivoHorario = tbMotivoHorario.Text;
            this.Close();
        }

        /// <summary>
        /// Método que retorna o que foi escrito pelo usuário
        /// </summary>
        /// <returns></returns>
        public string RetornoMotivoHorario()
        {
            return motivoHorario;
        }
    }
}
