using System;
using System.Collections.Generic;
using System.Linq;

namespace NivelModele
{
    public class Comanda
    {
        public int Id { get; set; }
        public List<Produs> Produse { get; set; } = new List<Produs>();
        public double Total => Produse.Sum(p => p.Pret);

        public Comanda() { }

        public Comanda(int id)
        {
            Id = id;
        }

        public void AdaugaProdus(Produs produs)
        {
            Produse.Add(produs);
        }

        public override string ToString()
        {
            string produseInfo = string.Join(", ", Produse);
            return $"Comanda #{Id}: {produseInfo} | Total: {Total} RON";
        }
    }
}