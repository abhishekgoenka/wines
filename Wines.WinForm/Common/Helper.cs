using System;
using System.Collections.Generic;
using System.Data;

namespace Wines.WinForm.Common
{
    internal class Helper
    {
        /// <summary>
        ///     converts data table to object
        /// </summary>
        /// <typeparam name="T">Object</typeparam>
        /// <param name="dt">DataTable</param>
        /// <returns>List of objects</returns>
        public static List<T> ConvertDataTable<T>(DataTable dt)
        {
            var data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                var item = GetItem<T>(row);
                data.Add(item);
            }

            return data;
        }

        /// <summary>
        ///     Get data row item
        /// </summary>
        /// <typeparam name="T">column id</typeparam>
        /// <param name="dr">Data row</param>
        /// <returns>value</returns>
        private static T GetItem<T>(DataRow dr)
        {
            var temp = typeof(T);
            var obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (var pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                    {
                        if (dr[column.ColumnName] != System.DBNull.Value)
                            pro.SetValue(obj, dr[column.ColumnName], null);
                    }
                }
            }

            return obj;
        }
    }
}