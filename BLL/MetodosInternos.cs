using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatimentoPontoHomeOffice.BLL
{
    class MetodosInternos
    {
        /// <summary>
        /// Enum utilizado na reescrita e continuação dos registros da data atual
        /// </summary>
        public enum TipoServico
        {
            Reescrita = 1,
            Continuacao = 2,
            Nao = 3
        }

        /// <summary>
        /// Enum utilizado no retorno
        /// </summary>
        public enum TipoHorario
        {
            Sim = 1, 
            Nao = 2
        }

        /// <summary>
        /// Método que verifica se existe excel do mes criado, se não, realiza criação
        /// </summary>
        /// <param name="caminhoDestino">Caminho onde o arquivo deverá ser criado</param>
        public string RealizaCopiaArquivoBase(string caminhoDestino)
        {
            string caminhoCompleto = string.Concat(caminhoDestino, "\\BatimentoPonto", "_", DateTime.Now.Month.ToString(), "_", DateTime.Now.Year.ToString(), ".xlsx");

            //Verifica se a pasta base existe
            if (!Directory.Exists(caminhoDestino))
                //Cria pasta
                Directory.CreateDirectory(caminhoDestino);


            //Verifica se no caminho não existe arquivo do mes atual
            if (!File.Exists(caminhoCompleto))
            {   //Arquivo não existente no diretório
                //Copia arquivo base para o diretório informado
                File.Copy(string.Concat(AppDomain.CurrentDomain.BaseDirectory, "Arquivos\\ArquivoBase.xlsx"), caminhoCompleto);

                //Realiza alteração no arquivo para conter o mes atual
                string mesPorExtenso = DateTime.Now.ToString("MMMM", new System.Globalization.CultureInfo("pt-BR"));
                string textoCelCabecarioExcel = string.Concat("Histórico do mês de ", mesPorExtenso);

                //Realiza alteração do arquivo para conter o nome do mes atual
                //Abre documento a ser alterado
                using (SpreadsheetDocument doc = SpreadsheetDocument.Open(caminhoCompleto, true))
                {
                    //Pega a página do arquivo excel
                    var arqExcel = doc.WorkbookPart;
                    var pagExcel = arqExcel.Workbook.Descendants<Sheet>().FirstOrDefault();
                    var pagArqExcel = (WorksheetPart)(arqExcel.GetPartById(pagExcel.Id));

                    //Pega célula para alteração do mês
                    var celCabecarioExcel = pagArqExcel.Worksheet.Descendants<Cell>().Where(a => a.CellReference == "A1").FirstOrDefault();
                    var tabelaDeTexto = doc.WorkbookPart.GetPartsOfType<SharedStringTablePart>().First().SharedStringTable;

                    //Insere o texto na tabela de textos
                    var itemInserido = tabelaDeTexto.AppendChild(new SharedStringItem(new Text(textoCelCabecarioExcel)));

                    //Altera celula para receber texto
                    celCabecarioExcel.DataType = new EnumValue<CellValues>(CellValues.SharedString);
                    //Altera texto encontrado para ter o mes correto
                    celCabecarioExcel.CellValue = new CellValue(itemInserido.ElementsBefore().Count().ToString());
                }
            }

            return caminhoCompleto;
        }

        /// <summary>
        /// Método que insere a data na linha limpa
        /// </summary>
        /// <param name="caminhoCompleto">Caminho completo do arquivo a ser altarado</param>
        /// <returns></returns>
        public Tuple<string, string> VerificaDataExcel(string caminhoCompleto)
        {
            string linhaPreenchimentoDia = string.Empty;
            string botaoApresentar = string.Empty;
            bool modoPopup = false;

            using (SpreadsheetDocument doc = SpreadsheetDocument.Open(caminhoCompleto, true))
            {
                //Pega a página do arquivo excel
                var arqExcel = doc.WorkbookPart;
                var pagExcel = arqExcel.Workbook.Descendants<Sheet>().FirstOrDefault();
                var pagArqExcel = (WorksheetPart)(arqExcel.GetPartById(pagExcel.Id));

                //Tabela de textos das celulas da planilha
                var tabelaDeTexto = doc.WorkbookPart.GetPartsOfType<SharedStringTablePart>().First().SharedStringTable;

                //Percorre linhas da coluna A para verificar ultimo registro gravado
                for (int i = 3; i < DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month); i++)
                {
                    //Pega celula da linha do laço de repetição
                    var celCabecarioExcel = pagArqExcel.Worksheet.Descendants<Cell>().Where(a => a.CellReference == string.Concat("A", i.ToString())).FirstOrDefault();
                    //Verifica se a celula selecionada contem algum valor
                    if (celCabecarioExcel.InnerText != "")
                    {
                        //Verifica se a celula que contém valor não é a mesma da data atual
                        if (tabelaDeTexto.ElementAt(int.Parse(celCabecarioExcel.InnerText)).InnerText != DateTime.Now.ToString("dd/MM/yyyy"))
                            continue;
                        else
                        {   //Celula contém o mesmo dia atual

                            //Pega valores das celulas das linhas
                            var InicioExpediente = pagArqExcel.Worksheet.Descendants<Cell>().Where(a => a.CellReference == string.Concat("B", i.ToString())).FirstOrDefault();
                            var InicioAlmoco = pagArqExcel.Worksheet.Descendants<Cell>().Where(a => a.CellReference == string.Concat("C", i.ToString())).FirstOrDefault();
                            var FimAlmoco = pagArqExcel.Worksheet.Descendants<Cell>().Where(a => a.CellReference == string.Concat("D", i.ToString())).FirstOrDefault();
                            var FimExpediente = pagArqExcel.Worksheet.Descendants<Cell>().Where(a => a.CellReference == string.Concat("E", i.ToString())).FirstOrDefault();

                            //Faz uma verificação para apresentar a mensagem correta para o usuário
                            if (InicioExpediente.InnerText == string.Empty)
                            {
                                //Apresenta mensagem de continuação
                                modoPopup = true;
                            }
                            else
                            {
                                if(InicioAlmoco.InnerText == string.Empty)
                                {
                                    //Apresenta mensagem de continuacao
                                    modoPopup = true;
                                }
                                else
                                {
                                    if(FimAlmoco.InnerText == string.Empty)
                                    {
                                        //Apresenta mensagem de continuação
                                        modoPopup = true;
                                        //Informa qual botão deve ser apresentado
                                        botaoApresentar = "btFimAlmoco";
                                    }
                                    else
                                    {
                                        if (FimExpediente.InnerText == string.Empty)
                                        {
                                            //Apresenta mensagem de continuação
                                            modoPopup = true;
                                            //Informa qual botão deve ser apresentado
                                            botaoApresentar = "btFimExpediente";
                                        }
                                        else
                                            //Apresenta mensagem de reescrita
                                            modoPopup = false;
                                    }
                                }
                            }
                                

                            FormSobreescritaContinuacao formSobreescritaContinuacao = new FormSobreescritaContinuacao(modoPopup);
                            formSobreescritaContinuacao.ShowDialog();
                            var retornoPopUp = formSobreescritaContinuacao.RetornoPopUp();

                            if ((TipoServico)retornoPopUp == TipoServico.Reescrita)
                            {   //Reescrita será realizada
                                linhaPreenchimentoDia = i.ToString();
                                break;
                            }
                            else if ((TipoServico)retornoPopUp == TipoServico.Continuacao)
                            {   //Continuação será realizada
                                linhaPreenchimentoDia = i.ToString();
                                break;
                            }
                            else
                                //Retorna valor vazio
                                return new Tuple<string, string>(string.Empty, string.Empty);
                        }
                    }

                    //Insere o texto na tabela de textos
                    var itemInserido = tabelaDeTexto.AppendChild(new SharedStringItem(new Text(DateTime.Now.ToString("dd/MM/yyyy"))));

                    //Altera celula para receber texto
                    celCabecarioExcel.DataType = new EnumValue<CellValues>(CellValues.SharedString);
                    //Altera texto encontrado para ter a data do dia atual
                    celCabecarioExcel.CellValue = new CellValue(itemInserido.ElementsBefore().Count().ToString());

                    //Pega linha para retorno
                    linhaPreenchimentoDia = i.ToString();
                    break;
                }
            }

            return new Tuple<string, string>(linhaPreenchimentoDia, botaoApresentar);
        }

        /// <summary>
        /// Método que faz o registro do horário que o botão foi clicado
        /// </summary>
        /// <param name="caminhoCompleto">Caminho do excel a ser alterado</param>
        /// <param name="linhaColunaAlterar">Linha e coluna que deve ser alterada</param>
        public void InsereHorarioExcel(string caminhoCompleto, string linhaColunaAlterar)
        {
            //Realiza alteração do arquivo para conter o horário que o botao foi clicado
            //Abre documento a ser alterado
            using (SpreadsheetDocument doc = SpreadsheetDocument.Open(caminhoCompleto, true))
            {
                //Pega a página do arquivo excel
                var arqExcel = doc.WorkbookPart;
                var pagExcel = arqExcel.Workbook.Descendants<Sheet>().FirstOrDefault();
                var pagArqExcel = (WorksheetPart)(arqExcel.GetPartById(pagExcel.Id));

                //Pega célula para inclusão do horário
                var celCabecarioExcel = pagArqExcel.Worksheet.Descendants<Cell>().Where(a => a.CellReference == linhaColunaAlterar).FirstOrDefault();
                var tabelaDeTexto = doc.WorkbookPart.GetPartsOfType<SharedStringTablePart>().First().SharedStringTable;

                //Insere o texto na tabela de textos
                var itemInserido = tabelaDeTexto.AppendChild(new SharedStringItem(new Text(DateTime.Now.ToString("HH:mm:ss"))));

                //Altera celula para receber texto
                celCabecarioExcel.DataType = new EnumValue<CellValues>(CellValues.SharedString);
                //Altera texto encontrado para ter o horário atual
                celCabecarioExcel.CellValue = new CellValue(itemInserido.ElementsBefore().Count().ToString());
            }
        }

        /// <summary>
        /// Método que verifica a quantidade de horas restantes de almoço
        /// </summary>
        /// <param name="linhaAlterada">Variável que mostra qual linha da planilha está sendo alterada</param>
        /// <param name="caminhoCompleto">Variável que contem o caminho completo da planilha</param>
        /// <returns></returns>
        public (int, int, int) VerificaRestanteAlmoco(string linhaAlterada, string caminhoCompleto)
        {
            int hora = 0;
            int minuto = 0;
            int segundo = 0;
            DateTime restanteHorarioDateTime = new DateTime();
            TimeSpan restanteHorarioTimeSpan = new TimeSpan();

            using (SpreadsheetDocument doc = SpreadsheetDocument.Open(caminhoCompleto, true))
            {
                //Pega a página do arquivo excel
                var arqExcel = doc.WorkbookPart;
                var pagExcel = arqExcel.Workbook.Descendants<Sheet>().FirstOrDefault();
                var pagArqExcel = (WorksheetPart)(arqExcel.GetPartById(pagExcel.Id));

                //Pega célula para verificar horario de inicio de almoco
                var celInicioAlmoco = pagArqExcel.Worksheet.Descendants<Cell>().Where(a => a.CellReference == string.Concat("C", linhaAlterada)).FirstOrDefault();
                var tabelaDeTexto = doc.WorkbookPart.GetPartsOfType<SharedStringTablePart>().FirstOrDefault();

                var horarioInicioAlmoco = tabelaDeTexto.SharedStringTable.ElementAt(int.Parse(celInicioAlmoco.InnerText)).InnerText;
                var diferencaHorario = DateTime.Now.Subtract(Convert.ToDateTime(horarioInicioAlmoco));

                //Verifica se diferença é maior que 1 hora
                if (diferencaHorario.Hours >= 1)
                {   //Diferença maior que uma hora
                    restanteHorarioTimeSpan = diferencaHorario.Subtract(new TimeSpan(0, 1, 0, 0, 0));

                    FormPrincipal.zerarCronometroAlmoco = true;
                    hora = restanteHorarioTimeSpan.Hours;
                    minuto = restanteHorarioTimeSpan.Minutes;
                    segundo = restanteHorarioTimeSpan.Seconds * -1;
                }
                else
                {   //Diferença menor que uma hora
                    restanteHorarioDateTime = Convert.ToDateTime("01:00:00").Subtract(diferencaHorario);

                    hora = restanteHorarioDateTime.Hour;
                    minuto = restanteHorarioDateTime.Minute;
                    segundo = restanteHorarioDateTime.Second;
                }

                return (hora, minuto, segundo);
            }
        }

        /// <summary>
        /// Método que verifica se o total de horas do dia foi finalizado
        /// </summary>
        /// <param name="caminhoCompleto">Caminho do arquivo excel</param>
        /// <param name="linhaVerificacao">Linha a ser verificada</param>
        /// <returns></returns>
        public bool VerificaTotalHoras(string caminhoCompleto, string linhaVerificacao)
        {
            bool finalizaExpediente = true;
            SharedStringItem itemInserido = new SharedStringItem();

            using (SpreadsheetDocument doc = SpreadsheetDocument.Open(caminhoCompleto, true))
            {
                //Pega a página do arquivo excel
                var arqExcel = doc.WorkbookPart;
                var pagExcel = arqExcel.Workbook.Descendants<Sheet>().FirstOrDefault();
                var pagArqExcel = (WorksheetPart)(arqExcel.GetPartById(pagExcel.Id));

                //Pega célula para verificar horários do dia
                var celInicioExpediente = pagArqExcel.Worksheet.Descendants<Cell>().Where(a => a.CellReference == string.Concat("B", linhaVerificacao)).FirstOrDefault();
                var celInicioAlmoco = pagArqExcel.Worksheet.Descendants<Cell>().Where(a => a.CellReference == string.Concat("C", linhaVerificacao)).FirstOrDefault();
                var celFimAlmoco = pagArqExcel.Worksheet.Descendants<Cell>().Where(a => a.CellReference == string.Concat("D", linhaVerificacao)).FirstOrDefault();
                var celFinalizouExpediente = pagArqExcel.Worksheet.Descendants<Cell>().Where(a => a.CellReference == string.Concat("F", linhaVerificacao)).FirstOrDefault();
                var celMotivo = pagArqExcel.Worksheet.Descendants<Cell>().Where(a => a.CellReference == string.Concat("G", linhaVerificacao)).FirstOrDefault();
                var tabelaDeTexto = doc.WorkbookPart.GetPartsOfType<SharedStringTablePart>().FirstOrDefault().SharedStringTable;

                //Pega horários de cada registro do dia
                var horarioInicioExpediente = tabelaDeTexto.ElementAt(int.Parse(celInicioExpediente.InnerText)).InnerText;
                var horarioInicioAlmoco = tabelaDeTexto.ElementAt(int.Parse(celInicioAlmoco.InnerText)).InnerText;
                var horarioFimAlmoco = tabelaDeTexto.ElementAt(int.Parse(celFimAlmoco.InnerText)).InnerText;

                //Faz verificação matematica para ver se fez mais de 8h de trabalho
                var diferencaHorarioSemAlmoco = DateTime.Now.Subtract(Convert.ToDateTime(horarioInicioExpediente));
                var expedienteTotal = diferencaHorarioSemAlmoco.Subtract(Convert.ToDateTime(horarioFimAlmoco).Subtract(Convert.ToDateTime(horarioInicioAlmoco)));

                //Verifica se o expediente total é menor que 8 horas
                if(expedienteTotal.Hours < 8)
                {
                    FormVerificacaoHorario formVerificacaoHorario = new FormVerificacaoHorario("Não foram completadas as 08 horas de trabalho, \r\ndeseja realmente finalizar o expediente ? ");
                    formVerificacaoHorario.ShowDialog();
                    //Verifica se foi clicado em sim ou não
                    if (formVerificacaoHorario.RetornoPopUpVerificaHorario() == Convert.ToInt32(TipoHorario.Sim))
                    {   //Foi clicado em sim
                        FormVerificacaoHorario formInformarMotivo = new FormVerificacaoHorario("Deseja informar um motivo para a saída adiantada?");
                        formInformarMotivo.ShowDialog();
                        //Verifica se o usuário quer registrar motivo para a saída adiantada
                        if (formInformarMotivo.RetornoPopUpVerificaHorario() == Convert.ToInt32(TipoHorario.Sim))
                        {   //Deseja anotar o motivo

                            //Insere o texto na tabela de textos
                            itemInserido = tabelaDeTexto.AppendChild(new SharedStringItem(new Text("Não")));
                            //Altera celula para receber texto
                            celFinalizouExpediente.DataType = new EnumValue<CellValues>(CellValues.SharedString);
                            //Altera texto encontrado para ter a situação do expediente
                            celFinalizouExpediente.CellValue = new CellValue(itemInserido.ElementsBefore().Count().ToString());

                            //Instancia form de motivo para saída antecipada
                            FormMotivoHorario formMotivoHorario = new FormMotivoHorario();
                            //Insere motivo
                            formMotivoHorario.ShowDialog();
                            //Insere o texto na tabela de textos
                            itemInserido = tabelaDeTexto.AppendChild(new SharedStringItem(new Text(formMotivoHorario.RetornoMotivoHorario())));
                            celMotivo.DataType = new EnumValue<CellValues>(CellValues.SharedString);
                            //Altera texto encontrado para ter a situação do expediente
                            celMotivo.CellValue = new CellValue(itemInserido.ElementsBefore().Count().ToString());
                        }

                        //Insere o texto na tabela de textos
                        itemInserido = tabelaDeTexto.AppendChild(new SharedStringItem(new Text("Não")));
                        //Altera celula para receber texto
                        celFinalizouExpediente.DataType = new EnumValue<CellValues>(CellValues.SharedString);
                        //Altera texto encontrado para ter a situação do expediente
                        celFinalizouExpediente.CellValue = new CellValue(itemInserido.ElementsBefore().Count().ToString());

                    }
                    else
                        //Não deseja finalizar o expediente no momento
                        finalizaExpediente = false;
                }
                else
                {   //Expediente completo
                    //Insere o texto na tabela de textos
                    itemInserido = tabelaDeTexto.AppendChild(new SharedStringItem(new Text("Sim")));
                    //Altera celula para receber texto
                    celFinalizouExpediente.DataType = new EnumValue<CellValues>(CellValues.SharedString);
                    //Altera texto encontrado para ter a situação do expediente
                    celFinalizouExpediente.CellValue = new CellValue(itemInserido.ElementsBefore().Count().ToString());
                }
            }

            return finalizaExpediente;
        }
    }
}
