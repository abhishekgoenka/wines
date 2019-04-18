using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wines.DataLayer.DataAccess;

namespace Wines.WinForm.BCL
{
    /// <summary>
    /// Singleton class for Authentication 
    /// </summary>
    internal sealed class Auth
    {
        private static Auth instance;
        private static readonly object padlock = new object();

        public string Username { get; private set; }
        public Boolean IsAuthenticated { get; private set; }

        private Auth()
        {
        }

        public static Auth Instance()
        {
            if (instance == null)
            {
                lock (padlock)
                {
                    return instance ?? (instance = new Auth());
                }
            }

            return instance;
        }

        /// <summary>
        /// Login
        /// </summary>
        /// <param name="username">User name</param>
        /// <param name="password">password</param>
        /// <returns>True if login is successful</returns>
        public bool SetUser(string username, string password)
        {
            SQLiteCommand command = DataAccess.CreateCommand(CommandType.Text);
            command.CommandText = "Select Id from Users where Username = @username and Userpass = @password";

            SQLiteParameter parameter = command.CreateParameter();
            parameter.ParameterName = "@username";
            parameter.Value = username;
            parameter.DbType = DbType.String;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@password";
            parameter.Value = password;
            parameter.DbType = DbType.String;
            command.Parameters.Add(parameter);

            var result = DataAccess.ExecuteScalar(command);
            if (String.IsNullOrEmpty(result))
            {
                return false;
            }

            // authentication successful
            IsAuthenticated = true;
            Username = username;
            return true;
        }
    }
}
