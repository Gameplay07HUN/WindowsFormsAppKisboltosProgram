using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppKisboltosProgram
{
    internal static class Program
    {
        //static public FormTanuloUpdate formTanuloUpdate=null;
        //static public FormTanuloDelete formTanuloDelete=null;
        static public formAruInsert formAruInsert=null;
        static public Form1Nyito form1Nyito = null;
        static public formAruDelete formTanuloDelete=null;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //formTanuloUpdate = new FormTanuloUpdate();
            //formTanuloDelete = new FormTanuloDelete();
            formAruInsert = new formAruInsert();
            form1Nyito = new Form1Nyito();
            formTanuloDelete = new formAruDelete();
            Application.Run(form1Nyito);
        }
    }
}
