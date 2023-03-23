using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppKisboltosProgram
{
    internal class raktar
    {
        int raktarkod;
        string raktarnev;

        public int Raktarkod { get => raktarkod; set => raktarkod = value; }
        public string Raktarnev { get => raktarnev; set => raktarnev = value; }

        public raktar(int raktarkod, string raktarnev)
        {
            this.raktarkod = raktarkod;
            this.raktarnev = raktarnev;
        }
    }
}
