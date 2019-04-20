using System.Collections.Generic;
using System.Data;
using Wines.DataLayer.DataAccess;
using Wines.WinForm.Common;
using Wines.WinForm.Models;

namespace Wines.WinForm.BCL
{
    internal class Shop
    {
        /// <summary>
        ///     Returns all the shops in system
        /// </summary>
        /// <returns></returns>
        public List<ShopModel> GetAllShops()
        {
            var command = DataAccess.CreateCommand(CommandType.Text);
            command.CommandText =
                "Select ID, Shop_Name, Address, License_Renewed, IMFL, CL from Shopes";
            return Helper.ConvertDataTable<ShopModel>(DataAccess.ExecuteSelectCommand(command));
        }
    }
}