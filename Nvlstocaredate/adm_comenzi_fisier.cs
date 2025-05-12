using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NvlModele;

namespace NivelStocareDate
{
    public class AdministrareComenzi_Fisier
    {
        private string numeFisier;

        public AdministrareComenzi_Fisier(string numeFisier)
        {
            this.numeFisier = numeFisier;
            if (!File.Exists(numeFisier))
            {
                File.Create(numeFisier).Close();
            }
        }

        public void AddComanda(Comanda comanda)
        {
            using (StreamWriter sw = new StreamWriter(numeFisier, true))
            {
                foreach (Produs produs in comanda.Produse)
                {
                    sw.WriteLine($"{comanda.Id};{comanda.Masa};{produs.Nume};{produs.Pret};{produs.Categorie};{comanda.DataOra:o}");
                }
            }
        }

        public List<Comanda> GetComenzi()
        {
            List<Comanda> comenzi = new List<Comanda>();
            Dictionary<int, Comanda> comenziTemp = new Dictionary<int, Comanda>();

            using (StreamReader sr = new StreamReader(numeFisier))
            {
                string linie;
                while ((linie = sr.ReadLine()) != null)
                {
                    string[] valori = linie.Split(';');

                    if (valori.Length >= 5)
                    {
                        int id = int.Parse(valori[0]);
                        int masa = int.Parse(valori[1]);
                        string nume = valori[2];
                        double pret = double.Parse(valori[3]);
                        DateTime dataOra = valori.Length > 5 ? DateTime.Parse(valori[5]) : DateTime.Now;

                        if (!Enum.TryParse(valori[4], out CategorieProdus categorieProdus))
                        {
                            categorieProdus = CategorieProdus.alte;
                        }

                        Produs produs = new Produs(nume, pret, categorieProdus);

                        if (!comenziTemp.ContainsKey(id))
                        {
                            comenziTemp[id] = new Comanda(id, masa) { DataOra = dataOra };
                        }

                        comenziTemp[id].AdaugaProdus(produs);
                    }
                }
            }

            comenzi.AddRange(comenziTemp.Values);
            return comenzi.OrderByDescending(c => c.DataOra).ToList();
        }

        public Comanda GetComandaById(int id)
        {
            return GetComenzi().FirstOrDefault(c => c.Id == id);
        }

        public List<Comanda> GetComenziByMasa(int masa)
        {
            return GetComenzi().Where(c => c.Masa == masa).ToList();
        }

        public bool StergeComanda(int id)
        {
            var comenzi = GetComenzi();
            var comandaDeSters = comenzi.FirstOrDefault(c => c.Id == id);

            if (comandaDeSters != null)
            {
                comenzi.Remove(comandaDeSters);
                SalveazaToateComenzile(comenzi);
                return true;
            }
            return false;
        }

        private void SalveazaToateComenzile(List<Comanda> comenzi)
        {
            using (StreamWriter sw = new StreamWriter(numeFisier, false))
            {
                foreach (var comanda in comenzi)
                {
                    foreach (var produs in comanda.Produse)
                    {
                        sw.WriteLine($"{comanda.Id};{comanda.Masa};{produs.Nume};{produs.Pret};{produs.Categorie};{comanda.DataOra:o}");
                    }
                }
            }
        }

        public int GetNextComandaId()
        {
            var comenzi = GetComenzi();
            return comenzi.Count == 0 ? 1 : comenzi.Max(c => c.Id) + 1;
        }
    }
}