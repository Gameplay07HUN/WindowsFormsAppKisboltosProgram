using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsAppKisboltosProgram
{
    internal class Database
    {
        public readonly MySqlConnection connection;
        private MySqlCommand sqlCommand;
        private string hibaSzöveg = null;
        public Database(string host, string user, string password, string db)
        {
            MySqlConnectionStringBuilder stringBuilder = new MySqlConnectionStringBuilder();
            stringBuilder.Server = host;
            stringBuilder.UserID = user;
            stringBuilder.Password = password;
            stringBuilder.Database = db;
            connection = new MySqlConnection(stringBuilder.ConnectionString);
            sqlCommand = connection.CreateCommand();
        }
        public bool dbOpen()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
            }
            catch (MySqlException ex)
            {
                hibaSzöveg = ex.Message;
                return false;
            }
            return true;
        }
        public bool dbClose()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
            catch (MySqlException ex)
            {
                hibaSzöveg = ex.Message;
                return false;
            }
            return true;
        }

        public List<Termek> getAllTermek()
        {
            List<Termek> termek = new List<Termek>();
            sqlCommand.CommandText = "SELECT `cikkszam`,`kategória`,`aruneve`,`eladasiar`,`marka` FROM `termek` WHERE 1;";
            if (dbOpen())
            {
                using (MySqlDataReader dr = sqlCommand.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Termek uj = new Termek(dr.GetInt32("cikkszam"), dr.GetString("kategória"), dr.GetString("aruneve"), dr.GetInt32("eladasiar"),dr.GetString("marka"));
                        termek.Add(uj);
                    }
                }
            }
            else
            {
                MessageBox.Show(hibaSzöveg);
            }
            dbClose();
            return termek;
        }
        public List<rakatozas> getAllRaktarozas()
        {
            List<rakatozas> rakatozas = new List<rakatozas>();
            sqlCommand.CommandText = "SELECT `cikkszam`,`raktarkod` FROM `raktarozas` WHERE 1;";
            if (dbOpen())
            {
                using (MySqlDataReader dr = sqlCommand.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        rakatozas uj = new rakatozas(dr.GetInt32("cikkszam"), dr.GetInt32("raktarkod"));
                        rakatozas.Add(uj);
                    }
                }
            }
            else
            {
                MessageBox.Show(hibaSzöveg);
            }
            dbClose();
            return rakatozas;
        }
        public List<raktar> getAllRaktar()
        {
            List<raktar> raktar = new List<raktar>();
            sqlCommand.CommandText = "SELECT `raktarkod`,`raktarnev`FROM `raktar` WHERE 1;";
            if (dbOpen())
            {
                using (MySqlDataReader dr = sqlCommand.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        raktar uj = new raktar(dr.GetInt32("raktarkod"), dr.GetString("raktarnev"));
                        raktar.Add(uj);
                    }
                }
            }
            else
            {
                MessageBox.Show(hibaSzöveg);
            }
            dbClose();
            return raktar;
        }
        public List<rendeles> getAllRendeles()
        {
            List<rendeles> rendeles = new List<rendeles>();
            sqlCommand.CommandText = "SELECT `cikkszam`,`vevokod`,`datum`,`mennyiseg`,`beszerzesiar` FROM `rendeles` WHERE 1;";
            if (dbOpen())
            {
                using (MySqlDataReader dr = sqlCommand.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        rendeles uj = new rendeles(dr.GetInt32("cikkszam"), dr.GetString("vevokod"), dr.GetDateTime("datum"), dr.GetInt32("mennyiseg"), dr.GetInt32("beszerzesiar"));
                        rendeles.Add(uj);
                    }
                }
            }
            else
            {
                MessageBox.Show(hibaSzöveg);
            }
            dbClose();
            return rendeles;
        }
        public List<vevo> getAllVevo()
        {
            List<vevo> vevo = new List<vevo>();
            sqlCommand.CommandText = "SELECT `vevokod`,`vevonev`FROM `vevo` WHERE 1;";
            if (dbOpen())
            {
                using (MySqlDataReader dr = sqlCommand.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        vevo uj = new vevo(dr.GetString("vevokod"), dr.GetString("vevonev"));
                        vevo.Add(uj);
                    }
                }
            }
            else
            {
                MessageBox.Show(hibaSzöveg);
            }
            dbClose();
            return vevo;
        }


    }
}