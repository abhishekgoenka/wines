using System.Collections.Generic;
using System.Data;
using Wines.DataLayer.DataAccess;
using Wines.WinForm.Common;
using Wines.WinForm.Models;

namespace Wines.WinForm.BCL
{
    internal class Brand
    {
        /// <summary>
        ///     Add new brand
        /// </summary>
        /// <param name="shopid"></param>
        /// <param name="category"></param>
        /// <param name="liq_Name"></param>
        /// <param name="Box"></param>
        /// <param name="weight"></param>
        /// <param name="purchase_Rate"></param>
        /// <param name="sale_Rate"></param>
        /// <param name="branch_Commision"></param>
        /// <param name="reserve1"></param>
        /// <returns></returns>
        public int Add(long shopid, string category, string liq_Name, decimal Box, decimal weight,
            decimal purchase_Rate,
            decimal sale_Rate, decimal branch_Commision, string reserve1)
        {
            var command = DataAccess.CreateCommand(CommandType.Text);
            command.CommandText =
                "INSERT INTO Brands (Shop_ID, Category, Liq_Name, Box, Weight, Purchase_Rate, Sale_Rate, Branch_Commision, Reserve1) VALUES (@Shop_ID, @Category, @Liq_Name, @Box, @Weight, @Purchase_Rate, @Sale_Rate, @Branch_Commision,@Reserve1)";

            var parameter = command.CreateParameter();
            parameter.ParameterName = "@Shop_ID";
            parameter.Value = shopid;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Category";
            parameter.Value = category;
            parameter.DbType = DbType.String;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Liq_Name";
            parameter.Value = liq_Name;
            parameter.DbType = DbType.String;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Box";
            parameter.Value = Box;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Weight";
            parameter.Value = weight;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Purchase_Rate";
            parameter.Value = purchase_Rate;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Sale_Rate";
            parameter.Value = sale_Rate;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Branch_Commision";
            parameter.Value = branch_Commision;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@Reserve1";
            parameter.Value = reserve1;
            parameter.DbType = DbType.String;
            command.Parameters.Add(parameter);

            return DataAccess.ExecuteNonQuery(command);
        }


        /// <summary>
        ///     Returns all the brands in system
        /// </summary>
        /// <returns></returns>
        public List<BrandModel> GetAllBrands()
        {
            var command = DataAccess.CreateCommand(CommandType.Text);
            command.CommandText =
                "SELECT Shop_ID, Category, Liq_Name, Box, Weight, Purchase_Rate, Sale_Rate, Branch_Commision, Reserve1 FROM Brands;";
            return Helper.ConvertDataTable<BrandModel>(DataAccess.ExecuteSelectCommand(command));
        }
    }
}