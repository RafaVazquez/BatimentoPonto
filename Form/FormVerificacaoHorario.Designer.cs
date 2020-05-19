namespace BatimentoPontoHomeOffice
{
    partial class FormVerificacaoHorario
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
            this.lbTextHorario = new System.Windows.Forms.Label();
            this.btSim = new System.Windows.Forms.Button();
            this.btNao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(173)))));
            this.panel1.Location = new System.Drawing.Point(-9, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 41);
            this.panel1.TabIndex = 0;
            // 
            // lbTextHorario
            // 
            this.lbTextHorario.AutoSize = true;
            this.lbTextHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextHorario.Location = new System.Drawing.Point(40, 64);
            this.lbTextHorario.Name = "lbTextHorario";
            this.lbTextHorario.Size = new System.Drawing.Size(404, 40);
            this.lbTextHorario.TabIndex = 1;
            this.lbTextHorario.Text = "Não foram completadas as 08 horas de trabalho, \r\ndeseja realmente finalizar o exp" +
    "ediente?";
            this.lbTextHorario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btSim
            // 
            this.btSim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(154)))), ((int)(((byte)(0)))));
            this.btSim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSim.ForeColor = System.Drawing.Color.White;
            this.btSim.Location = new System.Drawing.Point(76, 130);
            this.btSim.Name = "btSim";
            this.btSim.Size = new System.Drawing.Size(137, 41);
            this.btSim.TabIndex = 2;
            this.btSim.Text = "Sim";
            this.btSim.UseVisualStyleBackColor = false;
            this.btSim.Click += new System.EventHandler(this.btSim_Click);
            // 
            // btNao
            // 
            this.btNao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(154)))), ((int)(((byte)(0)))));
            this.btNao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btNao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNao.ForeColor = System.Drawing.Color.White;
            this.btNao.Location = new System.Drawing.Point(259, 130);
            this.btNao.Name = "btNao";
            this.btNao.Size = new System.Drawing.Size(137, 41);
            this.btNao.TabIndex = 3;
            this.btNao.Text = "Não";
            this.btNao.UseVisualStyleBackColor = false;
            this.btNao.Click += new System.EventHandler(this.btNao_Click);
            // 
            // FormVerificacaoHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 184);
            this.Controls.Add(this.btNao);
            this.Controls.Add(this.btSim);
            this.Controls.Add(this.lbTextHorario);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVerificacaoHorario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVerificacaoHorario";
            this.Load += new System.EventHandler(this.FormVerificacaoHorario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTextHorario;
        private System.Windows.Forms.Button btSim;
        private System.Windows.Forms.Button btNao;
    }
}