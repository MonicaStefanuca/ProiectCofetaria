using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LibrarieModele;

namespace NivelStocareDate
{
    public class AdministrareAngajati_FisierText
    {
        private const int NR_MAX_Angajati = 50;

        private string numeFisier;

        public AdministrareAngajati_FisierText(string numeFisier)
        {
            this.numeFisier = numeFisier;

            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public Angajat[] GetAngajati(out int nrAngajati)
        {
            Angajat[] lista_angajati = new Angajat[NR_MAX_Angajati];

            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrAngajati = 0;

                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    lista_angajati[nrAngajati++] = new Angajat(linieFisier);
                }
            }
            Array.Resize(ref lista_angajati, nrAngajati);
            return lista_angajati;
        }

        public void AddAngajat(Angajat angajatNou)
        {
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(angajatNou.ConversieLaSir_PentruFisier());
            }
        }
        public Angajat ModificaVarstaAngajat(string _nume, string _prenume)
        {
            // Create a temporary file to store the modified content
            string tempFile = Path.GetTempFileName();

            // Initialize produs outside the while loop
            Angajat angajat = null;

            // Open the temporary file for writing
            using (StreamWriter writer = new StreamWriter(tempFile))
            {
                using (StreamReader reader = new StreamReader(numeFisier))
                {
                    string linieFisier;

                    // Read each line from the original file
                    while ((linieFisier = reader.ReadLine()) != null)
                    {
                        angajat = new Angajat(linieFisier);

                        // Check if the product name matches
                        if (angajat.nume == _nume && angajat.prenume==_prenume)
                        {
                            Console.WriteLine("Dati noua varsta a angajatului ales: ");
                            string vr = Console.ReadLine();
                            angajat.SetVarsta(vr);
                            return angajat;
                        }

                        // Write the line to the temporary file
                        writer.WriteLine(angajat.ToLine());
                    }
                }
            }

            // Replace the original file with the temporary file
            File.Delete(numeFisier);
            File.Move(tempFile, numeFisier);

            // Return the modified product
            return null;
        }
        public Angajat CautaAngajat(string _nume, string _prenume)
        {
            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;

                // citeste cate o linie si verifica daca numele cautat se potriveste
                // cu cel al produsului din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Angajat angajat = new Angajat(linieFisier);
                    if (angajat.nume == _nume && angajat.prenume==_prenume)
                    {
                        return angajat;
                    }
                }
            }

            return null; // daca nu a fost gasit produsul cu numele cautat
        }
        public bool RemoveAngajat(string _nume, string _prenume)
        {
            // Create a temporary file to store the updated content
            string tempFile = Path.GetTempFileName();
            bool removed = false;
            using (StreamWriter writer = new StreamWriter(tempFile))
            {
                using (StreamReader reader = new StreamReader(numeFisier))
                {
                    string linieFisier;
                    while ((linieFisier = reader.ReadLine()) != null)
                    {
                        Angajat angajat = new Angajat(linieFisier);
                        if (angajat.nume == _nume && angajat.prenume==_prenume)
                        {
                            removed = true;
                            continue;
                        }

                        // Write the line to the temporary file
                        writer.WriteLine(angajat.ConversieLaSir_PentruFisier());
                    }
                }
            }

            if (removed)
            {
                // Replace the original file with the temporary file
                File.Delete(numeFisier);
                File.Move(tempFile, numeFisier);
            }
            else
            {
                File.Delete(tempFile);
            }

            return removed;
        }
    }
}
