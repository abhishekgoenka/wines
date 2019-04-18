using System.Data;
using Wines.DataLayer.DataAccess;

namespace Wines.WinForm.BCL
{
    /// <summary>
    ///     Singleton class for Authentication
    /// </summary>
    internal sealed class Auth
    {
        private static Auth instance;
        private static readonly object padlock = new object();

        private Auth()
        {
        }

        public string Username { get; private set; }
        public bool IsAuthenticated { get; private set; }

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
        ///     Login
        /// </summary>
        /// <param name="username">User name</param>
        /// <param name="password">password</param>
        /// <returns>True if login is successful</returns>
        public bool SetUser(string username, string password)
        {
            var command = DataAccess.CreateCommand(CommandType.Text);
            command.CommandText = "Select Id from Users where Username = @username and Userpass = @password";

            var parameter = command.CreateParameter();
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
            if (string.IsNullOrEmpty(result))
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