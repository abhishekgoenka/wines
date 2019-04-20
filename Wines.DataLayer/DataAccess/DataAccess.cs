using System;
using System.Data;
using Microsoft.Win32;
using System.Data.SQLite;
using NLog;

namespace Wines.DataLayer.DataAccess
{
    public class DataAccess
    {
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public static SQLiteCommand CreateCommand(CommandType commandType)
        {
            var command = new SQLiteConnection(DBConfig.DbConnectionString).CreateCommand();
            command.CommandType = commandType;
            return command;
        }

        public static SQLiteCommand CreateCommand()
        {
            return CreateCommand(CommandType.StoredProcedure);
        }


        public static int ExecuteNonQuery(SQLiteCommand command)
        {
            var num = -1;
            try
            {
                command.Connection.Open();
                num = command.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                _logger.Error(exception, "ExecuteNonQuery exception");
            }
            finally
            {
                command.Connection.Close();
            }

            return num;
        }

        public static string ExecuteScalar(SQLiteCommand command)
        {
            try
            {
                command.Connection.Open();
                var str = command.ExecuteScalar().ToString();
                return str;
            }
            catch (Exception exception)
            {
                _logger.Error(exception, "ExecuteNonQuery exception");
                return string.Empty;
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public static DataTable ExecuteSelectCommand(SQLiteCommand command)
        {
            var table = new DataTable();
            try
            {
                command.Connection.Open();
                var reader = command.ExecuteReader();
                table = new DataTable();
                table.Load(reader);
                reader.Close();
            }
            catch (Exception exception)
            {
                _logger.Error(exception, "ExecuteNonQuery exception");
                return null;
            }
            finally
            {
                command.Connection.Close();
            }

            return table;
        }
    }
}