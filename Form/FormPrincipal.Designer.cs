namespace BatimentoPontoHomeOffice
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.btMinimizar = new System.Windows.Forms.Button();
            this.btFechar = new System.Windows.Forms.Button();
            this.lbHorarioReal = new System.Windows.Forms.Label();
            this.timerHorarioReal = new System.Windows.Forms.Timer(this.components);
            this.btInicioExpediente = new System.Windows.Forms.Button();
            this.btInicioAlmoco = new System.Windows.Forms.Button();
            this.timerCronometroAlmoco = new System.Windows.Forms.Timer(this.components);
            this.btFimAlmoco = new System.Windows.Forms.Button();
            this.btFimExpediente = new System.Windows.Forms.Button();
            this.lbHorarioAlmoco = new System.Windows.Forms.Label();
            this.PanelSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(173)))));
            this.PanelSuperior.Controls.Add(this.btMinimizar);
            this.PanelSuperior.Controls.Add(this.btFechar);
            this.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(660, 41);
            this.PanelSuperior.TabIndex = 0;
            // 
            // btMinimizar
            // 
            this.btMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btMinimizar.FlatAppearance.BorderSize = 0;
            this.btMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMinimizar.ForeColor = System.Drawing.Color.White;
            this.btMinimizar.Location = new System.Drawing.Point(572, 0);
            this.btMinimizar.Margin = new System.Windows.Forms.Padding(0);
            this.btMinimizar.Name = "btMinimizar";
            this.btMinimizar.Size = new System.Drawing.Size(44, 41);
            this.btMinimizar.TabIndex = 1;
            this.btMinimizar.Text = "-";
            this.btMinimizar.UseVisualStyleBackColor = false;
            this.btMinimizar.Click += new System.EventHandler(this.btMinimizar_Click);
            // 
            // btFechar
            // 
            this.btFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btFechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btFechar.FlatAppearance.BorderSize = 0;
            this.btFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFechar.ForeColor = System.Drawing.Color.White;
            this.btFechar.Location = new System.Drawing.Point(616, 0);
            this.btFechar.Margin = new System.Windows.Forms.Padding(0);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(44, 41);
            this.btFechar.TabIndex = 0;
            this.btFechar.Text = "X";
            this.btFechar.UseVisualStyleBackColor = false;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // lbHorarioReal
            // 
            this.lbHorarioReal.AutoSize = true;
            this.lbHorarioReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHorarioReal.Location = new System.Drawing.Point(127, 75);
            this.lbHorarioReal.Name = "lbHorarioReal";
            this.lbHorarioReal.Size = new System.Drawing.Size(409, 107);
            this.lbHorarioReal.TabIndex = 1;
            this.lbHorarioReal.Text = "12:10:02";
            // 
            // timerHorarioReal
            // 
            this.timerHorarioReal.Enabled = true;
            this.timerHorarioReal.Tick += new System.EventHandler(this.timerHorarioReal_Tick);
            // 
            // btInicioExpediente
            // 
            this.btInicioExpediente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(154)))), ((int)(((byte)(0)))));
            this.btInicioExpediente.FlatAppearance.BorderSize = 0;
            this.btInicioExpediente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btInicioExpediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInicioExpediente.ForeColor = System.Drawing.Color.White;
            this.btInicioExpediente.Location = new System.Drawing.Point(228, 211);
            this.btInicioExpediente.Name = "btInicioExpediente";
            this.btInicioExpediente.Size = new System.Drawing.Size(209, 49);
            this.btInicioExpediente.TabIndex = 2;
            this.btInicioExpediente.Text = "Início expediente";
            this.btInicioExpediente.UseVisualStyleBackColor = false;
            this.btInicioExpediente.Click += new System.EventHandler(this.btInicioExpediente_Click);
            // 
            // btInicioAlmoco
            // 
            this.btInicioAlmoco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(154)))), ((int)(((byte)(0)))));
            this.btInicioAlmoco.FlatAppearance.BorderSize = 0;
            this.btInicioAlmoco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btInicioAlmoco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInicioAlmoco.ForeColor = System.Drawing.Color.White;
            this.btInicioAlmoco.Location = new System.Drawing.Point(228, 211);
            this.btInicioAlmoco.Name = "btInicioAlmoco";
            this.btInicioAlmoco.Size = new System.Drawing.Size(209, 49);
            this.btInicioAlmoco.TabIndex = 3;
            this.btInicioAlmoco.Text = "Início almoço";
            this.btInicioAlmoco.UseVisualStyleBackColor = false;
            this.btInicioAlmoco.Visible = false;
            this.btInicioAlmoco.Click += new System.EventHandler(this.btInicioAlmoco_Click);
            // 
            // timerCronometroAlmoco
            // 
            this.timerCronometroAlmoco.Interval = 1000;
            this.timerCronometroAlmoco.Tick += new System.EventHandler(this.timerCronometroAlmoco_Tick);
            // 
            // btFimAlmoco
            // 
            this.btFimAlmoco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(154)))), ((int)(((byte)(0)))));
            this.btFimAlmoco.FlatAppearance.BorderSize = 0;
            this.btFimAlmoco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btFimAlmoco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFimAlmoco.ForeColor = System.Drawing.Color.White;
            this.btFimAlmoco.Location = new System.Drawing.Point(228, 211);
            this.btFimAlmoco.Name = "btFimAlmoco";
            this.btFimAlmoco.Size = new System.Drawing.Size(209, 49);
            this.btFimAlmoco.TabIndex = 4;
            this.btFimAlmoco.Text = "Fim almoço";
            this.btFimAlmoco.UseVisualStyleBackColor = false;
            this.btFimAlmoco.Visible = false;
            this.btFimAlmoco.Click += new System.EventHandler(this.btFimAlmoco_Click);
            // 
            // btFimExpediente
            // 
            this.btFimExpediente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(154)))), ((int)(((byte)(0)))));
            this.btFimExpediente.FlatAppearance.BorderSize = 0;
            this.btFimExpediente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btFimExpediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFimExpediente.ForeColor = System.Drawing.Color.White;
            this.btFimExpediente.Location = new System.Drawing.Point(228, 211);
            this.btFimExpediente.Name = "btFimExpediente";
            this.btFimExpediente.Size = new System.Drawing.Size(209, 49);
            this.btFimExpediente.TabIndex = 5;
            this.btFimExpediente.Text = "Fim expediente";
            this.btFimExpediente.UseVisualStyleBackColor = false;
            this.btFimExpediente.Visible = false;
            this.btFimExpediente.Click += new System.EventHandler(this.btFimExpediente_Click);
            // 
            // lbHorarioAlmoco
            // 
            this.lbHorarioAlmoco.AutoSize = true;
            this.lbHorarioAlmoco.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHorarioAlmoco.Location = new System.Drawing.Point(127, 75);
            this.lbHorarioAlmoco.Name = "lbHorarioAlmoco";
            this.lbHorarioAlmoco.Size = new System.Drawing.Size(409, 107);
            this.lbHorarioAlmoco.TabIndex = 6;
            this.lbHorarioAlmoco.Text = "01:00:00";
            this.lbHorarioAlmoco.Visible = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(660, 309);
            this.Controls.Add(this.lbHorarioAlmoco);
            this.Controls.Add(this.btFimExpediente);
            this.Controls.Add(this.btFimAlmoco);
            this.Controls.Add(this.btInicioAlmoco);
            this.Controls.Add(this.btInicioExpediente);
            this.Controls.Add(this.lbHorarioReal);
            this.Controls.Add(this.PanelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.PanelSuperior.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Button btMinimizar;
        private System.Windows.Forms.Label lbHorarioReal;
        private System.Windows.Forms.Timer timerHorarioReal;
        private System.Windows.Forms.Button btInicioExpediente;
        private System.Windows.Forms.Button btInicioAlmoco;
        private System.Windows.Forms.Timer timerCronometroAlmoco;
        private System.Windows.Forms.Button btFimAlmoco;
        private System.Windows.Forms.Button btFimExpediente;
        private System.Windows.Forms.Label lbHorarioAlmoco;
    }
}

