using LibrarieModele;
using NivelStocareDate;
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
using System.Xml;

namespace UI_WindowsForms
{
    public partial class Form1 : Form
    {
        AdministrareAngajati_FisierText adminAngajati;

        private Label[] lblsNume;
        private Label[] lblsPrenume;
        private Label[] lblsVarsta;
        private Label[] lblsJob;

        private Label lblNume;

        private const int LATIME_CONTROL = 70;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 100;
        private const int OFFSET_X = 260;
        public Form1()
        {
            string fisierAngajati = ConfigurationManager.AppSettings["fisierAngajati"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + fisierAngajati;
            adminAngajati = new AdministrareAngajati_FisierText(caleCompletaFisier);

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void AfiseazaAngajati()
        {
            Angajat[] angajati = adminAngajati.GetAngajati(out int nrAngajati);

            lblsNume = new Label[nrAngajati];
            lblsPrenume = new Label[nrAngajati];
            lblsVarsta = new Label[nrAngajati];
            lblsJob = new Label[nrAngajati];



            int i = 0;

            foreach (Angajat angajat in angajati)
            {

                //numele angajatilor
                lblsNume[i] = new Label();
                lblsNume[i].Size = new Size(LATIME_CONTROL, 30);
                lblsNume[i].Text = angajat.GetNumeAngajat();
                lblsNume[i].Location = new Point(OFFSET_X, (i+1)*DIMENSIUNE_PAS_Y+70);
                this.Controls.Add(lblsNume[i]);

                ////prenumele angajatilor
                lblsPrenume[i] = new Label();
                lblsPrenume[i].Size = new Size(LATIME_CONTROL, 30);
                lblsPrenume[i].Text = angajat.prenume;
                lblsPrenume[i].Location = new Point(OFFSET_X+DIMENSIUNE_PAS_X+10, (i + 1) * DIMENSIUNE_PAS_Y + 70);
                this.Controls.Add(lblsPrenume[i]);

                ////control label varsta

                lblsVarsta[i] = new Label();
                lblsVarsta[i].Size = new Size(LATIME_CONTROL, 30);
                lblsVarsta[i].Text = string.Join(" ", angajat.varsta);
                lblsVarsta[i].Location = new Point(OFFSET_X + 2*DIMENSIUNE_PAS_X+40, (i + 1) * DIMENSIUNE_PAS_Y + 70);
                this.Controls.Add(lblsVarsta[i]);

                ////control label job
                lblsJob[i] = new Label();
                lblsJob[i].Size = new Size(LATIME_CONTROL + 20, 30);
                lblsJob[i].Text = angajat.job;
                lblsJob[i].Location = new Point(OFFSET_X + 4 * DIMENSIUNE_PAS_X - 67, (i + 1) * DIMENSIUNE_PAS_Y + 70);
                this.Controls.Add(lblsJob[i]);
                i++;
            }
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        public bool validare()
        {
            if (numetext.Text == String.Empty)
            {
                MessageBox.Show("Nu ati introdus numele angajatului!", "Eroare");
                return false;
            }
            if (prenumetext.Text == String.Empty)
            {
                MessageBox.Show("Nu ati introdus prenumele angajatului!", "Eroare");
                return false;
            }
            if (varstatext.Text == String.Empty)
            {
                MessageBox.Show("Nu ati introdus varsta angajatului!", "Eroare");
                return false;
            }
            if (JobText.Text == String.Empty)
            {
                MessageBox.Show("Nu ati introdus jobul angajatului!", "Eroare");
                return false;
            }
            return true;
        }
        private void adaugarefisier_Click(object sender, EventArgs e)
        {
            if (validare())
            {
                string nume = numetext.Text;
                string prenume = prenumetext.Text;
                string jobb = JobText.Text;
                adminAngajati.GetAngajati(out int nrAngajati);

                Angajat angajat = new Angajat(0, nume, prenume, 0, jobb);
                angajat.SetVarsta(varstatext.Text);
                angajat.SetIdAngajat(nrAngajati + 1);

                adminAngajati.AddAngajat(angajat);

                //resetarea controalelor pentru a introduce datele unui angajat nou
                ResetareControale();
                MessageBox.Show("Angajat adaugat cu succes", "Felicitari");
            }
           
        }
        private void ResetareControale()
        {
            numetext.Text = prenumetext.Text  =varstatext.Text= null;

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AfiseazaAngajati();
        }

        private void numetext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
