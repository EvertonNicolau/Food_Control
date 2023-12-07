namespace Food_Control.Formulários
{
    partial class frmLogin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CaixaSenha = new System.Windows.Forms.TextBox();
            this.CaixaUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BotaoEntrar = new System.Windows.Forms.Button();
            this.BotaoCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.BotaoCancelar);
            this.groupBox1.Controls.Add(this.CaixaSenha);
            this.groupBox1.Controls.Add(this.BotaoEntrar);
            this.groupBox1.Controls.Add(this.CaixaUsuario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Calligraphy", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 243);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CaixaSenha
            // 
            this.CaixaSenha.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaixaSenha.Location = new System.Drawing.Point(97, 181);
            this.CaixaSenha.Multiline = true;
            this.CaixaSenha.Name = "CaixaSenha";
            this.CaixaSenha.PasswordChar = '*';
            this.CaixaSenha.Size = new System.Drawing.Size(204, 24);
            this.CaixaSenha.TabIndex = 3;
            this.CaixaSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CaixaSenha.UseWaitCursor = true;
            this.CaixaSenha.TextChanged += new System.EventHandler(this.CaixaSenha_TextChanged);
            // 
            // CaixaUsuario
            // 
            this.CaixaUsuario.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaixaUsuario.Location = new System.Drawing.Point(97, 86);
            this.CaixaUsuario.Multiline = true;
            this.CaixaUsuario.Name = "CaixaUsuario";
            this.CaixaUsuario.PasswordChar = '*';
            this.CaixaUsuario.Size = new System.Drawing.Size(204, 26);
            this.CaixaUsuario.TabIndex = 2;
            this.CaixaUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CaixaUsuario.UseSystemPasswordChar = true;
            this.CaixaUsuario.UseWaitCursor = true;
            this.CaixaUsuario.TextChanged += new System.EventHandler(this.CaixaUsuario_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "usuária";
            // 
            // BotaoEntrar
            // 
            this.BotaoEntrar.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.BotaoEntrar.Font = new System.Drawing.Font("Lucida Calligraphy", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoEntrar.Location = new System.Drawing.Point(324, 202);
            this.BotaoEntrar.Name = "BotaoEntrar";
            this.BotaoEntrar.Size = new System.Drawing.Size(93, 35);
            this.BotaoEntrar.TabIndex = 1;
            this.BotaoEntrar.Text = "entre";
            this.BotaoEntrar.UseVisualStyleBackColor = true;
            this.BotaoEntrar.Click += new System.EventHandler(this.BotaoEntrar_Click);
            // 
            // BotaoCancelar
            // 
            this.BotaoCancelar.Font = new System.Drawing.Font("Lucida Calligraphy", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoCancelar.Location = new System.Drawing.Point(433, 202);
            this.BotaoCancelar.Name = "BotaoCancelar";
            this.BotaoCancelar.Size = new System.Drawing.Size(92, 35);
            this.BotaoCancelar.TabIndex = 2;
            this.BotaoCancelar.Text = "cancele";
            this.BotaoCancelar.UseVisualStyleBackColor = true;
            this.BotaoCancelar.Click += new System.EventHandler(this.BotaoCancelar_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 248);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CaixaSenha;
        private System.Windows.Forms.TextBox CaixaUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BotaoEntrar;
        private System.Windows.Forms.Button BotaoCancelar;
    }
}