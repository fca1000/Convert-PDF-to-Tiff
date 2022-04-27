using MySql.Data.MySqlClient;
using System.Configuration;

namespace PdfConverter
{
    public class ConnectionMySql
    {
        private static ConnectionMySql _instance;
        private MySqlConnection con;

        private ConnectionMySql()
        {
            con = new MySqlConnection
            {
                ConnectionString = ConfigurationManager.AppSettings["MySqlConnection"]
            };
            con.Open();
        }

        public static MySqlConnection GetCon()
        {
            if (_instance == null)
            {
                _instance = new ConnectionMySql();
            }

            if (_instance.con.State == System.Data.ConnectionState.Open)
            {
                return _instance.con;
            }

            _instance.con.Open();
            return _instance.con;
        }

        public static void Close()
        {
            if (_instance == null)
            {
                return;
            }
            if (_instance.con.State == System.Data.ConnectionState.Open)
            {
                _instance.con.Close();
            }
        }
    }
}
