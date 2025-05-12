using System;
using System.Collections.Generic;
using NvlModele;

namespace Nvlstocaredate
{
    public class AdministrareComenzi_Memorie
    {
        private List<Comanda> comenzi = new List<Comanda>();

        public void AddComanda(Comanda comanda)
        {
            comenzi.Add(comanda);
        }

        public List<Comanda> GetComenzi()
        {
            return comenzi;
        }
    }
}