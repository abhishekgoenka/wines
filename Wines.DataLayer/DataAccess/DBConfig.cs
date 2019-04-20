using System;
using System.Data;
using Microsoft.Win32;

namespace Wines.DataLayer.DataAccess
{
    /// <summary>
    ///     contains database connection string
    /// </summary>
    internal class DBConfig
    {
        static DBConfig()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Wines");
            string strDbPath = key.GetValue("DBPath").ToString();

            if (strDbPath.Length == 0)
                strDbPath = "WinesData.db";

                DbConnectionString = $"Data Source={strDbPath};Version=3;";
        }

        public static string DbConnectionString { get; }
    }
}