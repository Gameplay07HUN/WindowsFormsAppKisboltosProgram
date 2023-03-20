using MySql.Data.MySqlClient;
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
    public partial class formAruInsert : Form
    {
        Database db = new Database("localhost", "root", "", "kisbolt2");
        public formAruInsert()
        {
            InitializeComponent();
        }

        private void formAruInsert_Load(object sender, EventArgs e)
        {
            dataGridViewTerkemkFelepitese();
            dataGridViewTerkemkUpdate();
        }
        private void dataGridViewTerkemkUpdate()
        {
            dataGridViewKisBolt.Rows.Clear();
            foreach (Termek rekord in db.getAllTermek())
            {
                //--rekord adatának beírása egy sor celláiba ------------
                int sorIndex = dataGridViewKisBolt.Rows.Add();
                DataGridViewRow getUjSor = dataGridViewKisBolt.Rows[sorIndex];//-- kiolvassuk
                getUjSor.Cells["cikkszam"].Value = rekord.Cikkszam;
                getUjSor.Cells["kategória"].Value = rekord.Kategoria;
                getUjSor.Cells["aruneve"].Value = rekord.Aruaruneve;
                getUjSor.Cells["eladasiar"].Value = rekord.Eladasiar;
                getUjSor.Cells["marka"].Value = rekord.Marka;

            }
        }

        private void dataGridViewTerkemkFelepitese()
        {
            DataGridViewColumn col_ID = new DataGridViewColumn();
            {
                //-- col_ID jellemzőinek a beállítása -------------
                col_ID.Name = "cikkszam";
                col_ID.ReadOnly = true;
                col_ID.CellTemplate = new DataGridViewTextBoxCell();
                col_ID.HeaderText = "Cikkszam";
            }
            dataGridViewKisBolt.Columns.Add(col_ID);
            DataGridViewColumn col_Kategória = new DataGridViewColumn();
            {
                col_Kategória.Name = "kategória";
                col_Kategória.HeaderText = "Kategória";
                col_Kategória.CellTemplate = new DataGridViewTextBoxCell();
            }
            dataGridViewKisBolt.Columns.Add(col_Kategória);
            DataGridViewColumn col_aruneve = new DataGridViewColumn();
            {
                col_aruneve.CellTemplate = new DataGridViewTextBoxCell();
                col_aruneve.HeaderText = "Aru neve";
                col_aruneve.Name = "aruneve";
            }
            dataGridViewKisBolt.Columns.Add(col_aruneve);
            DataGridViewColumn col_eladasiar = new DataGridViewColumn();
            {
                col_eladasiar.CellTemplate = new DataGridViewTextBoxCell();
                col_eladasiar.HeaderText = "Eladasiar";
                col_eladasiar.Name = "eladasiar";
            }
            dataGridViewKisBolt.Columns.Add(col_eladasiar);
            DataGridViewColumn col_Marka = new DataGridViewColumn();
            {
                col_Marka.CellTemplate = new DataGridViewTextBoxCell();
                col_Marka.HeaderText = "Marka";
                col_Marka.Name = "marka";
            }
            dataGridViewKisBolt.Columns.Add(col_Marka);
            //-- Egész táblázatra vonatkozó beállítások --------------
            dataGridViewKisBolt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void dataGridViewKisBolt_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewKisBolt.SelectedRows.Count == 0)
            {
                return;
            }
            DataGridViewRow rekord = dataGridViewKisBolt.SelectedRows[0];
            if (rekord.Cells["cikkszam"].Value == null)
            {
                return;
            }
            else
            {
                textBoxCikkszam.Text = rekord.Cells["cikkszam"].Value.ToString();
                textBoxKategória.Text = rekord.Cells["kategória"].Value.ToString();
                textBoxAruneve.Text = rekord.Cells["aruneve"].Value.ToString();
                numericUpDownEladasiar.Value = decimal.Parse(rekord.Cells["eladasiar"].Value.ToString());
                textBoxMarka.Text = rekord.Cells["marka"].Value.ToString();
            }

        }

        private void modosítToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.formAruEdit.ShowDialog();
        }

        private void törölToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.formAruDelete.ShowDialog();
        }

        private void buttonUj_Click(object sender, EventArgs e)
        {
            db.dbOpen();
            MySqlCommand cmd = db.connection.CreateCommand();

            cmd.CommandText = "SET foreign_key_checks = 0;";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO `termek` (`cikkszam`,`kategória`,`aruneve`,`eladasiar`,`marka`) VALUES (@cikkszam, @kategória, @aruneve, @eladasiar, @marka);";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@cikkszam", int.Parse(textBoxCikkszam.Text));
            cmd.Parameters.AddWithValue("@kategória", textBoxKategória.Text);
            cmd.Parameters.AddWithValue("@aruneve", textBoxAruneve.Text);
            cmd.Parameters.AddWithValue("@eladasiar", numericUpDownEladasiar.Value);
            cmd.Parameters.AddWithValue("@marka", textBoxMarka.Text);
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Sikeresen rögzítve");
                    textBoxCikkszam.Text = "";
                    textBoxKategória.Text = "";
                    textBoxAruneve.Text = "";
                    numericUpDownEladasiar.Value = numericUpDownEladasiar.Minimum;
                    textBoxMarka.Text = "";
                    dataGridViewTerkemkUpdate();
                }
                else
                {
                    MessageBox.Show("Sikertelen rögzítés!");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                db.dbClose();
            }

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Program.formRaktarozasUj.ShowDialog();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Program.formRakrrozasDelete.ShowDialog();
        }
    }
}