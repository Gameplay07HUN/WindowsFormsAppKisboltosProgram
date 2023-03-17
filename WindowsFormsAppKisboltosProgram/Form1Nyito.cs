using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppKisboltosProgram
{
    public partial class Form1Nyito : Form
    {
        public Form1Nyito()
        {
            InitializeComponent();
        }

        private void újToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.formAruInsert.ShowDialog();
        }

        private void módosításToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void törlésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.formAruInsert.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelNev_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNev_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1Nyito_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Program.formAruInsert.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Program.formAruEdit.ShowDialog();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Program.formAruDelete.ShowDialog();
        }

        private void raktarozasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Program.formRaktarozasUj.ShowDialog();
        }
    }
}
