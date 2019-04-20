using System;
using System.Collections.Generic;
using System.Data;
using Wines.DataLayer.DataAccess;
using Wines.WinForm.Common;
using Wines.WinForm.Models;

namespace Wines.WinForm.BCL
{
    internal class CounterDiscount
    {
        /// <summary>
        ///     Add new Branch
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="Shop_ID"></param>
        /// <param name="User_ID"></param>
        /// <param name="Discount_Date"></param>
        /// <param name="Modify_Date"></param>
        /// <param name="Discount_Amt"></param>
        /// <param name="Description"></param>
        /// <param name="reserve1"></param>
        /// <returns></returns>
        public int Add(long lngShopID, long lngUserID, System.DateTime dtDiscountDate, decimal DiscountAmt, string strDescription, string strReserve1)
        {
            var command = DataAccess.CreateCommand(CommandType.Text);
            command.CommandText =
                "INSERT INTO Counter_Discount (Shop_ID, User_ID, Discount_Date, Modify_Date, Discount_Amt, Description, Reserve1) " +
                "VALUES (@Shop_ID, @User_ID, @Discount_Date, @Modify_Date, @Discount_Amt, @Description, @Reserve1)";

            var parameter = command.CreateParameter();
            parameter.ParameterName = "@Shop_ID";
            parameter.Value = lngShopID;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@User_ID";
            parameter.Value = lngUserID;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Discount_Date";
            parameter.Value = dtDiscountDate;
            parameter.DbType = DbType.DateTime;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Modify_Date";
            parameter.Value = System.DateTime.Today;
            parameter.DbType = DbType.DateTime;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Discount_Amt";
            parameter.Value = DiscountAmt;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Description";
            parameter.Value = strDescription;
            parameter.DbType = DbType.String;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Reserve1";
            parameter.Value = strReserve1;
            parameter.DbType = DbType.String;
            command.Parameters.Add(parameter);

            int retVal = DataAccess.ExecuteNonQuery(command);
            return retVal;
        }

        /// <summary>
        /// Update Branch
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="Shop_ID"></param>
        /// <param name="Branch_Name"></param>
        /// <param name="Box"></param>
        /// <param name="Address"></param>
        /// <param name="Active"></param>
        /// <param name="MobileNo"></param>
        /// <param name="Advance"></param>
        /// <param name="reserve1"></param>
        /// <returns></returns>
        public int Update(long lngID, long lngShopID, long lngUserID, System.DateTime dtDiscountDate, 
                                        decimal DiscountAmt, string strDescription, string strReserve1)
        {
            var command = DataAccess.CreateCommand(CommandType.Text);
            command.CommandText =
                "UPDATE Counter_Discount SET Shop_ID = @Shop_ID, User_ID = @User_ID, Discount_Date = @Discount_Date, Modify_Date = @Modify_Date, " +
                " Discount_Amt = @Discount_Amt, Description = @Description, Reserve1 = @Reserve1 WHERE ID = @ID";

            var parameter = command.CreateParameter();
            parameter.ParameterName = "@Shop_ID";
            parameter.Value = lngShopID;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@User_ID";
            parameter.Value = lngUserID;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Discount_Date";
            parameter.Value = dtDiscountDate;
            parameter.DbType = DbType.DateTime;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Modify_Date";
            parameter.Value = System.DateTime.Today;
            parameter.DbType = DbType.DateTime;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Discount_Amt";
            parameter.Value = DiscountAmt;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Description";
            parameter.Value = strDescription;
            parameter.DbType = DbType.String;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Reserve1";
            parameter.Value = strReserve1;
            parameter.DbType = DbType.String;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@ID";
            parameter.Value = lngID;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            return DataAccess.ExecuteNonQuery(command);
        }

        /// <summary>
        ///     Returns all the Discounts in system
        /// </summary>
        /// <returns></returns>
        public List<CounterDiscountModel> GetAllCounterDiscounts()
        {
            var command = DataAccess.CreateCommand(CommandType.Text);
            command.CommandText =
                "SELECT ID, Shop_ID, User_ID, Discount_Date, Modify_Date, Discount_Amt, Description, Reserve1 FROM Counter_Discount " +
                " ORDER BY Modify_Date;";
            return Helper.ConvertDataTable<CounterDiscountModel>(DataAccess.ExecuteSelectCommand(command));
        }

        /// <summary>
        /// Delete Branch
        /// </summary>
        /// <param name="id">Branch ID</param>
        /// <returns></returns>
        public int DeleteBranch(Int64 lngID)
        {
            var command = DataAccess.CreateCommand(CommandType.Text);
            command.CommandText =
                "DELETE FROM Counter_Discount WHERE ID = @ID ";

            var parameter = command.CreateParameter();
            parameter.ParameterName = "@ID";
            parameter.Value = lngID;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            return DataAccess.ExecuteNonQuery(command);
        }
    }
}