﻿using System;
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
            Application.Run(form1Nyito);
        }
    }
}
