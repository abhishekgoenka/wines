using System;
using System.Collections.Generic;
using System.Data;
using Wines.DataLayer.DataAccess;
using Wines.WinForm.Common;
using Wines.WinForm.Models;

namespace Wines.WinForm.BCL
{
    internal class Expenses
    {
        public int Add(long lngShopID, long lngUserID, System.DateTime dtExpDate, string strExp_Type, decimal lngExpAmt, string strDescription, string strReserve1)
        {
            var command = DataAccess.CreateCommand(CommandType.Text);
            command.CommandText =
                "INSERT INTO EXPENSES(Shop_ID, User_ID, EXP_Date, Modify_Date, EXP_TYPE, EXP_AMT, Description, Reserve1) " +
                "VALUES (@Shop_ID, @User_ID, @EXP_Date, @Modify_Date, @EXP_TYPE, @EXP_AMT, @Description, @Reserve1)";

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
            parameter.ParameterName = "@Exp_Date";
            parameter.Value = dtExpDate;
            parameter.DbType = DbType.DateTime;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Modify_Date";
            parameter.Value = System.DateTime.Today;
            parameter.DbType = DbType.DateTime;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Exp_Type";
            parameter.Value = strExp_Type;
            parameter.DbType = DbType.String;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Exp_AMT";
            parameter.Value = lngExpAmt;
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

        public int Update(long lngID, long lngShopID, long lngUserID, System.DateTime dtExpDate, 
                                    string strExp_Type, decimal lngExpAmt, string strDescription, string strReserve1)
        {
            var command = DataAccess.CreateCommand(CommandType.Text);
            command.CommandText =
                "UPDATE EXPENSES SET Shop_ID = @Shop_ID, User_ID = @User_ID, EXP_Date = @Exp_Date, Modify_Date = @Modify_Date, " +
                " EXP_TYPE = @Exp_Type, Exp_Amt = @Exp_Amt, Description = @Description, Reserve1 = @Reserve1 WHERE ID = @ID";

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
            parameter.ParameterName = "@Exp_Date";
            parameter.Value = dtExpDate;
            parameter.DbType = DbType.DateTime;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Modify_Date";
            parameter.Value = System.DateTime.Today;
            parameter.DbType = DbType.DateTime;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Exp_Type";
            parameter.Value = strExp_Type;
            parameter.DbType = DbType.String;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Exp_Amt";
            parameter.Value = lngExpAmt;
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
        public List<ExpensesModel> GetAllExpenses()
        {
            var command = DataAccess.CreateCommand(CommandType.Text);
            command.CommandText =
                "SELECT ID, Shop_ID, User_ID, Exp_Date, Modify_Date, Exp_Type, Exp_Amt, Description, Reserve1 FROM EXPENSES " +
                " ORDER BY Modify_Date;";
            return Helper.ConvertDataTable<ExpensesModel>(DataAccess.ExecuteSelectCommand(command));
        }

        /// <summary>
        ///     Returns all the Discounts in system
        /// </summary>
        /// <returns></returns>
        public long  GetDateRangeExpenses(System.DateTime dtStartExpDate, System.DateTime dtEndExpDate)
        {
            var command = DataAccess.CreateCommand(CommandType.Text);
            command.CommandText =
                    "SELECT SUM(Exp_Amt) AS Exp_Amt FROM EXPENSES " +
                    "where strftime('%Y-%m-%d', Exp_Date) BETWEEN @dtStartExpDate AND @dtEndExpDate";

            string strdate1 = dtStartExpDate.ToString("yyyy-MM-dd");
            string strdate2 = dtEndExpDate.ToString("yyyy-MM-dd");

            var parameter = command.CreateParameter();
            parameter.ParameterName = "@dtStartExpDate";
            parameter.Value = strdate1;
            parameter.DbType = DbType.String;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@dtEndExpDate";
            parameter.Value = strdate2;
            parameter.DbType = DbType.String;
            command.Parameters.Add(parameter);

            DataTable dt = DataAccess.ExecuteSelectCommand(command);
            long ExpAmtDuration= 0;
            if (  dt != null)
                if ( dt.Rows[0][0]!= System.DBNull.Value)
                    ExpAmtDuration = dt.Rows[0].Field<long>(0);

            return ExpAmtDuration;
        }

        /// <summary>
        ///     Returns all the Discounts in system
        /// </summary>
        /// <returns></returns>
        public long GetExpensesAmount()
        {
            var command = DataAccess.CreateCommand(CommandType.Text);
            command.CommandText =
                "SELECT sum(Exp_Amt) FROM EXPENSES";

            DataTable dt = DataAccess.ExecuteSelectCommand(command);
            long ExpAmtAll = 0;

            if (dt != null)
                if (dt.Rows[0][0] != System.DBNull.Value)
                    ExpAmtAll = dt.Rows[0].Field<long>(0);

            return ExpAmtAll;
        }


        /// <summary>
        /// Delete Branch
        /// </summary>
        /// <param name="id">Branch ID</param>
        /// <returns></returns>
        public int DeleteExpenses(Int64 lngID)
        {
            var command = DataAccess.CreateCommand(CommandType.Text);
            command.CommandText =
                "DELETE FROM EXPENSES WHERE ID = @ID ";

            var parameter = command.CreateParameter();
            parameter.ParameterName = "@ID";
            parameter.Value = lngID;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            return DataAccess.ExecuteNonQuery(command);
        }
    }
}