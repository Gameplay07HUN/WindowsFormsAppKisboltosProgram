using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppKisboltosProgram
{
    internal class rendeles
    {
        int cikkszam;
        string vevokod;
        DateTime datum;
        int mennyiseg;
        int beszerzesiar;

        public int Cikkszam { get => cikkszam; set => cikkszam = value; }
        public string Vevokod { get => vevokod; set => vevokod = value; }
        public DateTime Datum { get => datum; set => datum = value; }
        public int Mennyiseg { get => mennyiseg; set => mennyiseg = value; }
        public int Beszerzesiar { get => beszerzesiar; set => beszerzesiar = value; }

        public rendeles(int cikkszam, string vevokod, DateTime datun, int mennyiseg, int beszerzesiar)
        {
            Cikkszam = cikkszam;
            Vevokod = vevokod;
            Datum = datun;
            Mennyiseg = mennyiseg;
            Beszerzesiar = beszerzesiar;
        }
    }
}
