using System.Data;
using Wines.DataLayer.DataAccess;

namespace Wines.WinForm.BCL
{
    internal class User
    {
        /// <summary>
        ///     Returns all the users in system
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllUsers()
        {
            var command = DataAccess.CreateCommand(CommandType.Text);
            command.CommandText =
                "Select Id, FullName, Username, Active, PurchaseRight, GeneratePurchase, DailySale, Stock from Users";
            return DataAccess.ExecuteSelectCommand(command);
        }
    }
}