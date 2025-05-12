namespace NivelModele
{
    public class Produs
    {
        public string Nume { get;  }
        public double Pret { get; }
        public CategorieProdus Categorie { get; }

        public Produs() { }

        public Produs(string nume, double pret, CategorieProdus categorie)
        {
            Nume = nume;
            Pret = pret;
            Categorie = categorie;
        }

        public override string ToString()
        {
            return $"{Nume} - {Pret} RON ({Categorie})";
        }
    }
}