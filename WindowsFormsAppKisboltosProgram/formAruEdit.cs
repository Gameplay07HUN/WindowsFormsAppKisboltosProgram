﻿using MySql.Data.MySqlClient;
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
    public partial class formAruEdit : Form
    {
        Database db = new Database("localhost", "root", "", "kisbolt2");
        public formAruEdit()
        {
            InitializeComponent();
        }

        private void formAruEdit_Load(object sender, EventArgs e)
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
                textBox4.Text = rekord.Cells["cikkszam"].Value.ToString();
                textBox3.Text = rekord.Cells["kategória"].Value.ToString();
                textBox1.Text = rekord.Cells["aruneve"].Value.ToString();
                numericUpDown1.Value = decimal.Parse(rekord.Cells["eladasiar"].Value.ToString());
                textBox2.Text = rekord.Cells["marka"].Value.ToString();
            }

        }

        private void buttonEdit2_Click(object sender, EventArgs e)
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
            cmd.CommandText = "UPDATE `termek` SET `cikkszam` = @cikkszam, `kategória` = @kategória, `aruneve` = @aruneve, `eladasiar` = @eladasiar,  `marka` = @marka  WHERE `termek`.`cikkszam` = @cikkszam;";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@cikkszam", int.Parse(textBox4.Text));
            cmd.Parameters.AddWithValue("@kategória", textBox3.Text);
            cmd.Parameters.AddWithValue("@aruneve", textBox1.Text);
            cmd.Parameters.AddWithValue("@eladasiar", numericUpDown1.Value);
            cmd.Parameters.AddWithValue("@marka", textBox2.Text);
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Sikeresen módosítva");
                    textBox4.Text = "";
                    textBox3.Text = "";
                    textBox1.Text = "";
                    numericUpDown1.Value = numericUpDown1.Minimum;
                    textBox2.Text = "";
                    dataGridViewTerkemkUpdate();
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
