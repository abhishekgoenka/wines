using System;
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
        /// Update Brand
        /// </summary>
        /// <param name="id"></param>
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
        public int Update(long id, long shopid, string category, string liq_Name, decimal Box, decimal weight,
            decimal purchase_Rate,
            decimal sale_Rate, decimal branch_Commision, string reserve1)
        {
            var command = DataAccess.CreateCommand(CommandType.Text);
            command.CommandText =
                "UPDATE Brands SET ID = @ID, Shop_ID = @Shop_ID, Category = @Category, Liq_Name = @Liq_Name, Box = @Box, Weight = @Weight, Purchase_Rate = @Purchase_Rate, Sale_Rate = @Sale_Rate, Branch_Commision = @Branch_Commision, Reserve1 = @Reserve1 WHERE ID = @ID";

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

            parameter = command.CreateParameter();
            parameter.ParameterName = "@ID";
            parameter.Value = id;
            parameter.DbType = DbType.Int64;
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
                "SELECT ID, Shop_ID, Category, Liq_Name, Box, Weight, Purchase_Rate, Sale_Rate, Branch_Commision, Reserve1 FROM Brands;";
            return Helper.ConvertDataTable<BrandModel>(DataAccess.ExecuteSelectCommand(command));
        }

        public List<BrandModel> GetUniueqBrandName(string strLiqType)
        {
            var command = DataAccess.CreateCommand(CommandType.Text);
            command.CommandText =
                "SELECT ID, Shop_ID, Category, Liq_Name, Box, Weight, Purchase_Rate, Sale_Rate, Branch_Commision, Reserve1 FROM Brands WHERE 1=1 ";
            if ( strLiqType.Length != 0)
                command.CommandText += " AND UPPER(Category)='" + strLiqType.ToUpper() + "' ";

            command.CommandText += " GROUP BY UPPER(Liq_Name) ";
            command.CommandText += " ORDER BY UPPER(Liq_Name) ";

            return Helper.ConvertDataTable<BrandModel>(DataAccess.ExecuteSelectCommand(command));
        }

        public List<BrandModel> GetUniueqBrandSize(string strLiqType, string strBrandName)
        {
            var command = DataAccess.CreateCommand(CommandType.Text);
            command.CommandText =
                "SELECT ID, Shop_ID, Category, Liq_Name, Box, Weight, Purchase_Rate, Sale_Rate, Branch_Commision, Reserve1 FROM Brands WHERE 1=1 ";
            if (strLiqType.Length != 0)
                command.CommandText += " AND UPPER(Category)='" + strLiqType.ToUpper() + "' ";

            if (strBrandName.Length != 0)
                command.CommandText += " AND UPPER(Liq_Name)='" + strBrandName.ToUpper() + "' ";

            command.CommandText += " GROUP BY UPPER(Weight) ";
            command.CommandText += " ORDER BY UPPER(Weight) ";

            return Helper.ConvertDataTable<BrandModel>(DataAccess.ExecuteSelectCommand(command));
        }

        public List<BrandModel> GetBrandDetail(string strLiqType, string strBrandName, long lngWeight )
        {
            var command = DataAccess.CreateCommand(CommandType.Text);
            command.CommandText =
                "SELECT ID, Shop_ID, Category, Liq_Name, Box, Weight, Purchase_Rate, Sale_Rate, Branch_Commision, Reserve1 FROM Brands WHERE 1=1 ";
            if (strLiqType.Length != 0)
                command.CommandText += " AND UPPER(Category)='" + strLiqType.ToUpper() + "' ";

            if (strBrandName.Length != 0)
                command.CommandText += " AND UPPER(Liq_Name)='" + strBrandName.ToUpper() + "' ";

            if (lngWeight != 0)
                command.CommandText += " AND Weight =" + lngWeight;
            
            command.CommandText += " GROUP BY UPPER(Weight) ";
            command.CommandText += " ORDER BY UPPER(Weight) ";

            DataTable dt = DataAccess.ExecuteSelectCommand(command);

            return Helper.ConvertDataTable<BrandModel>(dt);
        }
        public List<BrandModel> GetBrandDetail( long lngID)
        {
            var command = DataAccess.CreateCommand(CommandType.Text);
            command.CommandText =
                "SELECT ID, Shop_ID, Category, Liq_Name, Box, Weight, " +
                    "Purchase_Rate, Sale_Rate, Branch_Commision, Reserve1 FROM Brands" +
                    " WHERE ID = " + lngID;

            DataTable dt = DataAccess.ExecuteSelectCommand(command);

            return Helper.ConvertDataTable<BrandModel>(dt);
        }



        /// <summary>
        /// Delete Brand
        /// </summary>
        /// <param name="id">Brand ID</param>
        /// <returns></returns>
        public int DeleteBrand(Int64 id)
        {
            var command = DataAccess.CreateCommand(CommandType.Text);
            command.CommandText =
                "DELETE FROM Brands WHERE ID = @ID ";

            var parameter = command.CreateParameter();
            parameter.ParameterName = "@ID";
            parameter.Value = id;
            parameter.DbType = DbType.Int64;
            command.Parameters.Add(parameter);

            return DataAccess.ExecuteNonQuery(command);
        }

        /// <summary>
        /// Returns all categories of brand
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllCategories()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Key");

            DataRow dr = dt.NewRow();
            dr["Name"] = "IMFL";
            dr["Key"] = "IMFL";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Name"] = "CL (Countery Liquore)";
            dr["Key"] = "CL";
            dt.Rows.Add(dr);

            return dt;
        }
    }
}