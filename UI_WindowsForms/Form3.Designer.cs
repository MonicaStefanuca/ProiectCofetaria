namespace UI_WindowsForms
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panel2 = new System.Windows.Forms.Panel();
            this.ProduseLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.adminProdusele = new System.Windows.Forms.Button();
            this.adminAngajatii = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonexit = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(10)))));
            this.panel2.Controls.Add(this.ProduseLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(708, 97);
            this.panel2.TabIndex = 18;
            // 
            // ProduseLabel
            // 
            this.ProduseLabel.AutoSize = true;
            this.ProduseLabel.Font = new System.Drawing.Font("MV Boli", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProduseLabel.ForeColor = System.Drawing.Color.PeachPuff;
            this.ProduseLabel.Location = new System.Drawing.Point(164, 9);
            this.ProduseLabel.Name = "ProduseLabel";
            this.ProduseLabel.Size = new System.Drawing.Size(288, 62);
            this.ProduseLabel.TabIndex = 3;
            this.ProduseLabel.Text = "COFETARIE";
            this.ProduseLabel.Click += new System.EventHandler(this.ProduseLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 334);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(10)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 334);
            this.panel1.TabIndex = 20;
            // 
            // adminProdusele
            // 
            this.adminProdusele.BackColor = System.Drawing.Color.SaddleBrown;
            this.adminProdusele.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminProdusele.ForeColor = System.Drawing.Color.PeachPuff;
            this.adminProdusele.Location = new System.Drawing.Point(324, 177);
            this.adminProdusele.Name = "adminProdusele";
            this.adminProdusele.Size = new System.Drawing.Size(306, 64);
            this.adminProdusele.TabIndex = 9;
            this.adminProdusele.Text = "Administrare Produse";
            this.adminProdusele.UseVisualStyleBackColor = false;
            this.adminProdusele.Click += new System.EventHandler(this.adminProdusele_Click);
            // 
            // adminAngajatii
            // 
            this.adminAngajatii.BackColor = System.Drawing.Color.SaddleBrown;
            this.adminAngajatii.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAngajatii.ForeColor = System.Drawing.Color.PeachPuff;
            this.adminAngajatii.Location = new System.Drawing.Point(324, 262);
            this.adminAngajatii.Name = "adminAngajatii";
            this.adminAngajatii.Size = new System.Drawing.Size(306, 64);
            this.adminAngajatii.TabIndex = 2;
            this.adminAngajatii.Text = "Administrare Angajati";
            this.adminAngajatii.UseVisualStyleBackColor = false;
            this.adminAngajatii.Click += new System.EventHandler(this.adminAngajatii_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
            this.panel3.Controls.Add(this.buttonexit);
            this.panel3.Location = new System.Drawing.Point(0, -23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 36);
            this.panel3.TabIndex = 21;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // buttonexit
            // 
            this.buttonexit.BackColor = System.Drawing.Color.DarkRed;
            this.buttonexit.FlatAppearance.BorderSize = 0;
            this.buttonexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonexit.Location = new System.Drawing.Point(770, 0);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(30, 30);
            this.buttonexit.TabIndex = 2;
            this.buttonexit.Text = "X";
            this.buttonexit.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
            this.panel4.Controls.Add(this.button1);
            this.panel4.Location = new System.Drawing.Point(-46, 417);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 27);
            this.panel4.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(770, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(708, 431);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.adminProdusele);
            this.Controls.Add(this.adminAngajatii);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form3";
            this.Text = "Pagina de pornire";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ProduseLabel;
        internal System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button adminProdusele;
        private System.Windows.Forms.Button adminAngajatii;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
    }
}