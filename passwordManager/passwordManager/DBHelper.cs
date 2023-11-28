using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace passwordManager
{
    public static class DBHelper
    {
        private static MySqlConnection connection;
        private static MySqlCommand cmd = null;
        private static DataTable table;
        //private static MySqlDataAdapter adapter;
        private static MySqlDataReader reader;

        public static void EstablishConnection()
        {
            try
            {
                connectToDB();
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        public static DataTable LoadData()
        {
            connectToDB();
            connection.Open();
            cmd = new MySqlCommand("select * from password", connection);
            reader = cmd.ExecuteReader();
            table = new DataTable();
            table.Load(reader);
            connection.Close();
            return table;
        }
        public static void AddData(string site, string user, string pass)
        {
            connectToDB();
            connection.Open();
            cmd = new MySqlCommand("insert into password(site, user, password) values('"+site+"', '"+user+"', '"+pass+"')",connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public static void DeleteData(int id)
        {
            connectToDB();
            connection.Open();
            cmd = new MySqlCommand("delete from password where id = '"+id+"'",connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public static void EditData(int id, string site, string user, string pass)
        {
            connectToDB();
            connection.Open();
            cmd = new MySqlCommand("update password set site = '"+site+"', user = '"+user+"', password = '"+pass+"' where id = '"+id+"'", connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public static string getSite(int id)
        {
            string site;
            connectToDB();
            connection.Open();
            cmd = new MySqlCommand("select site from password where id = '"+id+"'", connection);
            reader = cmd.ExecuteReader();
            reader.Read();
            site = reader.GetString(0);
            return site;
        }

        public static string getPass(int id)
        {
            string pass;
            connectToDB();
            connection.Open();
            cmd = new MySqlCommand("select password from password where id = '" + id + "'", connection);
            reader = cmd.ExecuteReader();
            reader.Read();
            pass = reader.GetString(0);
            return pass;
        }

        public static string getUser(int id)
        {
            string user;
            connectToDB();
            connection.Open();
            cmd = new MySqlCommand("select user from password where id = '" + id + "'", connection);
            reader = cmd.ExecuteReader();
            reader.Read();
            user = reader.GetString(0);
            return user;
        }

        public static MySqlConnection connectToDB()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "127.0.0.1";
            builder.UserID = "root";
            builder.Password = "1234";
            builder.Database = "passwordmanagerdb";
            connection = new MySqlConnection(builder.ToString());
            return connection;
        }
    }
}
