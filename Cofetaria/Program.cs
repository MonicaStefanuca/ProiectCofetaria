using System;
using System.IO;
using System.Configuration;
using NivelStocareDate;
using LibrarieModele;

namespace Cofetarie
{
    internal class Program
    {
        public static Produs[] produse { get; private set; }
        public static Angajat[] angajati { get; private set; }
        public enum JoburiAngajati
        {
            Director = 1,
            Manager = 2,
            Casier = 3,
            Ingrijitor = 4
        };
        public const JoburiAngajati DIRECTOR = JoburiAngajati.Director;
        public const JoburiAngajati MANAGER = JoburiAngajati.Manager;
        public const JoburiAngajati CASIER = JoburiAngajati.Casier;
        public const JoburiAngajati INGRIJITOR = JoburiAngajati.Ingrijitor;
        static void Main()
        {
            Produs produs = new Produs();
            Produs[] produse;

            string fisierProdus = ConfigurationManager.AppSettings.Get("fisierProduse");
            AdministrareProduse_FisierText adminProduse = new AdministrareProduse_FisierText(fisierProdus);
            int nrProduse = 0;

            string fisierAngajati = ConfigurationManager.AppSettings["fisierAngajati"];
            AdministrareAngajati_FisierText adminAngajat = new AdministrareAngajati_FisierText(fisierAngajati);
            Angajat angajatNou = new Angajat();
            int nrAngajati=0;

            string optiune;
            do
            {
                Console.WriteLine("A. Introducere informatii produs si salvare in fisier");
                Console.WriteLine("B. Afisare produse din fisier");
                Console.WriteLine("C. Cautare produs in fisier");
                Console.WriteLine("D. Modifica pret produs in fisier");
                Console.WriteLine("E. Sterge produs din fisier");
                Console.WriteLine(" ");
                Console.WriteLine("F. Introducere informatii angajat si salvare in fisier");
                Console.WriteLine("G. Afisare angajati din fisier");
                Console.WriteLine("H. Cautare angajat in fisier");
                Console.WriteLine("I. Modifica varsta angajat in fisier");
                Console.WriteLine("J. Sterge angajat din fisier");
                Console.WriteLine(" ");
                Console.WriteLine("X. Inchidere program");
                Console.WriteLine(" ");
                Console.WriteLine("Alegeti o optiune");
                optiune = Console.ReadLine();
                Console.Clear();
                switch (optiune.ToUpper())
                {
                    case "A":
                        int idProdus = nrProduse + 1;

                        Console.WriteLine("Introdu numele produsului {0} : ", idProdus);
                        string Nume = Console.ReadLine();
                        Console.WriteLine("Introdu pretul produsului {0} in lei : ", idProdus);
                        float Pret = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Introdu gramajul produsului {0} in grame: ", idProdus);
                        int gramaj = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Introdu categoria produsului {0} : ", idProdus);
                        string Categorie = Console.ReadLine();
                        Console.WriteLine("Introdu nr de produse de acest fel preparate {0} : ", idProdus);
                        int NrProdusePreparate = Convert.ToInt16(Console.ReadLine());
                        produs = new Produs(idProdus, Nume, Pret, gramaj, Categorie, NrProdusePreparate);
                        nrProduse++;
                        adminProduse.AddProdus(produs);
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue..");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "B":
                        produse = adminProduse.GetProduse(out nrProduse);
                        AfisareProduse(produse, nrProduse);
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue..");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "C":
                        Console.WriteLine("Introduceti numele produsului:");
                        string numeProdus = Console.ReadLine();
                        Produs produsCautat = adminProduse.CautaProdus(numeProdus);
                        if (produsCautat != null)
                        {
                            Console.WriteLine("Produsul cautat este: " + produsCautat.ConversieLaSir_PentruFisier());
                        }
                        else
                        {
                            Console.WriteLine("Produsul cu numele " + numeProdus + " nu a fost gasit.");
                        }
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue..");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "F":
                        angajatNou = CitireAngajatTastatura();
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue..");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "G":
                        angajati = adminAngajat.GetAngajati(out nrAngajati);
                        AfisareAngajati(angajati, nrAngajati);
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue..");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "H":
                        Console.WriteLine("Introduceti numele angajatului:");
                        string numeAngajat = Console.ReadLine();
                        Console.WriteLine("Introduceti prenumele angajatului:");
                        string prenumeAngajat = Console.ReadLine();
                        Angajat angajatCautat = adminAngajat.CautaAngajat(numeAngajat,prenumeAngajat);
                        if (angajatCautat != null)
                        {
                            Console.WriteLine("Angajatul cautat este: " + angajatCautat.ConversieLaSir_PentruFisier());
                        }
                        else
                        {
                            Console.WriteLine("Angajatul cu numele " + numeAngajat +" "+ prenumeAngajat+ " nu a fost gasit.");
                        }
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue..");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "D":
                        Console.WriteLine("Introduceti numele produsului:");
                        string numePr = Console.ReadLine();
                        Produs produsDeMod = adminProduse.ModificaPretProdus(numePr);
                        if (produsDeMod != null)
                        {
                            Console.WriteLine("Produsul modificat este: " + produsDeMod.ConversieLaSir_PentruFisier());
                        }
                        else
                        {
                            Console.WriteLine("Produsul cu numele " + numePr + " nu a fost gasit.\nIntroduceti numele unui produs existent!");
                        }
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue..");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "I":
                        Console.WriteLine("Introduceti numele angajatului:");
                        string numeAn = Console.ReadLine();
                        Console.WriteLine("Introduceti prenumele angajatului:");
                        string prenumeAn = Console.ReadLine();
                        Angajat angajatDeMod = adminAngajat.ModificaVarstaAngajat(numeAn,prenumeAn);
                        if (angajatDeMod != null)
                        {
                            Console.WriteLine("Angajatul modificat este: " + angajatDeMod.ConversieLaSir_PentruFisier());
                        }
                        else
                        {
                            Console.WriteLine("Angajatul cu numele " + numeAn + ", prenumele: "+prenumeAn+" nu a fost gasit.");
                        }
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue..");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "E":
                        Console.WriteLine("Introduceti numele produsului pe care doriti sa-l stergeti: : ");
                        string numeProd = Console.ReadLine();

                        bool removed = adminProduse.RemoveProdus(numeProd);
                        if (removed)
                        {
                            Console.WriteLine("Produs sters cu succes.");
                        }
                        else
                        {
                            Console.WriteLine("Produsul nu a fost gasit si nici sters.");
                        }
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue..");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "J":
                        Console.WriteLine("Introduceti numele angajatului pe care doriti sa-l stergeti: : ");
                        string numeAng = Console.ReadLine();

                        Console.WriteLine("Introduceti prenumele angajatului pe care doriti sa-lock stergeti: : ");
                        string prenumeAng = Console.ReadLine();

                        bool removedA = adminAngajat.RemoveAngajat(numeAng,prenumeAng);
                        if (removedA)
                        {
                            Console.WriteLine("Angajat sters cu succes.");
                        }
                        else
                        {
                            Console.WriteLine("Angajatul nu a fost gasit si nici sters.");
                        }
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue..");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "X":

                        return;
                    default:
                        Console.WriteLine("Alegeti o optiune valida!\n");
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue..");
                        break;
                }
            } while (optiune.ToUpper() != "X");
        }
        public static void AfisareAngajat(Angajat angajat)
        {
            string infoAngajat = string.Format("{1} {2} cu id-ul #{0} are varsta de {3} ani si jobul de {4}.",
                   angajat.idAngajat,
                   angajat.nume,
                   angajat.prenume,
                   angajat.varsta,
                   angajat.job);

            Console.WriteLine(infoAngajat);
        }
        public static void AfisareAngajati(Angajat[] lista_angajati, int nrAngajati)
        {
            Console.WriteLine("Angajatii sunt:");
            for (int contor = 0; contor < nrAngajati; contor++)
            {
                AfisareAngajat(lista_angajati[contor]);
            }
        }
        public static void AfisareProdus(Produs produs)
        {
            string infoProduse = string.Format("Produsul cu id-ul #{0} are numele: {1} , pretul: {2}, gramajul: {3}, categoria: {4}, numarul de produse preparate: {5}",
               produs.idProdus,
               produs.Nume ?? " NECUNOSCUT ",
               produs.Pret,
               produs.gramaj,
               produs.Categorie ?? " NECUNOSCUT ",
               produs.NrProdusePreparate);
            Console.WriteLine(infoProduse);

        }
        public static void AfisareProduse(Produs[] produse, int nrProduse)
        {
            Console.WriteLine("Produsele sunt:");
            for (int contor = 0; contor < nrProduse; contor++)
            {
                AfisareProdus(produse[contor]);
            }
        }
        public static Produs CitireProdusTastatura()
        {
            Console.WriteLine("Introdu numele produsului {0} : ");
            string Nume = Console.ReadLine();

            Console.WriteLine("Introdu pretul produsului {0} : ");
            float Pret = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Introdu gramajul produsului {0} : ");
            int gramaj = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Introdu categoria produsului {0} : ");
            string Categorie = Console.ReadLine();

            Console.WriteLine("Introdu nr de produse de acest fel preparate {0} : ");
            int NrProdusePreparate = Convert.ToInt16(Console.ReadLine());

            Produs produs = new Produs(0, Nume, Pret, gramaj, Categorie, NrProdusePreparate);

            return produs;
        }
        public static Angajat CitireAngajatTastatura()
        {
            Console.Write("Introduceti numele: ");
            string nume = Console.ReadLine();
            Console.Write("Introduceti prenumele: ");
            string prenume = Console.ReadLine();
            Console.Write("Introduceti varsta: ");
            int varsta = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduceti cifra dupa jobul angajatului:");
            Console.WriteLine("Director-1");
            Console.WriteLine("Manager-2");
            Console.WriteLine("Casier-3");
            Console.WriteLine("Ingrijitor-4");
            Console.WriteLine();
            Console.WriteLine("Jobul ales este: ");
            try
            {
                int _job = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            { Console.WriteLine("Ati facut o greseala!\nAti introdus un string in locul unui int!\nIntroduceti orice cifra pentru a anula adaugarea acestui angajat."); }
            int job = Convert.ToInt32(Console.ReadLine());
            if (job == (int)DIRECTOR)
            {
                Angajat angajat = new Angajat(0, nume, prenume, varsta, DIRECTOR.ToString());
                return angajat;
            };
            if (job == (int)MANAGER)
            {
                Angajat angajat = new Angajat(0, nume, prenume, varsta, MANAGER.ToString());
                return angajat;
            };
            if (job == (int)CASIER)
            {
                Angajat angajat = new Angajat(0, nume, prenume, varsta, CASIER.ToString());
                return angajat;
            };
            if (job == (int)INGRIJITOR)
            {
                Angajat angajat = new Angajat(0, nume, prenume, varsta, INGRIJITOR.ToString());
                return angajat;
            };
            Angajat angajatFaraJob = new Angajat();
            return angajatFaraJob;
        }
    }
}
