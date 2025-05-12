using System;
using System.Collections.Generic;
using NivelModele;
using NivelStocareDate;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            AdministrareComenzi_Memorie adminMemorie = new AdministrareComenzi_Memorie();
            AdministrareComenzi_Fisier adminFisier = new AdministrareComenzi_Fisier("comenzi.txt");

            string optiune;
            do
            {
                Console.WriteLine("\nMeniu:");
                Console.WriteLine("C - Creare comanda");
                Console.WriteLine("A - Afisare comenzi din memorie");
                Console.WriteLine("F - Afisare comenzi din fisier");
                Console.WriteLine("X - Iesire");
                Console.Write("Alegeti o optiune: ");
                optiune = Console.ReadLine().ToUpper();

                switch (optiune)
                {
                    case "C":
                        Comanda nouaComanda = CitireComandaTastatura();
                        adminMemorie.AddComanda(nouaComanda);
                        adminFisier.AddComanda(nouaComanda);
                        Console.WriteLine("Comanda a fost salvata!");
                        break;

                    case "A":
                        AfisareComenzi(adminMemorie.GetComenzi());
                        break;

                    case "F":
                        List<Comanda> comenziDinFisier = adminFisier.GetComenzi();
                        AfisareComenzi(comenziDinFisier);
                        break;

                    case "X":
                        return;

                    default:
                        Console.WriteLine("Optiune invalida!");
                        break;
                }
            } while (optiune != "X");
        }

        public static Comanda CitireComandaTastatura()
        {
            Console.Write("Introduceti ID-ul comenzii: ");
            int id = int.Parse(Console.ReadLine());
            Comanda comanda = new Comanda(id);

            while (true)
            {
                Console.Write("Introduceti numele produsului (sau 'stop' pentru a termina): ");
                string nume = Console.ReadLine();
                if (nume.ToLower() == "stop") break;

                Console.Write("Introduceti pretul produsului: ");
                double pret = double.Parse(Console.ReadLine());
                Console.WriteLine("Selectati categoria produsului:");
                foreach (var categorie in Enum.GetValues(typeof(CategorieProdus)))
                {
                    Console.WriteLine($"- {categorie}");
                }
                Console.Write("Categorie: ");
                string inputCategorie = Console.ReadLine();

                if (!Enum.TryParse(inputCategorie, true, out CategorieProdus categorieProdus))
                {
                    Console.WriteLine("Categorie invalida, setata automat pe 'Alte'.");
                    categorieProdus = CategorieProdus.alte;
                }

                Produs produs = new Produs(nume, pret, categorieProdus);
                comanda.AdaugaProdus(produs);
            }

            return comanda;
        }

        public static void AfisareComenzi(List<Comanda> comenzi)
        {
            if (comenzi.Count == 0)
            {
                Console.WriteLine("Nu exista comenzi salvate.");
            }
            else
            {
                Console.WriteLine("\nComenzi salvate:");
                foreach (var comanda in comenzi)
                {
                    Console.WriteLine(comanda);
                }
            }
        }
    }
}