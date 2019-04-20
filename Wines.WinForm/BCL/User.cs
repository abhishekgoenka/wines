using System.Data;
using Wines.DataLayer.DataAccess;

namespace Wines.WinForm.BCL
{
    internal class Shop
    {
        /// <summary>
        ///     Returns all the shopes in system
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllShopes()
        {
            var command = DataAccess.CreateCommand(CommandType.Text);
            command.CommandText =
                "Select ID, Shop_Name, Address, License_Renewed, IMFL, CL, Reserve1 from Shopes";
            return DataAccess.ExecuteSelectCommand(command);
        }
    }

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
                "Select Id, FullName, Username, Active, PurchaseRight, Gen_Purcha, DailySale, Stock, Reserve1 from Users";
            return DataAccess.ExecuteSelectCommand(command);
        }
    }
}