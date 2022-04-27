using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfConverter
{
    public class DatabaseConnection
    {
        public string DatabaseName = "pd_grsnucleo";
        public string FlowTable = "Flow_Emails";
    }

    public static class Global
    {
        public static DatabaseConnection db = new DatabaseConnection();
    }
}
