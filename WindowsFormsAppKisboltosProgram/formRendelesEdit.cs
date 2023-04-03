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
    public partial class formRendelesEdit : Form
    {
        Database db = new Database("localhost", "root", "", "kisbolt2");
        public formRendelesEdit()
        {
            InitializeComponent();
        }

        private void formRendelesEdit_Load(object sender, EventArgs e)
        {
            dataGridViewRendelesFelepitese();
            dataGridViewRendelesUpdate();
        }
        private void dataGridViewRendelesUpdate()
        {
            dataGridViewKisBolt.Rows.Clear();
            foreach (rendeles rekord in db.getAllRendeles())
            {
                //--rekord adatának beírása egy sor celláiba ------------
                int sorIndex = dataGridViewKisBolt.Rows.Add();
                DataGridViewRow getUjSor = dataGridViewKisBolt.Rows[sorIndex];//-- kiolvassuk
                getUjSor.Cells["cikkszam"].Value = rekord.Cikkszam;
                getUjSor.Cells["vevokod"].Value = rekord.Vevokod;
                getUjSor.Cells["datum"].Value = rekord.Datum;
                getUjSor.Cells["mennyiseg"].Value = rekord.Mennyiseg;
                getUjSor.Cells["beszerzesiar"].Value = rekord.Beszerzesiar;

            }
        }
        private void dataGridViewRendelesFelepitese()
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
            DataGridViewColumn col_vevokod = new DataGridViewColumn();
            {
                col_vevokod.Name = "vevokod";
                col_vevokod.HeaderText = "vevokod";
                col_vevokod.CellTemplate = new DataGridViewTextBoxCell();
            }
            dataGridViewKisBolt.Columns.Add(col_vevokod);
            DataGridViewColumn col_datum = new DataGridViewColumn();
            {
                col_datum.CellTemplate = new DataGridViewTextBoxCell();
                col_datum.HeaderText = "datum";
                col_datum.Name = "datum";
            }
            dataGridViewKisBolt.Columns.Add(col_datum);
            DataGridViewColumn col_mennyiseg = new DataGridViewColumn();
            {
                col_mennyiseg.CellTemplate = new DataGridViewTextBoxCell();
                col_mennyiseg.HeaderText = "mennyiseg";
                col_mennyiseg.Name = "mennyiseg";
            }
            dataGridViewKisBolt.Columns.Add(col_mennyiseg);
            DataGridViewColumn col_beszerzesiar = new DataGridViewColumn();
            {
                col_beszerzesiar.CellTemplate = new DataGridViewTextBoxCell();
                col_beszerzesiar.HeaderText = "beszerzesiar";
                col_beszerzesiar.Name = "beszerzesiar";
            }
            dataGridViewKisBolt.Columns.Add(col_beszerzesiar);
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
                textBoxVevoKod.Text = rekord.Cells["vevokod"].Value.ToString();
                dateTimePickerDatum.Text = rekord.Cells["datum"].Value.ToString();
                textBoxMennyiseg.Text = rekord.Cells["mennyiseg"].Value.ToString();
                numericUpDownBeszerzesiar.Value = decimal.Parse(rekord.Cells["beszerzesiar"].Value.ToString());
            }

        }
        private void buttonModosit_Click(object sender, EventArgs e)
        {
            db.dbOpen();
            MySqlCommand cmd = db.connection.CreateCommand();

            cmd.CommandText = "SET foreign_key_checks = 0;";
            cmd.ExecuteNonQuery();
            if (dataGridViewKisBolt.SelectedRows.Count < 0)
            {
                MessageBox.Show("Nincs kijelölve termék!");
                return;
            }
            
            cmd.CommandText = "UPDATE `rendeles` SET `cikkszam`= @cikkszam, `vevokod` = @vevokod, `datum` = @datum, `mennyiseg` = @mennyiseg, `beszerzesiar` = @beszerzesiar  WHERE `rendeles`.`cikkszam` = @cikkszam;";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@cikkszam", int.Parse(textBoxCikkszam.Text));
            cmd.Parameters.AddWithValue("@vevokod", textBoxVevoKod.Text);
            cmd.Parameters.AddWithValue("@datum", dateTimePickerDatum.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@mennyiseg", textBoxMennyiseg.Text);
            cmd.Parameters.AddWithValue("@beszerzesiar", numericUpDownBeszerzesiar.Value);
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Sikeresen rögzítve");
                    textBoxCikkszam.Text = "";
                    textBoxVevoKod.Text = "";
                    dateTimePickerDatum.Text = "";
                    textBoxMennyiseg.Text = "";
                    numericUpDownBeszerzesiar.Value = numericUpDownBeszerzesiar.Minimum;
                    dataGridViewRendelesUpdate();
                }
                else
                {
                    MessageBox.Show("Sikertelen módosítás!");
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
