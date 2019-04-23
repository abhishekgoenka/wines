using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wines.DataLayer.DataAccess;

namespace Wines.WinForm.BCL
{
    internal class Purchase
    {
        public int Add(long supplierid, long brandid, DateTime purchaseDate, long rate, decimal qty, long amount, long diffAmount)
        {
            var command = DataAccess.CreateCommand(CommandType.Text);
            command.CommandText =
                "INSERT INTO Purchase (Shop_ID, User_ID, Supplier_ID, Brand_ID, Purchase_Date, Modify_Date, Rate, Quantity, Amount, Diff_Amt, Reserve1 ) VALUES (@Shop_ID, @User_ID, @Supplier_ID, @Brand_ID, @Purchase_Date, @Modify_Date, @Rate, @Quantity, @Amount, @Diff_Amt, 'Reserve1');";

            var parameter = command.CreateParameter();
            parameter.ParameterName = "@Shop_ID";
            parameter.Value = Auth.Instance().ShopId;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@User_ID";
            parameter.Value = Auth.Instance().User_ID;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Supplier_ID";
            parameter.Value = supplierid;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Brand_ID";
            parameter.Value = brandid;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Purchase_Date";
            parameter.Value = purchaseDate;
            parameter.DbType = DbType.Date;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Modify_Date";
            parameter.Value = DateTime.Now;
            parameter.DbType = DbType.Date;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Rate";
            parameter.Value = rate;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Quantity";
            parameter.Value = qty;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Amount";
            parameter.Value = amount;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Diff_Amt";
            parameter.Value = diffAmount;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            return DataAccess.ExecuteNonQuery(command);
        }

        public int Update(long id, long supplierid, long brandid, DateTime purchaseDate, long rate, decimal qty, long amount, long diffAmount)
        {
            var command = DataAccess.CreateCommand(CommandType.Text);
            command.CommandText =
                "UPDATE Purchase SET Supplier_ID = @Supplier_ID, Brand_ID = @Brand_ID, Purchase_Date = @Purchase_Date, Modify_Date = @Modify_Date, Rate = @Rate, Quantity = @Quantity, Amount = @Amount, Diff_Amt = @Diff_Amt, Reserve1 = Reserve1 WHERE ID = @ID";


            var parameter = command.CreateParameter();
            parameter.ParameterName = "@ID";
            parameter.Value = id;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Supplier_ID";
            parameter.Value = supplierid;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Brand_ID";
            parameter.Value = brandid;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Purchase_Date";
            parameter.Value = purchaseDate;
            parameter.DbType = DbType.Date;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Modify_Date";
            parameter.Value = DateTime.Now;
            parameter.DbType = DbType.Date;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Rate";
            parameter.Value = rate;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Quantity";
            parameter.Value = qty;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Amount";
            parameter.Value = amount;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Diff_Amt";
            parameter.Value = diffAmount;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            return DataAccess.ExecuteNonQuery(command);
        }

        /// <summary>
        ///     Returns all the purchases in system
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllPurchases()
        {
            var command = DataAccess.CreateCommand(CommandType.Text);
            command.CommandText =
                "SELECT Purchase.ID, Supplier.FullName, Supplier_ID, Brands.Liq_Name, Brand_ID, Purchase_Date, Modify_Date, Rate, Quantity, Amount, Diff_Amt FROM Purchase join supplier on purchase.Supplier_ID = Supplier.ID join Brands on purchase.Brand_ID = Brands.ID";
            return DataAccess.ExecuteSelectCommand(command);
        }

        /// <summary>
        /// Returns purchase of selected id
        /// </summary>
        /// <param name="id">Purchase id</param>
        /// <returns>Purchase</returns>
        public DataTable GetPurchasesById(long id)
        {
            var command = DataAccess.CreateCommand(CommandType.Text);
            command.CommandText =
                "SELECT Purchase.ID, Supplier.FullName, Supplier_ID, Brands.Liq_Name, Brand_ID, Purchase_Date, Modify_Date, Rate, Quantity, Amount, Diff_Amt FROM Purchase join supplier on purchase.Supplier_ID = Supplier.ID join Brands on purchase.Brand_ID = Brands.ID where Purchase.ID = @id";

            var parameter = command.CreateParameter();
            parameter.ParameterName = "@id";
            parameter.Value = id;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            return DataAccess.ExecuteSelectCommand(command);
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="id">Purchase ID</param>
        /// <returns></returns>
        public int Delete(Int64 id)
        {
            var command = DataAccess.CreateCommand(CommandType.Text);
            command.CommandText =
                "DELETE FROM Purchase WHERE ID = @ID ";

            var parameter = command.CreateParameter();
            parameter.ParameterName = "@ID";
            parameter.Value = id;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            return DataAccess.ExecuteNonQuery(command);
        }

        public DataTable GetAllTypes()
        {
            return null;
        }
    }
}
