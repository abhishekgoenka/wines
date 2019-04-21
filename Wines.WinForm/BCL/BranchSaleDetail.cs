using System;
using System.Collections.Generic;
using System.Data;
using Wines.DataLayer.DataAccess;
using Wines.WinForm.Common;
using Wines.WinForm.Models;

namespace Wines.WinForm.BCL
{
    internal class BranchSaleDetail
    {
        /// <summary>
        ///     Add new Branch
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
        public int Add(long lngShopID, string strBranchName, string strAddress, bool bActive, 
                       string strMobileNo, decimal lngAdvance, string strReserve1)
        {
            var command = DataAccess.CreateCommand(CommandType.Text);
            command.CommandText =
                "INSERT INTO Branch (Shop_ID, Branch_Name, Address, Active, MobileNo, Advance, Reserve1) " +
                "VALUES (@Shop_ID, @Branch_Name, @Address, @Active, @MobileNo, @Advance, @Reserve1)";

            var parameter = command.CreateParameter();
            parameter.ParameterName = "@Shop_ID";
            parameter.Value = lngShopID;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Branch_Name";
            parameter.Value = strBranchName;
            parameter.DbType = DbType.String;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Address";
            parameter.Value = strAddress;
            parameter.DbType = DbType.String;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Active";
            parameter.Value = bActive;
            parameter.DbType = DbType.Boolean;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@MobileNo";
            parameter.Value = strMobileNo;
            parameter.DbType = DbType.String;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Advance";
            parameter.Value = lngAdvance;
            parameter.DbType = DbType.Int64;
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
        public int Update(long lngID, long lngShopID, string strBranchName, string strAddress, bool bActive,
                       string strMobileNo, decimal lngAdvance, string strReserve1)
        {
            var command = DataAccess.CreateCommand(CommandType.Text);
            command.CommandText =
                "UPDATE Branch SET Shop_ID = @Shop_ID, Branch_Name = @Branch_Name, Address = @Address, " +
                " Active = @Active, MobileNo = @MobileNo, Reserve1 = @Reserve1 WHERE ID = @ID";

            var parameter = command.CreateParameter();
            parameter.ParameterName = "@Shop_ID";
            parameter.Value = lngShopID;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Branch_Name";
            parameter.Value = strBranchName;
            parameter.DbType = DbType.String;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Address";
            parameter.Value = strAddress;
            parameter.DbType = DbType.String;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Active";
            parameter.Value = bActive;
            parameter.DbType = DbType.Boolean;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@MobileNo";
            parameter.Value = strMobileNo;
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
        ///     Returns all the Branchs in system
        /// </summary>
        /// <returns></returns>
        public List<BranchSaleDetailModel> GetAllBranchSaleDetail(long BranchID, long SaleSummaryID)
        {
            var command = DataAccess.CreateCommand(CommandType.Text);
            command.CommandText =
                "SELECT ID, Shop_ID, User_ID, Branch_ID, BS_Summary_ID, Sale_Date, Modify_Date, " +
                "Brand_ID, Quantity, Rate, Amount, Commission, Reserve1 FROM Branch_Sale_Detail WHERE 1=1;";

            if (BranchID != 0)
                command.CommandText = command.CommandText + " AND Branch_ID = " + BranchID ;

            if (SaleSummaryID != 0)
                command.CommandText = command.CommandText + " AND BS_Summary_ID = " + SaleSummaryID ;

            command.CommandText = command.CommandText + " Order By Modify_Date Desc;";

            return Helper.ConvertDataTable<BranchSaleDetailModel>(DataAccess.ExecuteSelectCommand(command));
        }

        /// <summary>
        /// Delete Branch
        /// </summary>
        /// <param name="id">Branch ID</param>
        /// <returns></returns>
        public int DeleteBranchSale(Int64 lngID)
        {
            var command = DataAccess.CreateCommand(CommandType.Text);
            command.CommandText =
                "DELETE FROM Branch WHERE ID = @ID ";

            var parameter = command.CreateParameter();
            parameter.ParameterName = "@ID";
            parameter.Value = lngID;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            return DataAccess.ExecuteNonQuery(command);
        }
    }
}