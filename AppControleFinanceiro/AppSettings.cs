using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppControleFinanceiro
{
    public class AppSettings
    {
        private static string databaseName = "database.db";
        private static string databaseDirectory = FileSystem.AppDataDirectory;
        public static string DatabasePath = Path.Combine(databaseDirectory, databaseName);
    }
}
