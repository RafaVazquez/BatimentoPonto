namespace BatimentoPontoHomeOffice
{
    partial class FormMotivoHorario
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
            this.lbDescMotivo = new System.Windows.Forms.Label();
            this.tbMotivoHorario = new System.Windows.Forms.TextBox();
            this.btFinalizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(173)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 41);
            this.panel1.TabIndex = 0;
            // 
            // lbDescMotivo
            // 
            this.lbDescMotivo.AutoSize = true;
            this.lbDescMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescMotivo.Location = new System.Drawing.Point(94, 65);
            this.lbDescMotivo.Name = "lbDescMotivo";
            this.lbDescMotivo.Size = new System.Drawing.Size(298, 20);
            this.lbDescMotivo.TabIndex = 1;
            this.lbDescMotivo.Text = "Insira o motivo da saída antecipada:";
            // 
            // tbMotivoHorario
            // 
            this.tbMotivoHorario.Location = new System.Drawing.Point(41, 108);
            this.tbMotivoHorario.Name = "tbMotivoHorario";
            this.tbMotivoHorario.Size = new System.Drawing.Size(409, 20);
            this.tbMotivoHorario.TabIndex = 2;
            // 
            // btFinalizar
            // 
            this.btFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(154)))), ((int)(((byte)(0)))));
            this.btFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFinalizar.ForeColor = System.Drawing.Color.White;
            this.btFinalizar.Location = new System.Drawing.Point(174, 147);
            this.btFinalizar.Name = "btFinalizar";
            this.btFinalizar.Size = new System.Drawing.Size(137, 41);
            this.btFinalizar.TabIndex = 3;
            this.btFinalizar.Text = "Finalizar";
            this.btFinalizar.UseVisualStyleBackColor = false;
            this.btFinalizar.Click += new System.EventHandler(this.btFinalizar_Click);
            // 
            // FormMotivoHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 210);
            this.Controls.Add(this.btFinalizar);
            this.Controls.Add(this.tbMotivoHorario);
            this.Controls.Add(this.lbDescMotivo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMotivoHorario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMotivoHorario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbDescMotivo;
        private System.Windows.Forms.TextBox tbMotivoHorario;
        private System.Windows.Forms.Button btFinalizar;
    }
}