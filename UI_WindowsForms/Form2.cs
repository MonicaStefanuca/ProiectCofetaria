using NivelStocareDate;
using LibrarieModele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_WindowsForms
{
    public partial class Form2 : Form
    {

        AdministrareProduse_FisierText adminProduse;
        string _categorie;

        private Label[] lblsNume;
        private Label[] lblsCategorie;
        private Label[] lblsPret;
        private Label[] lblsGramaj;
        private Label[] lblsNumarProdusePreparate;

        private Label lblNume;

        private const int LATIME_CONTROL = 100;
        private const int DIMENSIUNE_PAS_Y = 34;
        private const int DIMENSIUNE_PAS_X = 100;
        private const int OFFSET_X = 260;
        public Form2()
        {
            
            string fisierProduse = ConfigurationManager.AppSettings["fisierProduse"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + fisierProduse;
            adminProduse = new AdministrareProduse_FisierText(caleCompletaFisier);

            InitializeComponent();
        }
        private void AfiseazaProduse()
        {
            Produs[] produse = adminProduse.GetProduse(out int nrProduse);

            lblsNume = new Label[nrProduse];
            lblsCategorie = new Label[nrProduse];
            lblsPret = new Label[nrProduse];
            lblsGramaj = new Label[nrProduse];
            lblsNumarProdusePreparate = new Label[nrProduse];


            int i = 0;

            foreach (Produs produs in produse)
            {

                //numele produselor
                lblsNume[i] = new Label();
                lblsNume[i].Size = new Size(LATIME_CONTROL, 30);
                lblsNume[i].Text = produs.GetNumeProdus();
                lblsNume[i].Location = new Point(OFFSET_X+2, (i + 1) * DIMENSIUNE_PAS_Y + 70);
                this.Controls.Add(lblsNume[i]);

                ////categoria produselor
                lblsCategorie[i] = new Label();
                lblsCategorie[i].Size = new Size(LATIME_CONTROL, 30);
                lblsCategorie[i].Text = produs.Categorie;
                lblsCategorie[i].Location = new Point(OFFSET_X +DIMENSIUNE_PAS_X + 25, (i + 1) * DIMENSIUNE_PAS_Y + 70);
                this.Controls.Add(lblsCategorie[i]);

                ////control label pret

                lblsPret[i] = new Label();
                lblsPret[i].Size = new Size(LATIME_CONTROL, 30);
                lblsPret[i].Text = string.Join(" ", produs.Pret);
                lblsPret[i].Location = new Point(OFFSET_X + 3 * DIMENSIUNE_PAS_X -50  , (i + 1) * DIMENSIUNE_PAS_Y + 70);
                this.Controls.Add(lblsPret[i]);

                ////control label gramaj
                
                lblsGramaj[i] = new Label();
                lblsGramaj[i].Size = new Size(LATIME_CONTROL, 30);
                lblsGramaj[i].Text = string.Join(" ", produs.gramaj);
                lblsGramaj[i].Location = new Point(OFFSET_X + 4 * DIMENSIUNE_PAS_X - 30, (i + 1) * DIMENSIUNE_PAS_Y + 70);
                this.Controls.Add(lblsGramaj[i]);

                ////control label nr produse preparate

                lblsNumarProdusePreparate[i] = new Label();
                lblsNumarProdusePreparate[i].Size = new Size(LATIME_CONTROL, 30);
                lblsNumarProdusePreparate[i].Text = string.Join(" ", produs.NrProdusePreparate);
                lblsNumarProdusePreparate[i].Location = new Point(OFFSET_X + 6 * DIMENSIUNE_PAS_X - 30, (i + 1) * DIMENSIUNE_PAS_Y + 70);
                this.Controls.Add(lblsNumarProdusePreparate[i]);
                i++;
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void angajatiLabel_Click(object sender, EventArgs e)
        {

        }

        public bool validare()
        {
            if(numePtext.Text==String.Empty)
            {
                MessageBox.Show("Nu ati introdus numele produsului!", "Eroare");
                return false;
            }
            if (pretPtext.Text == String.Empty)
            {
                MessageBox.Show("Nu ati introdus pretul produsului!", "Eroare");
                return false;
            }
            if (gramajPtext.Text == String.Empty)
            {
                MessageBox.Show("Nu ati introdus gramajul produsului!", "Eroare");
                return false;
            }
            if (numarPtext.Text == String.Empty)
            {
                MessageBox.Show("Nu ati introdus numarul de produse preparate!", "Eroare");
                return false;
            }
            if(!PrajituraRadioB.Checked && !TortRadioB.Checked && !PatiserieRadioB.Checked)
            {
                MessageBox.Show("Nu ati ales nicio categorie!", "Eroare");
            }
            if(!PretCheck.Checked)
            {
                MessageBox.Show("Nu ati introdus pretul in lei? Verificati si bifati casuta corespunzatoare!", "Eroare");
                return false;
            }
            if (!GramajCheck.Checked)
            {
                MessageBox.Show("Nu ati introdus gramajul in grame? Verificati si bifati casuta corespunzatoare!", "Eroare");
                return false;
            }
            return true;
        }
        private void adaugarefisier_Click(object sender, EventArgs e)
        {
            if(validare())
            {
                string nume = numePtext.Text;
                adminProduse.GetProduse(out int nrProduse);

                if (PrajituraRadioB.Checked)
                {
                    _categorie = "Prajitura";
                }
                if (TortRadioB.Checked)
                {
                    _categorie = "Tort";
                }
                if (PatiserieRadioB.Checked)
                {
                    _categorie = "Produse de patiserie";
                }
                Produs produs = new Produs(0, nume, 0, 0, _categorie, 0);
                produs.SetGramaj(gramajPtext.Text);
                produs.SetPret(pretPtext.Text);
                produs.SetNrProdPrep(numarPtext.Text);
                produs.SetIdProdus(nrProduse + 1);

                adminProduse.AddProdus(produs);

                //resetarea controalelor pentru a introduce datele unui angajat nou
               
                ResetareControale();
                MessageBox.Show("Produs adaugat cu succes", "Felicitari");
            }
            /*string nume = numePtext.Text;
            adminProduse.GetProduse(out int nrProduse);

            if(PrajituraRadioB.Checked)
            {
                _categorie = "Prajitura";
            }
            if (TortRadioB.Checked)
            {
                _categorie = "Tort";
            }
            if (PatiserieRadioB.Checked)
            {
                _categorie = "Produse de patiserie";
            }
            Produs produs = new Produs(0, nume, 0,0,_categorie, 0);
            produs.SetGramaj(gramajPtext.Text);
            produs.SetPret(pretPtext.Text);
            produs.SetNrProdPrep(numarPtext.Text);
            produs.SetIdProdus(nrProduse + 1);

            adminProduse.AddProdus(produs);

            //resetarea controalelor pentru a introduce datele unui angajat nou
            ResetareControale();*/
        }
        private void ResetareControale()
        {
            numePtext.Text = pretPtext.Text = gramajPtext.Text =numarPtext.Text= null;
            PrajituraRadioB.Checked=TortRadioB.Checked=PatiserieRadioB.Checked = PretCheck.Checked=GramajCheck.Checked= false;

        }

        private void numetext_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AfiseazaProduse();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
