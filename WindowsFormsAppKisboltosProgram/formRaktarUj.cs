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
    public partial class formRaktarUj : Form
    {
        Database db = new Database("localhost", "root", "", "kisbolt2");
        public formRaktarUj()
        {
            InitializeComponent();
        }

        private void formRaktarUj_Load(object sender, EventArgs e)
        {
            dataGridViewRaktarFelepitese();
            dataGridViewRaktarUpdate();
        }
        private void dataGridViewRaktarUpdate()
        {
            dataGridViewKisBolt1.Rows.Clear();
            foreach (raktar rekord in db.getAllRaktar())
            {
                //--rekord adatának beírása egy sor celláiba ------------
                int sorIndex = dataGridViewKisBolt1.Rows.Add();
                DataGridViewRow getUjSor = dataGridViewKisBolt1.Rows[sorIndex];//-- kiolvassuk
                getUjSor.Cells["raktarkod"].Value = rekord.Raktarkod;
                getUjSor.Cells["raktarnev"].Value = rekord.Raktarnev;

            }
        }

        private void dataGridViewRaktarFelepitese()
        {
            DataGridViewColumn col_ID = new DataGridViewColumn();
            {
                //-- col_ID jellemzőinek a beállítása -------------
                col_ID.Name = "raktarkod";
                col_ID.ReadOnly = true;
                col_ID.CellTemplate = new DataGridViewTextBoxCell();
                col_ID.HeaderText = "raktarkod";
            }
            dataGridViewKisBolt1.Columns.Add(col_ID);
            DataGridViewColumn col_Raktarnev = new DataGridViewColumn();
            {
                col_Raktarnev.Name = "raktarnev";
                col_Raktarnev.HeaderText = "raktarnev";
                col_Raktarnev.CellTemplate = new DataGridViewTextBoxCell();
            }
            dataGridViewKisBolt1.Columns.Add(col_Raktarnev);
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
            if (rekord.Cells["raktarkod"].Value == null)
            {
                return;
            }
            else
            {
                textBoxRaktarkod.Text = rekord.Cells["raktarkod"].Value.ToString();
                textBoxRaktarnev.Text = rekord.Cells["raktarnev"].Value.ToString();
            }

        }
        private void buttonUj_Click(object sender, EventArgs e)
        {
            db.dbOpen();
            MySqlCommand cmd = db.connection.CreateCommand();

            cmd.CommandText = "SET foreign_key_checks = 0;";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO `raktar` (`raktarkod`,`raktarnev`) VALUES (@raktarkod, @raktarnev);";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@raktarkod", int.Parse(textBoxRaktarkod.Text));
            cmd.Parameters.AddWithValue("@raktarnev", textBoxRaktarnev.Text);
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Sikeresen rögzítve");
                    textBoxRaktarkod.Text = "";
                    textBoxRaktarnev.Text = "";
                    dataGridViewRaktarUpdate();
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
