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
        public bool SetUser(int shopID, string username, string password)
        {
            var command = DataAccess.CreateCommand(CommandType.Text);
            command.CommandText = "Select Id, FullName from Users where FullName = @username and Userpass = @password and Shop_ID=@shopID";

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

            parameter = command.CreateParameter();
            parameter.ParameterName = "@shopID";
            parameter.Value = shopID;
            parameter.DbType = DbType.Int32;
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