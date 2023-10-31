namespace Food_Control
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txtbox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt1.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt1.Font = new System.Drawing.Font("Vineta BT", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.Location = new System.Drawing.Point(380, 217);
            this.txt1.Multiline = true;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(444, 117);
            this.txt1.TabIndex = 1;
            this.txt1.Text = "desktop control food";
            this.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbox1
            // 
            this.txtbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(227)))));
            this.txtbox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox1.Font = new System.Drawing.Font("Vineta BT", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(108)))), ((int)(((byte)(84)))));
            this.txtbox1.Location = new System.Drawing.Point(353, 260);
            this.txtbox1.Multiline = true;
            this.txtbox1.Name = "txtbox1";
            this.txtbox1.Size = new System.Drawing.Size(272, 146);
            this.txtbox1.TabIndex = 4;
            this.txtbox1.Text = "desktop control food";
            this.txtbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(93, 373);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(942, 625);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 625);
            this.Controls.Add(this.txtbox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txtbox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

