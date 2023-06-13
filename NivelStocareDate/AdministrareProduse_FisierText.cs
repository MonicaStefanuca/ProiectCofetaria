using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LibrarieModele;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace NivelStocareDate
{
    public class AdministrareProduse_FisierText
    {
        private const int NR_MAX_PRODUSE = 50;
        private string numeFisierP;

        public AdministrareProduse_FisierText(string numeFisier)
        {
            this.numeFisierP = numeFisier;
            // se incearca deschiderea fisierului in modul OpenOrCreate
            // astfel incat sa fie creat daca nu exista
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AddProdus(Produs produs)
        {
            // Get the current products from the file
            Produs[] existingProduse = GetProduse(out int nrProduse);

            // Generate a new ID by incrementing the last product's ID or starting from 1 if no products exist
            int newId = (nrProduse > 0) ? existingProduse[nrProduse - 1].idProdus + 1 : 1;
            produs.SetIdProdus(newId);
            // instructiunea 'using' va apela la final streamWriterFisierText.Close();
            // al doilea parametru setat la 'true' al constructorului StreamWriter indica
            // modul 'append' de deschidere al fisierului
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisierP, true))
            {
                streamWriterFisierText.WriteLine(produs.ConversieLaSir_PentruFisier());
            }
        }

        public Produs[] GetProduse(out int nrProduse)
        {
            Produs[] lista_produse = new Produs[NR_MAX_PRODUSE];

            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisierP))
            {
                string linieFisier;
                nrProduse = 0;

                // citeste cate o linie si creaza un obiect de tip Produs
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    lista_produse[nrProduse++] = new Produs(linieFisier);
                }
            }
            Array.Resize(ref lista_produse, nrProduse);
            return lista_produse;
        }
        public Produs CautaProdus(string nume)
        {
            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisierP))
            {
                string linieFisier;

                // citeste cate o linie si verifica daca numele cautat se potriveste
                // cu cel al produsului din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Produs produs = new Produs(linieFisier);
                    if (produs.Nume == nume)
                    {
                        return produs;
                    }
                }
            }

            return null; // daca nu a fost gasit produsul cu numele cautat
        }
        public Produs ModificaPretProdus(string nume)
        {
            // Create a temporary file to store the modified content
            string tempFile = Path.GetTempFileName();

            // Initialize produs outside the while loop
            Produs Mprodus = null;

            // Open the temporary file for writing
            using (StreamWriter writer = new StreamWriter(tempFile))
            {
                using (StreamReader reader = new StreamReader(numeFisierP))
                {
                    string linieFisier;

                    // Read each line from the original file
                    while ((linieFisier = reader.ReadLine()) != null)
                    {
                        Mprodus = new Produs(linieFisier);

                        // Check if the product name matches
                        if (Mprodus.Nume == nume)
                        {
                            Console.WriteLine("Dati noul pret al produsului ales: ");
                            string pr = Console.ReadLine();
                            Mprodus.SetPret(pr);
                            // Return the modified product
                            return Mprodus;
                        }

                        // Write the line to the temporary file
                        writer.WriteLine(Mprodus.ToLine());
                    }
                }
            }

            // Replace the original file with the temporary file
            File.Delete(numeFisierP);
            File.Move(tempFile, numeFisierP);

            return null;
        }
        public bool RemoveProdus(string nume)
        {
            // Create a temporary file to store the updated content
            string tempFile = Path.GetTempFileName();

            // Initialize a flag to track if the product was found and removed
            bool removed = false;

            // Open the temporary file for writing
            using (StreamWriter writer = new StreamWriter(tempFile))
            {
                using (StreamReader reader = new StreamReader(numeFisierP))
                {
                    string linieFisier;

                    // Read each line from the original file
                    while ((linieFisier = reader.ReadLine()) != null)
                    {
                        Produs produs = new Produs(linieFisier);

                        // Check if the product name matches
                        if (produs.Nume == nume)
                        {
                            // Skip writing the line to remove the product
                            removed = true;
                            continue;
                        }

                        // Write the line to the temporary file
                        writer.WriteLine(produs.ConversieLaSir_PentruFisier());
                    }
                }
            }

            if (removed)
            {
                // Replace the original file with the temporary file
                File.Delete(numeFisierP);
                File.Move(tempFile, numeFisierP);
            }
            else
            {
                // If the product was not found, delete the temporary file
                File.Delete(tempFile);
            }

            return removed;
        }
    }
}
