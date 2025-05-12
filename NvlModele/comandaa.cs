using System;
using System.Collections.Generic;
using System.Linq;

namespace NvlModele
{
    public class Comanda
    {
        public int Id { get; set; }
        public int Masa { get; set; }
        public List<Produs> Produse { get; set; } = new List<Produs>();
        public double Total => Produse.Sum(p => p.Pret);
        public DateTime DataOra { get; set; } = DateTime.Now;

        public Comanda() { }

        public Comanda(int id, int masa)
        {
            Id = id;
            Masa = masa;
        }

        public void AdaugaProdus(Produs produs)
        {
            Produse.Add(produs);
        }

        public void StergeProdus(Produs produs)
        {
            Produse.Remove(produs);
        }

        public override string ToString()
        {
            string produseInfo = string.Join("\n", Produse.Select(p => $"  - {p}"));
            return $"[Comanda #{Id}] Masa: {Masa}\n{produseInfo}\nTotal: {Total} RON\nData: {DataOra:g}";
        }
    }
}