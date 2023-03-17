using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppKisboltosProgram
{
    internal class vevo
    {
        int vevokod;
        string vevonev;

        public int Vevokod { get => vevokod; set => vevokod = value; }
        public string Vevonev { get => vevonev; set => vevonev = value; }
        public vevo(int vevokod, string vevonev)
        {
            Vevokod = vevokod;
            Vevonev = vevonev;
        }
    }
}
