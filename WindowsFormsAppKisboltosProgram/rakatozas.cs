using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppKisboltosProgram
{
    internal class rakatozas
    {
        int cikkszam;
        int raktarkod;

        public int Cikkszam { get => cikkszam; set => cikkszam = value; }
        public int Raktarkod { get => raktarkod; set => raktarkod = value; }

        public rakatozas(int cikkszam, int raktarkod)
        {
            Cikkszam = cikkszam;
            Raktarkod = raktarkod;
        }
    }
}
