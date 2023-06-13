using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Angajat
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';

        public int idAngajat { get; set; }
        public string nume { get; set; }
        public string prenume { get; set; }
        public int varsta { get; set; }
        public string job { get; set; }


        public Angajat()
        {
            nume = prenume = job = string.Empty;
            idAngajat = varsta = 0;
        }

        public Angajat(int idAngajat, string nume, string prenume, int varsta, string job)
        {
            this.idAngajat = idAngajat;
            this.nume = nume;
            this.prenume = prenume;
            this.varsta = varsta;
            this.job = job;
        }

        public Angajat(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            idAngajat = Convert.ToInt32(dateFisier[0]);
            nume = dateFisier[1];
            prenume = dateFisier[2];
            varsta = Convert.ToInt32(dateFisier[3]);
            job = dateFisier[4];
        }
        public string ToLine()
        {
            // Convert the properties of the Angajat object to a string representation
            // that can be written to the file
            string line = $"{idAngajat}{SEPARATOR_PRINCIPAL_FISIER}{nume}{SEPARATOR_PRINCIPAL_FISIER}{prenume}{SEPARATOR_PRINCIPAL_FISIER}{varsta}{SEPARATOR_PRINCIPAL_FISIER}{job}{SEPARATOR_PRINCIPAL_FISIER}";

            return line;
        }

        public string ConversieLaSir_PentruFisier()
        {
            string obiectProdusPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
                idAngajat.ToString(),
                (nume ?? " NECUNOSCUT "),
                prenume,
                varsta.ToString(),
                job);


            return obiectProdusPentruFisier;
        }
        public string Info()
        {
            string info = string.Format("{1} {2} cu id-ul #{0} are varsta de {3} ani si jobul de {4}.",
                   idAngajat.ToString(),
                   (nume ?? " NECUNOSCUT "),
                   (prenume ?? " NECUNOSCUT "),
                   varsta.ToString(),
                   (job ?? " NECUNOSCUT "));
            return info;
        }

        public void SetIdAngajat(int idAngajat)
        {
            this.idAngajat = idAngajat;
        }
        public void SetVarsta(string varsta)
        {
            this.varsta = Convert.ToInt32(varsta);
        }
        public int GetIdAngajat()
        {
            return idAngajat;
        }

        public string GetNumeAngajat()
        {
            return nume;
        }

        public string GetPrenumeAngajat()
        {
            return prenume;
        }

        public int GetVarsta()
        {
            return varsta;
        }


    }
}
