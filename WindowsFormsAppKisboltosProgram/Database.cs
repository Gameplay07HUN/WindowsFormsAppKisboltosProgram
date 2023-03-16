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
        

    }
}