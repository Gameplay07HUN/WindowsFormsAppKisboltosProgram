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
    public partial class formRaktarozasUj : Form
    {

        Database db = new Database("localhost", "root", "", "kisbolt2");
        public formRaktarozasUj()
        {
            InitializeComponent();
        }

        private void formRaktarozasUj_Load(object sender, EventArgs e)
        {
            dataGridViewRaktarozasFelepitese();
            dataGridViewRaktarozasUpdate();
        }
        private void dataGridViewRaktarozasUpdate()
        {
            dataGridViewKisBolt1.Rows.Clear();
            foreach (rakatozas rekord in db.getAllRaktarozas())
            {
                //--rekord adatának beírása egy sor celláiba ------------
                int sorIndex = dataGridViewKisBolt1.Rows.Add();
                DataGridViewRow getUjSor = dataGridViewKisBolt1.Rows[sorIndex];//-- kiolvassuk
                getUjSor.Cells["cikkszam"].Value = rekord.Cikkszam;
                getUjSor.Cells["raktarkod"].Value = rekord.Raktarkod;

            }
        }

        private void dataGridViewRaktarozasFelepitese()
        {
            DataGridViewColumn col_ID = new DataGridViewColumn();
            {
                //-- col_ID jellemzőinek a beállítása -------------
                col_ID.Name = "cikkszam";
                col_ID.ReadOnly = true;
                col_ID.CellTemplate = new DataGridViewTextBoxCell();
                col_ID.HeaderText = "Cikkszam";
            }
            dataGridViewKisBolt1.Columns.Add(col_ID);
            DataGridViewColumn col_Raktarkod = new DataGridViewColumn();
            {
                col_Raktarkod.Name = "raktarkod";
                col_Raktarkod.HeaderText = "raktarkod";
                col_Raktarkod.CellTemplate = new DataGridViewTextBoxCell();
            }
            dataGridViewKisBolt1.Columns.Add(col_Raktarkod);
            //-- Egész táblázatra vonatkozó beállítások --------------
            dataGridViewKisBolt1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void dataGridViewKisBolt1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewKisBolt1.SelectedRows.Count == 0)
            {
                return;
            }
            DataGridViewRow rekord = dataGridViewKisBolt1.SelectedRows[0];
            if (rekord.Cells["cikkszam"].Value == null)
            {
                return;
            }
            else
            {
                textBoxCikkszam.Text = rekord.Cells["cikkszam"].Value.ToString();
                textBoxRaktarkod.Text = rekord.Cells["raktarkod"].Value.ToString();
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

        private void buttonUj_Click_1(object sender, EventArgs e)
        {
            db.dbOpen();
            MySqlCommand cmd = db.connection.CreateCommand();

            cmd.CommandText = "SET foreign_key_checks = 0;";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO `raktarozas` (`cikkszam`,`raktarkod`) VALUES (@cikkszam, @raktarkod);";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@cikkszam", int.Parse(textBoxCikkszam.Text));
            cmd.Parameters.AddWithValue("@raktarkod", textBoxRaktarkod.Text);
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Sikeresen rögzítve");
                    textBoxCikkszam.Text = "";
                    textBoxRaktarkod.Text = "";
                    dataGridViewRaktarozasUpdate();
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
    }
}
