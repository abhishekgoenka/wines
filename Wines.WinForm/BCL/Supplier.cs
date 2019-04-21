using System.Collections.Generic;
using System.Data;
using Wines.DataLayer.DataAccess;
using Wines.WinForm.Common;
using Wines.WinForm.Models;

namespace Wines.WinForm.BCL
{
    internal class Supplier
    {
        /// <summary>
        /// Get all supliers
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllSuppliers()
        {
            var command = DataAccess.CreateCommand(CommandType.Text);
            command.CommandText =
                "SELECT ID, ShortName, FullName, Active, IMFL, CL FROM Supplier;";
            return DataAccess.ExecuteSelectCommand(command);
        }
    }
}