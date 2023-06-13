using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Produs
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const int ID = 0;
        private const int NUME = 1;
        private const int PRET = 2;
        private const int GRAMAJ = 3;
        private const int CATEGORIE = 4;
        private const int NRPRODUSEPREPARATE = 5;

        public int idProdus;
        public string Nume { get; set; }
        public string Categorie { get; set; }
        public float gramaj { get; set; }
        public float Pret { get; set; }
        public int NrProdusePreparate { get; set; }

        //constructor implicit
        public Produs()
        {
            Nume = string.Empty;
        }
        //constructor cu parametrii
        public Produs(int IdProdus, string _nume, float _pret, float _gramaj, string _categorie, int _nrProdusePreparate)
        {
            idProdus = IdProdus;
            Nume = _nume;
            Pret = _pret;
            gramaj = _gramaj;
            Categorie = _categorie;
            NrProdusePreparate = _nrProdusePreparate;
        }

        //constructor cu un singur parametru de tip string care reprezinta o linie dintr-un fisier text
        public Produs(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);
            //ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier prin apelul implicit al metodei ConversieLaSir_PentruFisier()
            /*idProdus = Convert.ToInt32(dateFisier[0]);
            Nume = dateFisier[1];
            Pret = Convert.ToInt32(dateFisier[2]);
            gramaj = Convert.ToInt32(dateFisier[3]);
            Categorie = dateFisier[4];
            NrProdusePreparate = Convert.ToInt32(dateFisier[5]);*/
            idProdus = Convert.ToInt32(dateFisier[0]);
            Nume = dateFisier[1];
            Pret = Convert.ToInt32(dateFisier[2]);
            gramaj = Convert.ToInt32(dateFisier[3]);
            Categorie = dateFisier[4];
            NrProdusePreparate = Convert.ToInt32(dateFisier[5]);
        }
        public string ToLine()
        {
            // Convert the properties of the Produs object to a string representation
            // that can be written to the file
            string line = $"{idProdus}{SEPARATOR_PRINCIPAL_FISIER}{Nume}{SEPARATOR_PRINCIPAL_FISIER}{Pret}{SEPARATOR_PRINCIPAL_FISIER}{gramaj}{SEPARATOR_PRINCIPAL_FISIER}{Categorie}{SEPARATOR_PRINCIPAL_FISIER}{NrProdusePreparate}";

            return line;
        }

        public string Info()
        {
            string info = string.Format("id: {0} nume:{1} pret:{2} Gramaj: {3}  categorie:{4} nrProdusePreparate: {5}",
                idProdus.ToString(),
                (Nume ?? " NECUNOSCUT "),
                Pret.ToString(),
                gramaj.ToString(),
                (Categorie ?? " NECUNOSCUT "),
                NrProdusePreparate.ToString());
            return info;
        }

        public string ConversieLaSir_PentruFisier()
        {
            string obiectProdusPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}",
                SEPARATOR_PRINCIPAL_FISIER,
                idProdus.ToString(),
                (Nume ?? " NECUNOSCUT "),
                Pret.ToString(),
                gramaj.ToString(),
                (Categorie ?? " NECUNOSCUT "),
                NrProdusePreparate.ToString());

            return obiectProdusPentruFisier;
        }
        public void SetIdProdus(int idProdus)
        {
            this.idProdus = idProdus;
        }
        public int GetIdProdus()
        {
            return idProdus;
        }

        public string GetNumeProdus()
        {
            return Nume;
        }

        public string GetCategorieProdus()
        {
            return Categorie;
        }

        public float GetPretProdus()
        {
            return Pret;
        }
        public float GetGramajProdus() 
        { 
            return gramaj;
        }
        public void SetGramaj(string gr)
        {
            this.gramaj = Convert.ToInt16(gr);
        }
        public void SetPret(string price)
        {
            this.Pret = Convert.ToInt32(price);
        }
        public void SetNrProdPrep(string numarP)
        {
            this.NrProdusePreparate = Convert.ToInt32(numarP);
        }
        public int GetNumarProdusePreparate()
        {
            return NrProdusePreparate;
        }
    }
}
