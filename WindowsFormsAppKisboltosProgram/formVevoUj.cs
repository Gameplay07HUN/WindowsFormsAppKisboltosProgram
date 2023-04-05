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
    public partial class formVevoUj : Form
    {
        Database db = new Database("localhost", "root", "", "kisbolt2");
        public formVevoUj()
        {
            InitializeComponent();
        }

        private void formVevoUj_Load(object sender, EventArgs e)
        {
            dataGridViewVevoFelepitese();
            dataGridViewVevoUpdate();
        }
        private void dataGridViewVevoUpdate()
        {
            dataGridViewKisBolt1.Rows.Clear();
            foreach (vevo rekord in db.getAllVevo())
            {
                //--rekord adatának beírása egy sor celláiba ------------
                int sorIndex = dataGridViewKisBolt1.Rows.Add();
                DataGridViewRow getUjSor = dataGridViewKisBolt1.Rows[sorIndex];//-- kiolvassuk
                getUjSor.Cells["vevokod"].Value = rekord.Vevokod;
                getUjSor.Cells["vevonev"].Value = rekord.Vevonev;

            }
        }

        private void dataGridViewVevoFelepitese()
        {
            DataGridViewColumn col_Vevokod = new DataGridViewColumn();
            {
                //-- col_ID jellemzőinek a beállítása -------------
                col_Vevokod.Name = "vevokod";
                col_Vevokod.ReadOnly = true;
                col_Vevokod.CellTemplate = new DataGridViewTextBoxCell();
                col_Vevokod.HeaderText = "vevokod";
            }
            dataGridViewKisBolt1.Columns.Add(col_Vevokod);
            DataGridViewColumn col_Vevonev = new DataGridViewColumn();
            {
                col_Vevonev.Name = "vevonev";
                col_Vevonev.HeaderText = "vevonev";
                col_Vevonev.CellTemplate = new DataGridViewTextBoxCell();
            }
            dataGridViewKisBolt1.Columns.Add(col_Vevonev);
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
            if (rekord.Cells["vevokod"].Value == null)
            {
                return;
            }
            else
            {
                textBoxVevokod.Text = rekord.Cells["vevokod"].Value.ToString();
                textBoxVevonev.Text = rekord.Cells["vevonev"].Value.ToString();
            }

        }

        private void buttonUj_Click(object sender, EventArgs e)
        {
            db.dbOpen();
            MySqlCommand cmd = db.connection.CreateCommand();

            cmd.CommandText = "SET foreign_key_checks = 0;";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO `vevo` (`vevokod`,`vevonev`) VALUES (@vevokod, @vevonev);";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@vevokod", textBoxVevokod.Text);
            cmd.Parameters.AddWithValue("@vevonev", textBoxVevonev.Text);
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Sikeresen rögzítve");
                    textBoxVevokod.Text = "";
                    textBoxVevonev.Text = "";
                    dataGridViewVevoUpdate();
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
    }
}
