using BatimentoPontoHomeOffice.BLL;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatimentoPontoHomeOffice
{
    public partial class FormPrincipal : Form
    {
        public static bool zerarCronometroAlmoco { get; set; }

        int totalHora;
        int totalMinuto;
        int totalSegundo;
        string caminhoCompletoMesAtual;
        string linhaAlterada;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método que realiza o fechamento do form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btFechar_Click(object sender, EventArgs e) => this.Close();

        /// <summary>
        /// Método que realiza o ato de minimizar o form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btMinimizar_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        /// <summary>
        /// Executado na abertura do programa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPrincipal_Load(object sender, EventArgs e) 
        {
            MetodosInternos metodosInternos = new MetodosInternos();
            //Realiza a criação do arquivo de batimento de ponto do mes atual caso não exista
            caminhoCompletoMesAtual = metodosInternos.RealizaCopiaArquivoBase($"C:\\Users\\{Environment.UserName}\\Documents\\BatimentoPonto");
        }

        /// <summary>
        /// Timer do horário real
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerHorarioReal_Tick(object sender, EventArgs e)
        {
            this.lbHorarioReal.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        /// <summary>
        /// Timer do horário regressivo de almoço
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerCronometroAlmoco_Tick(object sender, EventArgs e)
        {
            //Diminui o segundo do contador
            totalSegundo--;

            //Verifica se o contador foi zerado
            if (totalMinuto == 0 && totalSegundo == 0)
                zerarCronometroAlmoco = true;

            //Verifica se o cronometro ja chegou no estado de zerado
            if (zerarCronometroAlmoco)
            {
                if(totalSegundo < -59)
                {
                    totalMinuto++;
                    totalSegundo = 0;
                }

                if (totalMinuto > 59)
                {
                    totalHora++;
                    totalMinuto = 0;
                }

                this.lbHorarioAlmoco.ForeColor = Color.Red;
                this.lbHorarioAlmoco.Text = string.Concat($"0{totalHora}:", string.Concat((totalMinuto < 10 ? $"0{totalMinuto}" : totalMinuto.ToString()), ":"),
                    (totalSegundo*-1 < 10 ? $"0{totalSegundo*-1}" : (totalSegundo*-1).ToString()));
            }
            else
            {
                if (totalMinuto > 0)
                {
                    if (totalSegundo < 0)
                    {
                        totalSegundo = 59;
                        totalMinuto--;
                    }
                }

                this.lbHorarioAlmoco.Text = string.Concat("00:", string.Concat((totalMinuto < 10 ? $"0{totalMinuto}" : totalMinuto.ToString()), ":"),
                    (totalSegundo < 10 ? $"0{totalSegundo}" : totalSegundo.ToString()));
            }
        }

        /// <summary>
        /// Click do botão de início de expediente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btInicioExpediente_Click(object sender, EventArgs e)
        {
            MetodosInternos metodosInternos = new MetodosInternos();

            //Coloca data atual na primeira linha disponível
            Tuple<string, string> retornoExcel = metodosInternos.VerificaDataExcel(caminhoCompletoMesAtual);
            linhaAlterada = retornoExcel.Item1;

            //Verifica se horário não deve ser sobreescrito
            if(linhaAlterada != "")
            {
                if (string.IsNullOrEmpty(retornoExcel.Item2))
                {
                    //Realiza o registro do inicio do expediente no excel
                    metodosInternos.InsereHorarioExcel(caminhoCompletoMesAtual, string.Concat("B", linhaAlterada));
                    //Esconde o botão de inicio do expediente e apresenta o inicio do almoço
                    btInicioExpediente.Visible = false;
                    btInicioAlmoco.Visible = true;
                }
                else
                {
                    switch (retornoExcel.Item2)
                    {
                        case "btInicioAlmoco":
                            btInicioExpediente.Visible = false;
                            btInicioAlmoco.Visible = true;
                            break;
                        case "btFimAlmoco":
                            (totalHora, totalMinuto, totalSegundo) = metodosInternos.VerificaRestanteAlmoco(linhaAlterada, caminhoCompletoMesAtual);
                            
                            //Verifica se a quantidade de segundos é menor que 0
                            if(totalSegundo > 0)
                                totalSegundo++;
                            else
                            {
                                totalSegundo--;
                                lbHorarioAlmoco.ForeColor = Color.Red;
                            }
                            
                            lbHorarioAlmoco.Text = string.Concat(string.Concat((totalHora < 10 ? $"0{totalHora}" : totalHora.ToString()), ":"),
                                string.Concat((totalMinuto < 10 ? $"0{totalMinuto}" : totalMinuto.ToString()), ":"), (totalSegundo < 10 ? $"0{totalSegundo}" : totalSegundo.ToString()));
                            //Esconde o timer de tempo real e apresenta o timer regressivo
                            lbHorarioReal.Visible = false;
                            lbHorarioAlmoco.Visible = true;
                            //Inicia contágem do relógio
                            timerCronometroAlmoco.Enabled = true;
                            btInicioAlmoco.Visible = false;
                            btFimAlmoco.Visible = true;
                            break;
                        case "btFimExpediente":
                            btFimAlmoco.Visible = false;
                            btFimExpediente.Visible = true;
                            break;
                    }
                }
                
            }
        }

        /// <summary>
        /// Click do botão do inicio de almoço
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btInicioAlmoco_Click(object sender, EventArgs e)
        {
            //Realiza o registro do inicio do almoço no excel
            MetodosInternos metodosInternos = new MetodosInternos();
            metodosInternos.InsereHorarioExcel(caminhoCompletoMesAtual, string.Concat("C", linhaAlterada));

            //Esconde o botão de inicio do almoço e apresenta o do fim do almoço
            btInicioAlmoco.Visible = false;
            btFimAlmoco.Visible = true;

            //Esconde o timer de tempo real e apresenta o timer regressivo
            lbHorarioReal.Visible = false;
            lbHorarioAlmoco.Visible = true;

            //Inicia timer regressivo
            timerCronometroAlmoco.Enabled = true;
            totalHora = 0;
            totalMinuto = 59;
            totalSegundo = 60;
        }

        /// <summary>
        /// Click no botão de fim do almoço
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btFimAlmoco_Click(object sender, EventArgs e)
        {
            //Realiza o registro do fim do almoço no excel
            MetodosInternos metodosInternos = new MetodosInternos();
            metodosInternos.InsereHorarioExcel(caminhoCompletoMesAtual, string.Concat("D", linhaAlterada));

            //Esconde o botão de fim do almoço e apresenta o do fim do expediente
            btFimAlmoco.Visible = false;
            btFimExpediente.Visible = true;

            //Esconde timer de tempo de almoço e apresenta timer real
            lbHorarioAlmoco.Visible = false;
            lbHorarioReal.Visible = true;

            //Desativa timer regressivo do almoço
            lbHorarioAlmoco.ForeColor = Color.Black;
            timerCronometroAlmoco.Enabled = false;
            lbHorarioAlmoco.Text = "01:00:00";
        }

        /// <summary>
        /// Click no botão de fim de expediente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btFimExpediente_Click(object sender, EventArgs e)
        {
            //Realiza o registro do inicio do expediente no excel
            MetodosInternos metodosInternos = new MetodosInternos();

            //Chama método de verificação de horas trabalhadas
            if(metodosInternos.VerificaTotalHoras(caminhoCompletoMesAtual, linhaAlterada))
            {
                metodosInternos.InsereHorarioExcel(caminhoCompletoMesAtual, string.Concat("E", linhaAlterada));

                //Esconde o botão de fim do expediente e apresenta o do inicio do expediente
                btFimExpediente.Visible = false;
                btInicioExpediente.Visible = true;
            }
        }
    }
}
