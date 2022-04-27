using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfConverter
{
    public static class Database
    {
        private static DataTable Search(string sql)
        {
            string query = string.Format(sql);
            DataTable dt = new DataTable();
            using (MySqlDataAdapter da = new MySqlDataAdapter(query, ConnectionMySql.GetCon()))
            {
                da.Fill(dt);
            }
            ConnectionMySql.Close();
            return dt;
        }

        private static void Execute(string sql, Dictionary<string, string> queryParams)
        {
            using (MySqlCommand cmd = new MySqlCommand(string.Format(sql), ConnectionMySql.GetCon()))
            {
                foreach (KeyValuePair<string, string> param in queryParams)
                {
                    cmd.Parameters.AddWithValue(param.Key, param.Value);
                }
                cmd.ExecuteNonQuery();
            }
            ConnectionMySql.Close();
        }

        public static int LastID()
        {
            string sql = $"SELECT Max(batchtrack) as batchtrack FROM {Global.db.DatabaseName}.{Global.db.FlowTable}";
            DataTable data = Search(sql);
            string batchtrack = (string)data.Rows[0]["batchtrack"];
            return Convert.ToInt32(batchtrack.Replace("E", ""));
        }

        public static void CreateFlowItem(DateTime data, string name, string batchtrack)
        {
            string sql = $"INSERT INTO {Global.db.DatabaseName}.{Global.db.FlowTable}(created, name, batchtrack) VALUES(@data, @name, @batchtrack)";

            Dictionary<string, string> values = new Dictionary<string, string>();
            values["data"] = data.ToString("yyyy-MM-dd HH:mm:ss");
            values["name"] = name;
            values["batchtrack"] = batchtrack;

            Database.Execute(sql, values);
        }
    }
}
