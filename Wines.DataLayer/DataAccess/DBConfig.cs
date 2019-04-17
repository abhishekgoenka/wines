namespace Wines.DataLayer.DataAccess
{
    /// <summary>
    ///     contains database connection string
    /// </summary>
    internal class DBConfig
    {
        private static readonly string database = "data.db";

        static DBConfig()
        {
            DbConnectionString = $"Data Source={database};Version=3;";
        }

        public static string DbConnectionString { get; }
    }
}