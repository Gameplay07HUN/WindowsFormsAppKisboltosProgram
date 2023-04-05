using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppKisboltosProgram
{
    internal static class Program
    {

        static public formAruInsert formAruInsert=null;
        static public Form1Nyito form1Nyito = null;
        static public formAruDelete formAruDelete=null;
        static public formAruEdit formAruEdit = null;
        static public formRaktarozasUj formRaktarozasUj = null;
        static public formRakrrozasEdit formRakrrozasEdit = null;
        static public formRakrrozasDelete formRakrrozasDelete = null;
        static public formRaktarUj formRaktarUj = null;
        static public formRaktarEdit formRaktarEdit = null;
        static public formRaktarDelete formRaktarDelete = null;
        static public formRendelesUj formRendelesUj = null;
        static public formRendelesEdit formRendelesEdit = null;
        static public formRendelesDelete formRendelesDelete = null;
        static public formVevoUj formVevoUj = null;
        static public formVevoEdit formVevoEdit = null;
        static public formVevoDelete formVevoDelete = null;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formAruInsert = new formAruInsert();
            form1Nyito = new Form1Nyito();
            formAruDelete = new formAruDelete();
            formAruEdit = new formAruEdit();
            formRaktarozasUj = new formRaktarozasUj();
            formRakrrozasEdit=new formRakrrozasEdit();
            formRakrrozasDelete = new formRakrrozasDelete();
            formRaktarUj = new formRaktarUj();
            formRaktarEdit = new formRaktarEdit();
            formRaktarDelete = new formRaktarDelete();
            formRendelesUj = new formRendelesUj();
            formRendelesEdit = new formRendelesEdit();
            formRendelesDelete = new formRendelesDelete();
            formVevoUj = new formVevoUj();
            formVevoEdit = new formVevoEdit();
            formVevoDelete = new formVevoDelete();

            Application.Run(form1Nyito);
        }
    }
}
