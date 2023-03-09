using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppKisboltosProgram
{
    internal class Termek
    {
        int cikkszam;
        string kategoria;
        string aruaruneve;
        int eladasiar;
        string marka;

        public int Cikkszam { get => cikkszam; set => cikkszam = value; }
        public string Kategoria { get => kategoria; set => kategoria = value; }
        public string Aruaruneve { get => aruaruneve; set => aruaruneve = value; }
        public int Eladasiar { get => eladasiar; set => eladasiar = value; }
        public string Marka { get => marka; set => marka = value; }

        public Termek(int cikkszam, string kategoria, string aruaruneve, int eladasiar, string marka)
        {
            Cikkszam = cikkszam;
            Kategoria = kategoria;
            Aruaruneve = aruaruneve;
            Eladasiar = eladasiar;
            Marka = marka;
        }
    }
}
