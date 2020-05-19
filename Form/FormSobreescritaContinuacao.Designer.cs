namespace BatimentoPontoHomeOffice
{
    partial class FormSobreescritaContinuacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTextoReescrita = new System.Windows.Forms.Label();
            this.lbTextoContinuacao = new System.Windows.Forms.Label();
            this.btSobreescrever = new System.Windows.Forms.Button();
            this.btNao = new System.Windows.Forms.Button();
            this.btContinuar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(173)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 41);
            this.panel1.TabIndex = 0;
            // 
            // lbTextoReescrita
            // 
            this.lbTextoReescrita.AutoSize = true;
            this.lbTextoReescrita.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextoReescrita.Location = new System.Drawing.Point(93, 73);
            this.lbTextoReescrita.Name = "lbTextoReescrita";
            this.lbTextoReescrita.Size = new System.Drawing.Size(471, 48);
            this.lbTextoReescrita.TabIndex = 1;
            this.lbTextoReescrita.Text = "Já existem horários registrados para a data atual, \r\ndeseja reescreve-los?";
            this.lbTextoReescrita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTextoContinuacao
            // 
            this.lbTextoContinuacao.AutoSize = true;
            this.lbTextoContinuacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextoContinuacao.Location = new System.Drawing.Point(93, 61);
            this.lbTextoContinuacao.Name = "lbTextoContinuacao";
            this.lbTextoContinuacao.Size = new System.Drawing.Size(465, 72);
            this.lbTextoContinuacao.TabIndex = 2;
            this.lbTextoContinuacao.Text = "Já existem horários registrados para a data atual,\r\nmas eles não estão completos," +
    " \r\ndeseja continuar ou reescreve-los?\r\n";
            this.lbTextoContinuacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btSobreescrever
            // 
            this.btSobreescrever.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(154)))), ((int)(((byte)(0)))));
            this.btSobreescrever.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSobreescrever.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSobreescrever.ForeColor = System.Drawing.Color.White;
            this.btSobreescrever.Location = new System.Drawing.Point(58, 159);
            this.btSobreescrever.Name = "btSobreescrever";
            this.btSobreescrever.Size = new System.Drawing.Size(137, 41);
            this.btSobreescrever.TabIndex = 3;
            this.btSobreescrever.Text = "Reescrever";
            this.btSobreescrever.UseVisualStyleBackColor = false;
            this.btSobreescrever.Click += new System.EventHandler(this.btSobreescrever_Click);
            // 
            // btNao
            // 
            this.btNao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(154)))), ((int)(((byte)(0)))));
            this.btNao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btNao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNao.ForeColor = System.Drawing.Color.White;
            this.btNao.Location = new System.Drawing.Point(459, 159);
            this.btNao.Name = "btNao";
            this.btNao.Size = new System.Drawing.Size(137, 41);
            this.btNao.TabIndex = 4;
            this.btNao.Text = "Não";
            this.btNao.UseVisualStyleBackColor = false;
            this.btNao.Click += new System.EventHandler(this.btNao_Click);
            // 
            // btContinuar
            // 
            this.btContinuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(154)))), ((int)(((byte)(0)))));
            this.btContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btContinuar.ForeColor = System.Drawing.Color.White;
            this.btContinuar.Location = new System.Drawing.Point(258, 159);
            this.btContinuar.Name = "btContinuar";
            this.btContinuar.Size = new System.Drawing.Size(137, 41);
            this.btContinuar.TabIndex = 5;
            this.btContinuar.Text = "Continuar";
            this.btContinuar.UseVisualStyleBackColor = false;
            this.btContinuar.Click += new System.EventHandler(this.btContinuar_Click);
            // 
            // FormSobreescritaContinuacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 223);
            this.Controls.Add(this.btContinuar);
            this.Controls.Add(this.btNao);
            this.Controls.Add(this.btSobreescrever);
            this.Controls.Add(this.lbTextoContinuacao);
            this.Controls.Add(this.lbTextoReescrita);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSobreescritaContinuacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormSobreescritaContinuacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTextoReescrita;
        private System.Windows.Forms.Label lbTextoContinuacao;
        private System.Windows.Forms.Button btSobreescrever;
        private System.Windows.Forms.Button btNao;
        private System.Windows.Forms.Button btContinuar;
    }
}