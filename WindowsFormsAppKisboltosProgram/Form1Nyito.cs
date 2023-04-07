using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsAppKisboltosProgram
{
    public partial class Form1Nyito : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;database=kisbolt2;port=3306;username=root;password=");
        MySqlCommand cmd;
        MySqlDataReader dr;
        public Form1Nyito()
        {
            InitializeComponent();
        }

        private void újToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.formAruInsert.ShowDialog();
        }

        private void törlésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.formAruInsert.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Program.formAruInsert.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Program.formAruEdit.ShowDialog();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Program.formAruDelete.ShowDialog();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Program.formRaktarozasUj.ShowDialog();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Program.formRakrrozasEdit.ShowDialog();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Program.formRakrrozasDelete.ShowDialog();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            Program.formRaktarEdit.ShowDialog();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            Program.formRaktarDelete.ShowDialog();
        }

        private void toolStripMenuItem9_Click_1(object sender, EventArgs e)
        {
            Program.formRaktarUj.ShowDialog();
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            Program.formRendelesUj.ShowDialog();
        }

        private void módosítToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.formRendelesEdit.ShowDialog();
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            Program.formRendelesDelete.ShowDialog();
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            Program.formVevoUj.ShowDialog();
        }

        private void módosítToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Program.formVevoEdit.ShowDialog();
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            Program.formVevoDelete.ShowDialog();
        }

        private void Form1Nyito_Load(object sender, EventArgs e)
        {
            string sql = "SELECT *  FROM `termek` WHERE 1;";
            cmd= new MySqlCommand(sql,conn);
            conn.Open();
            dr=cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBoxAru.Items.Add(dr["aruneve"]);
            }
            conn.Close();

        }

        private void comboBoxAru_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new MySqlCommand("SELECT *  FROM `termek` WHERE aruneve=@aruneve;",conn);
            cmd.Parameters.AddWithValue("@aruneve",comboBoxAru.Text);
            conn.Open();
            dr= cmd.ExecuteReader();
            while (dr.Read())
            {
                string ar = dr["eladasiar"].ToString();

                textBoxAr.Text = ar;

            }
            conn.Close();

            textBoxOsszesen.Text = "";
            textBoxMennyiseg.Text = "";
        }


        private void textBoxMennyiseg_TextChanged(object sender, EventArgs e)
        {


            if (textBoxMennyiseg.Text.Length > 0)
            {
              textBoxOsszesen.Text = (Convert.ToInt32(textBoxAr.Text) * Convert.ToInt32(textBoxMennyiseg.Text)).ToString();
            }
        }

        private void buttonAruHozzaadasa_Click(object sender, EventArgs e)
        {
            string[] hozzaad = new string[4];
            hozzaad[0]=comboBoxAru.SelectedItem.ToString();
            hozzaad[1] = textBoxAr.Text;
            hozzaad[2] = textBoxMennyiseg.Text;
            hozzaad[3] = textBoxOsszesen.Text;

            ListViewItem lvi = new ListViewItem(hozzaad);

            listView1.Items.Add(lvi);

            textBoxReszosszeg.Text = (Convert.ToInt32(textBoxReszosszeg.Text) + Convert.ToInt32(textBoxOsszesen.Text)).ToString();
        }

        private void textBoxLearazas_TextChanged(object sender, EventArgs e)
        {
            if (textBoxLearazas.Text.Length > 0)
            {
                textBoxNetto.Text = (Convert.ToInt32(textBoxReszosszeg.Text) - Convert.ToInt32(textBoxLearazas.Text)).ToString();
            }
        }

        private void textBoxFizetett_TextChanged(object sender, EventArgs e)
        {
            if (textBoxFizetett.Text.Length > 0)
            {
                textBoxEgyenleg.Text = (Convert.ToInt32(textBoxNetto.Text) - Convert.ToInt32(textBoxFizetett.Text)).ToString();
            }
        }

        private void buttonTorles_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0) 
            {
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].Selected)
                    {
                        textBoxReszosszeg.Text = (Convert.ToInt32(textBoxReszosszeg.Text) - Convert.ToInt32(listView1.Items[i].SubItems[3].Text)).ToString();
                        listView1.Items[i].Remove();
                    }
                }
            }
        }

        private void buttonNyomtat_Click(object sender, EventArgs e)
        {

        }

    }
}
