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
        public int Add(long lngShop_ID, long lngUser_ID, long lngBranch_ID, long lngBS_Summary_ID,
            DateTime dtSale_Date, DateTime dtModify_Date, string strCategory, 
            long lngBrand_ID, string strBrand_Name, long lngBrand_Size, 
            long lngQuantity, long lngRate, long lngAmount, long lngCommission, string strReserve1)
        {
            var command = DataAccess.CreateCommand(CommandType.Text);
            command.CommandText =
                "INSERT INTO Branch_Sale_Detail (Shop_ID, User_ID, Branch_ID, BS_Summary_ID, Sale_Date, Modify_Date," +
                " Category, Brand_ID, Brand_Name, Brand_Size, Quantity, Rate, Amount, Commission, Reserve1) " +
                "VALUES (@Shop_ID, @User_ID, @Branch_ID, @BS_Summary_ID, @Sale_Date, @Modify_Date," +
                " @Category, @Brand_ID, @Brand_Name, @Brand_Size, @Quantity, @Rate, @Amount, @Commission, @Reserve1)";

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
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@BS_Summary_ID";
            parameter.Value = lngBS_Summary_ID;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Sale_Date";
            parameter.Value = dtSale_Date;
            parameter.DbType = DbType.Date;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Modify_Date";
            parameter.Value = dtModify_Date;
            parameter.DbType = DbType.Date;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Category";
            parameter.Value = strCategory;
            parameter.DbType = DbType.String;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Brand_ID";
            parameter.Value = lngBrand_ID;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Brand_Name";
            parameter.Value = strBrand_Name;
            parameter.DbType = DbType.String;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Brand_Size";
            parameter.Value = lngBrand_Size;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Quantity";
            parameter.Value = lngQuantity;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Rate";
            parameter.Value = lngRate;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Amount";
            parameter.Value = lngAmount;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Commission";
            parameter.Value = lngCommission;
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


        public int Update(long lngID, long lngShop_ID, long lngUser_ID, long lngBranch_ID, long lngBS_Summary_ID,
                        DateTime dtSale_Date, DateTime dtModify_Date, string strCategory, 
                        long lngBrand_ID, string strBrand_Name, long lngBrand_Size,
                        long lngQuantity, long lngRate, long lngAmount, long lngCommission, string strReserve1)
        {
            var command = DataAccess.CreateCommand(CommandType.Text);
            command.CommandText =
                "UPDATE Branch_Sale_Detail SET Shop_ID=@Shop_ID, User_ID=User_ID, Branch_ID=@Branch_ID, BS_Summary_ID=@BS_Summary_ID," +
                " Sale_Date=@Sale_Date, Modify_Date=@Modify_Date, Category=@Category, " +
                " Brand_ID=@Brand_ID, Brand_Name=@Brand_Name, Brand_Size=@Brand_Size" +
                "Quantity=@Quantity, Rate=@Rate, Amount=@Amount, Commission=@Commission, Reserve1=@Reserve1  WHERE ID = @ID ";

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
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@BS_Summary_ID";
            parameter.Value = lngBS_Summary_ID;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Sale_Date";
            parameter.Value = dtSale_Date;
            parameter.DbType = DbType.Date;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Modify_Date";
            parameter.Value = dtModify_Date;
            parameter.DbType = DbType.Date;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Category";
            parameter.Value = strCategory;
            parameter.DbType = DbType.String;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Brand_ID";
            parameter.Value = lngBrand_ID;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Brand_Name";
            parameter.Value = strBrand_Name;
            parameter.DbType = DbType.String;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Brand_Size";
            parameter.Value = lngBrand_Size;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Quantity";
            parameter.Value = lngQuantity;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Rate";
            parameter.Value = lngRate;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Amount";
            parameter.Value = lngAmount;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Commission";
            parameter.Value = lngCommission;
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

            int retVal = DataAccess.ExecuteNonQuery(command);
            return retVal;
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
                "Category, Brand_ID, Brand_Name, Brand_Size, Quantity, Rate, Amount, Commission, Reserve1 " +
                " FROM Branch_Sale_Detail WHERE 1=1 ";

            if (BranchID != 0)
                command.CommandText = command.CommandText + " AND Branch_ID = " + BranchID ;

            if (SaleSummaryID != 0)
                command.CommandText = command.CommandText + " AND BS_Summary_ID = " + SaleSummaryID ;

            command.CommandText = command.CommandText + " Order By Modify_Date Desc;";

            return Helper.ConvertDataTable<BranchSaleDetailModel>(DataAccess.ExecuteSelectCommand(command));
        }

    }
}