namespace UI_WindowsForms
{
    partial class Form2
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
            this.GramajCheck = new System.Windows.Forms.CheckBox();
            this.PretCheck = new System.Windows.Forms.CheckBox();
            this.PatiserieRadioB = new System.Windows.Forms.RadioButton();
            this.TortRadioB = new System.Windows.Forms.RadioButton();
            this.PrajituraRadioB = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numarPtext = new System.Windows.Forms.TextBox();
            this.DespartireNrProduseTxt = new System.Windows.Forms.Label();
            this.NrProduseTxt = new System.Windows.Forms.Label();
            this.CategorieTxt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.adaugareProduseInfisier = new System.Windows.Forms.Button();
            this.pretPtext = new System.Windows.Forms.TextBox();
            this.gramajPtext = new System.Windows.Forms.TextBox();
            this.numePtext = new System.Windows.Forms.TextBox();
            this.GramajTxt = new System.Windows.Forms.Label();
            this.PretTxt = new System.Windows.Forms.Label();
            this.NumeTxt = new System.Windows.Forms.Label();
            this.CategorieLabel = new System.Windows.Forms.Label();
            this.Numelabel = new System.Windows.Forms.Label();
            this.PretLabel = new System.Windows.Forms.Label();
            this.GramajLabel = new System.Windows.Forms.Label();
            this.NrProdusePrepLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ProduseLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.GramajCheck);
            this.panel1.Controls.Add(this.PretCheck);
            this.panel1.Controls.Add(this.PatiserieRadioB);
            this.panel1.Controls.Add(this.TortRadioB);
            this.panel1.Controls.Add(this.PrajituraRadioB);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numarPtext);
            this.panel1.Controls.Add(this.DespartireNrProduseTxt);
            this.panel1.Controls.Add(this.NrProduseTxt);
            this.panel1.Controls.Add(this.CategorieTxt);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.adaugareProduseInfisier);
            this.panel1.Controls.Add(this.pretPtext);
            this.panel1.Controls.Add(this.gramajPtext);
            this.panel1.Controls.Add(this.numePtext);
            this.panel1.Controls.Add(this.GramajTxt);
            this.panel1.Controls.Add(this.PretTxt);
            this.panel1.Controls.Add(this.NumeTxt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 1008);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // GramajCheck
            // 
            this.GramajCheck.AutoSize = true;
            this.GramajCheck.Location = new System.Drawing.Point(16, 704);
            this.GramajCheck.Name = "GramajCheck";
            this.GramajCheck.Size = new System.Drawing.Size(212, 20);
            this.GramajCheck.TabIndex = 21;
            this.GramajCheck.Text = "Am introdus gramajul in grame.";
            this.GramajCheck.UseVisualStyleBackColor = true;
            // 
            // PretCheck
            // 
            this.PretCheck.AutoSize = true;
            this.PretCheck.Location = new System.Drawing.Point(16, 660);
            this.PretCheck.Name = "PretCheck";
            this.PretCheck.Size = new System.Drawing.Size(168, 20);
            this.PretCheck.TabIndex = 20;
            this.PretCheck.Text = "Am introdus pretul in lei.";
            this.PretCheck.UseVisualStyleBackColor = true;
            // 
            // PatiserieRadioB
            // 
            this.PatiserieRadioB.AutoSize = true;
            this.PatiserieRadioB.Font = new System.Drawing.Font("MV Boli", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatiserieRadioB.ForeColor = System.Drawing.Color.SaddleBrown;
            this.PatiserieRadioB.Location = new System.Drawing.Point(136, 466);
            this.PatiserieRadioB.Name = "PatiserieRadioB";
            this.PatiserieRadioB.Size = new System.Drawing.Size(170, 21);
            this.PatiserieRadioB.TabIndex = 19;
            this.PatiserieRadioB.TabStop = true;
            this.PatiserieRadioB.Text = "Produse de patiserie";
            this.PatiserieRadioB.UseVisualStyleBackColor = true;
            // 
            // TortRadioB
            // 
            this.TortRadioB.AutoSize = true;
            this.TortRadioB.Font = new System.Drawing.Font("MV Boli", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TortRadioB.ForeColor = System.Drawing.Color.SaddleBrown;
            this.TortRadioB.Location = new System.Drawing.Point(136, 430);
            this.TortRadioB.Name = "TortRadioB";
            this.TortRadioB.Size = new System.Drawing.Size(61, 21);
            this.TortRadioB.TabIndex = 18;
            this.TortRadioB.TabStop = true;
            this.TortRadioB.Text = "Tort";
            this.TortRadioB.UseVisualStyleBackColor = true;
            // 
            // PrajituraRadioB
            // 
            this.PrajituraRadioB.AutoSize = true;
            this.PrajituraRadioB.Font = new System.Drawing.Font("MV Boli", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrajituraRadioB.ForeColor = System.Drawing.Color.SaddleBrown;
            this.PrajituraRadioB.Location = new System.Drawing.Point(136, 390);
            this.PrajituraRadioB.Name = "PrajituraRadioB";
            this.PrajituraRadioB.Size = new System.Drawing.Size(91, 21);
            this.PrajituraRadioB.TabIndex = 17;
            this.PrajituraRadioB.TabStop = true;
            this.PrajituraRadioB.Text = "Prajitura";
            this.PrajituraRadioB.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Sienna;
            this.label2.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.PeachPuff;
            this.label2.Location = new System.Drawing.Point(94, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 37);
            this.label2.TabIndex = 16;
            this.label2.Text = "produse";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Sienna;
            this.label1.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PeachPuff;
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Informatii despre ";
            // 
            // numarPtext
            // 
            this.numarPtext.BackColor = System.Drawing.Color.AntiqueWhite;
            this.numarPtext.Location = new System.Drawing.Point(136, 542);
            this.numarPtext.Name = "numarPtext";
            this.numarPtext.Size = new System.Drawing.Size(133, 22);
            this.numarPtext.TabIndex = 15;
            // 
            // DespartireNrProduseTxt
            // 
            this.DespartireNrProduseTxt.AutoSize = true;
            this.DespartireNrProduseTxt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DespartireNrProduseTxt.ForeColor = System.Drawing.Color.SaddleBrown;
            this.DespartireNrProduseTxt.Location = new System.Drawing.Point(12, 567);
            this.DespartireNrProduseTxt.Name = "DespartireNrProduseTxt";
            this.DespartireNrProduseTxt.Size = new System.Drawing.Size(199, 25);
            this.DespartireNrProduseTxt.TabIndex = 13;
            this.DespartireNrProduseTxt.Text = "produse preparate";
            this.DespartireNrProduseTxt.Click += new System.EventHandler(this.label1_Click);
            // 
            // NrProduseTxt
            // 
            this.NrProduseTxt.AutoSize = true;
            this.NrProduseTxt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NrProduseTxt.ForeColor = System.Drawing.Color.SaddleBrown;
            this.NrProduseTxt.Location = new System.Drawing.Point(12, 538);
            this.NrProduseTxt.Name = "NrProduseTxt";
            this.NrProduseTxt.Size = new System.Drawing.Size(83, 25);
            this.NrProduseTxt.TabIndex = 12;
            this.NrProduseTxt.Text = "Numar";
            // 
            // CategorieTxt
            // 
            this.CategorieTxt.AutoSize = true;
            this.CategorieTxt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategorieTxt.ForeColor = System.Drawing.Color.SaddleBrown;
            this.CategorieTxt.Location = new System.Drawing.Point(12, 426);
            this.CategorieTxt.Name = "CategorieTxt";
            this.CategorieTxt.Size = new System.Drawing.Size(118, 25);
            this.CategorieTxt.TabIndex = 11;
            this.CategorieTxt.Text = "Categorie:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SaddleBrown;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.PeachPuff;
            this.button1.Location = new System.Drawing.Point(168, 746);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 64);
            this.button1.TabIndex = 9;
            this.button1.Text = "Afisare";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // adaugareProduseInfisier
            // 
            this.adaugareProduseInfisier.BackColor = System.Drawing.Color.SaddleBrown;
            this.adaugareProduseInfisier.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adaugareProduseInfisier.ForeColor = System.Drawing.Color.PeachPuff;
            this.adaugareProduseInfisier.Location = new System.Drawing.Point(12, 746);
            this.adaugareProduseInfisier.Name = "adaugareProduseInfisier";
            this.adaugareProduseInfisier.Size = new System.Drawing.Size(150, 64);
            this.adaugareProduseInfisier.TabIndex = 2;
            this.adaugareProduseInfisier.Text = "Adauga";
            this.adaugareProduseInfisier.UseVisualStyleBackColor = false;
            this.adaugareProduseInfisier.Click += new System.EventHandler(this.adaugarefisier_Click);
            // 
            // pretPtext
            // 
            this.pretPtext.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pretPtext.Location = new System.Drawing.Point(136, 233);
            this.pretPtext.Name = "pretPtext";
            this.pretPtext.Size = new System.Drawing.Size(133, 22);
            this.pretPtext.TabIndex = 8;
            // 
            // gramajPtext
            // 
            this.gramajPtext.BackColor = System.Drawing.Color.AntiqueWhite;
            this.gramajPtext.Location = new System.Drawing.Point(136, 300);
            this.gramajPtext.Name = "gramajPtext";
            this.gramajPtext.Size = new System.Drawing.Size(133, 22);
            this.gramajPtext.TabIndex = 6;
            // 
            // numePtext
            // 
            this.numePtext.BackColor = System.Drawing.Color.AntiqueWhite;
            this.numePtext.Location = new System.Drawing.Point(136, 162);
            this.numePtext.Name = "numePtext";
            this.numePtext.Size = new System.Drawing.Size(133, 22);
            this.numePtext.TabIndex = 2;
            this.numePtext.TextChanged += new System.EventHandler(this.numetext_TextChanged);
            // 
            // GramajTxt
            // 
            this.GramajTxt.AutoSize = true;
            this.GramajTxt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GramajTxt.ForeColor = System.Drawing.Color.SaddleBrown;
            this.GramajTxt.Location = new System.Drawing.Point(12, 296);
            this.GramajTxt.Name = "GramajTxt";
            this.GramajTxt.Size = new System.Drawing.Size(98, 25);
            this.GramajTxt.TabIndex = 5;
            this.GramajTxt.Text = "Gramaj:";
            // 
            // PretTxt
            // 
            this.PretTxt.AutoSize = true;
            this.PretTxt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PretTxt.ForeColor = System.Drawing.Color.SaddleBrown;
            this.PretTxt.Location = new System.Drawing.Point(12, 229);
            this.PretTxt.Name = "PretTxt";
            this.PretTxt.Size = new System.Drawing.Size(64, 25);
            this.PretTxt.TabIndex = 4;
            this.PretTxt.Text = "Pret:";
            // 
            // NumeTxt
            // 
            this.NumeTxt.AutoSize = true;
            this.NumeTxt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeTxt.ForeColor = System.Drawing.Color.SaddleBrown;
            this.NumeTxt.Location = new System.Drawing.Point(12, 162);
            this.NumeTxt.Name = "NumeTxt";
            this.NumeTxt.Size = new System.Drawing.Size(80, 25);
            this.NumeTxt.TabIndex = 2;
            this.NumeTxt.Text = "Nume:";
            // 
            // CategorieLabel
            // 
            this.CategorieLabel.AutoSize = true;
            this.CategorieLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategorieLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.CategorieLabel.Location = new System.Drawing.Point(484, 91);
            this.CategorieLabel.Name = "CategorieLabel";
            this.CategorieLabel.Size = new System.Drawing.Size(110, 25);
            this.CategorieLabel.TabIndex = 8;
            this.CategorieLabel.Text = "Categorie";
            this.CategorieLabel.Click += new System.EventHandler(this.label7_Click);
            // 
            // Numelabel
            // 
            this.Numelabel.AutoSize = true;
            this.Numelabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numelabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Numelabel.Location = new System.Drawing.Point(346, 91);
            this.Numelabel.Name = "Numelabel";
            this.Numelabel.Size = new System.Drawing.Size(72, 25);
            this.Numelabel.TabIndex = 7;
            this.Numelabel.Text = "Nume";
            this.Numelabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // PretLabel
            // 
            this.PretLabel.AutoSize = true;
            this.PretLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PretLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.PretLabel.Location = new System.Drawing.Point(667, 91);
            this.PretLabel.Name = "PretLabel";
            this.PretLabel.Size = new System.Drawing.Size(56, 25);
            this.PretLabel.TabIndex = 9;
            this.PretLabel.Text = "Pret";
            this.PretLabel.Click += new System.EventHandler(this.label9_Click);
            // 
            // GramajLabel
            // 
            this.GramajLabel.AutoSize = true;
            this.GramajLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GramajLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.GramajLabel.Location = new System.Drawing.Point(803, 91);
            this.GramajLabel.Name = "GramajLabel";
            this.GramajLabel.Size = new System.Drawing.Size(90, 25);
            this.GramajLabel.TabIndex = 16;
            this.GramajLabel.Text = "Gramaj";
            // 
            // NrProdusePrepLabel
            // 
            this.NrProdusePrepLabel.AutoSize = true;
            this.NrProdusePrepLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NrProdusePrepLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.NrProdusePrepLabel.Location = new System.Drawing.Point(977, 91);
            this.NrProdusePrepLabel.Name = "NrProdusePrepLabel";
            this.NrProdusePrepLabel.Size = new System.Drawing.Size(276, 25);
            this.NrProdusePrepLabel.TabIndex = 16;
            this.NrProdusePrepLabel.Text = "Numar produse preparate";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel2.Controls.Add(this.ProduseLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(325, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 70);
            this.panel2.TabIndex = 17;
            // 
            // ProduseLabel
            // 
            this.ProduseLabel.AutoSize = true;
            this.ProduseLabel.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProduseLabel.ForeColor = System.Drawing.Color.PeachPuff;
            this.ProduseLabel.Location = new System.Drawing.Point(365, 9);
            this.ProduseLabel.Name = "ProduseLabel";
            this.ProduseLabel.Size = new System.Drawing.Size(208, 52);
            this.ProduseLabel.TabIndex = 3;
            this.ProduseLabel.Text = "PRODUSE";
            this.ProduseLabel.Click += new System.EventHandler(this.angajatiLabel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1309, 1008);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.NrProdusePrepLabel);
            this.Controls.Add(this.GramajLabel);
            this.Controls.Add(this.CategorieLabel);
            this.Controls.Add(this.Numelabel);
            this.Controls.Add(this.PretLabel);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "ProduseForm";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox numarPtext;
        private System.Windows.Forms.Label DespartireNrProduseTxt;
        private System.Windows.Forms.Label NrProduseTxt;
        private System.Windows.Forms.Label CategorieTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button adaugareProduseInfisier;
        private System.Windows.Forms.TextBox pretPtext;
        private System.Windows.Forms.TextBox gramajPtext;
        private System.Windows.Forms.TextBox numePtext;
        private System.Windows.Forms.Label GramajTxt;
        private System.Windows.Forms.Label PretTxt;
        private System.Windows.Forms.Label NumeTxt;
        private System.Windows.Forms.Label CategorieLabel;
        private System.Windows.Forms.Label Numelabel;
        private System.Windows.Forms.Label PretLabel;
        private System.Windows.Forms.Label GramajLabel;
        private System.Windows.Forms.Label NrProdusePrepLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ProduseLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton PatiserieRadioB;
        private System.Windows.Forms.RadioButton TortRadioB;
        private System.Windows.Forms.RadioButton PrajituraRadioB;
        private System.Windows.Forms.CheckBox GramajCheck;
        private System.Windows.Forms.CheckBox PretCheck;
    }
}