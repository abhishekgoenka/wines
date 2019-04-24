using System;
using System.Collections.Generic;
using System.Data;
using Wines.DataLayer.DataAccess;
using Wines.WinForm.Common;
using Wines.WinForm.Models;

namespace Wines.WinForm.BCL
{
    internal class BranchSale
    {
        public int Add(long lngShop_ID, long lngUser_ID, long lngBranch_ID,
            System.DateTime dtSale_Date, System.DateTime dtModify_Date, long lngPrevious_Amt,
            long lngSale_Amt_With_Comm, long lngCommission_Amt, long lngSale_Amt_After_Comm,
            long lngDeposit, long lngBalance, string strReserve1)
        {
            var command = DataAccess.CreateCommand(CommandType.Text);
            command.CommandText =
                "INSERT INTO Branch_Sale_Summary(Shop_ID, User_ID, Branch_ID, Sale_Date, Modify_Date, Previous_Amt," +
                " Sale_Amt_With_Comm, Commission_Amt, Sale_Amt_After_Comm, Deposit, Balance, Reserve1) " +
                " VALUES (@Shop_ID, @User_ID, @Branch_ID, @Sale_Date, @Modify_Date, @Previous_Amt," +
                " @Sale_Amt_With_Comm, @Commission_Amt, @Sale_Amt_After_Comm, @Deposit, @Balance, @Reserve1)";

            var parameter = command.CreateParameter();
            parameter.ParameterName = "@Shop_ID";
            parameter.Value = lngShop_ID;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@User_ID";
            parameter.Value = lngUser_ID;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Branch_ID";
            parameter.Value = lngBranch_ID;
            parameter.DbType = DbType.String;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Sale_Date";
            parameter.Value = dtSale_Date;
            parameter.DbType = DbType.Date;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Modify_Date";
            parameter.Value = DateTime.Today;
            parameter.DbType = DbType.String;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Previous_Amt";
            parameter.Value = lngPrevious_Amt;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Sale_Amt_With_Comm";
            parameter.Value = lngSale_Amt_With_Comm;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Commission_Amt";
            parameter.Value = lngCommission_Amt;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Sale_Amt_After_Comm";
            parameter.Value = lngSale_Amt_After_Comm;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Deposit";
            parameter.Value = lngDeposit;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Balance";
            parameter.Value = lngBalance;
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

        public int Update(long lngID, long lngShop_ID, long lngUser_ID, long lngBranch_ID, 
            System.DateTime dtSale_Date, System.DateTime dtModify_Date,  long lngPrevious_Amt, 
            long lngSale_Amt_With_Comm, long lngCommission_Amt, long lngSale_Amt_After_Comm, 
            long lngDeposit, long lngBalance, string strReserve1)
        {
            var command = DataAccess.CreateCommand(CommandType.Text);
            command.CommandText =
                "UPDATE Branch_Sale_Summary SET Shop_ID = @Shop_ID, User_ID= @User_ID, Branch_ID= @Branch_ID, " +
                " Sale_Date= @Sale_Date, Modify_Date= @Modify_Date, Previous_Amt=@Previous_Amt " +
                " Sale_Amt_With_Comm=@Sale_Amt_With_Comm, Commission_Amt=@Commission_Amt, Sale_Amt_After_Comm=@Sale_Amt_After_Comm " +
                " Deposit=@Deposit, Balance=@Balance, Reserve1=@Reserve1 " +
                " WHERE ID = @ID";

            var parameter = command.CreateParameter();
            parameter.ParameterName = "@Shop_ID";
            parameter.Value = lngShop_ID;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@User_ID";
            parameter.Value = lngUser_ID;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Branch_ID";
            parameter.Value = lngBranch_ID;
            parameter.DbType = DbType.String;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Sale_Date";
            parameter.Value = dtSale_Date;
            parameter.DbType = DbType.Date;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Modify_Date";
            parameter.Value = DateTime.Today;
            parameter.DbType = DbType.String;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Previous_Amt";
            parameter.Value = lngPrevious_Amt;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Sale_Amt_With_Comm";
            parameter.Value = lngSale_Amt_With_Comm;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Commission_Amt";
            parameter.Value = lngCommission_Amt;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Sale_Amt_After_Comm";
            parameter.Value = lngSale_Amt_After_Comm;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Deposit";
            parameter.Value = lngDeposit;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Balance";
            parameter.Value = lngBalance;
            parameter.DbType = DbType.Int64;
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
        public List<BranchSaleModel> GetAllBranchSales(long lngBranch_ID)
        {
            var command = DataAccess.CreateCommand(CommandType.Text);
            command.CommandText =
                "SELECT ID, Shop_ID, Branch_ID, Sale_Date, Modify_Date," +
                "Previous_Amt, Sale_Amt_With_Comm, Commission_Amt, Sale_Amt_After_Comm, " +
                "Deposit, Balance, Reserve1 FROM Branch_Sale_Summary";

            if (lngBranch_ID != 0)
                command.CommandText = command.CommandText + " WHERE Branch_ID = " + lngBranch_ID + " Order By Modify_Date Desc";
            else
                command.CommandText = command.CommandText + " WHERE Order By Modify_Date Desc";

            return Helper.ConvertDataTable<BranchSaleModel>(DataAccess.ExecuteSelectCommand(command));
        }

        public List<BranchSaleModel> GetLastSavedRecord()
        {
            var command = DataAccess.CreateCommand(CommandType.Text);
            command.CommandText =
                "SELECT ID, Shop_ID, Branch_ID, Sale_Date, Modify_Date, " +
                "Previous_Amt, Sale_Amt_With_Comm, Commission_Amt, Sale_Amt_After_Comm, " +
                "Deposit, Balance, Reserve1 FROM Branch_Sale_Summary";

            //command.CommandText =
            //    "SELECT ID, Shop_ID, Branch_ID, Sale_Date, Modify_Date, " +
            //    "Previous_Amt, Sale_Amt_With_Comm, Commission_Amt, Sale_Amt_After_Comm, " +
            //    "Deposit, Balance, Reserve1 FROM Branch_Sale_Summary ";
//            command.CommandText += " WHERE 1=1 ORDER BY ID DESC";

            return Helper.ConvertDataTable<BranchSaleModel>(DataAccess.ExecuteSelectCommand(command));
        }

        /// <summary>
        /// Delete Branch Sale
        /// </summary>
        /// <param name="id">Branch Sale ID</param>
        /// <returns></returns>
        public int DeleteBranchSale(Int64 lngID)
        {
            var command = DataAccess.CreateCommand(CommandType.Text);
            command.CommandText =
                "DELETE FROM Branch_Sale_Summary WHERE ID = @ID ";

            var parameter = command.CreateParameter();
            parameter.ParameterName = "@ID";
            parameter.Value = lngID;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            return DataAccess.ExecuteNonQuery(command);
        }
    }
}