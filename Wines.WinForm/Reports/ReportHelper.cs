using System;
using System.IO;
using System.Linq;
using System.Net;

namespace Wines.WinForm.Reports
{
    internal static class ReportHelper
    {
        private static readonly Random random = new Random();

        /// <summary>
        /// Copies report template to temporary location
        /// </summary>
        /// <param name="type">Report Type</param>
        /// <returns>Temporary file path</returns>
        public static string CopyReportTemplate(ReportType type)
        {
            string target = $"temp\\{RandomString(8)}.html" ;
            string source = string.Empty;
            switch (type)
            {
                case ReportType.Users:
                    source = "Reports\\Templates\\users.html";
                    break;
                default:
                    throw new NotImplementedException();
            }

            if (!Directory.Exists("Temp"))
            {
                Directory.CreateDirectory("Temp");
            }

            File.Copy(source, target);
            return target;
        }

        /// <summary>
        /// Generate random string
        /// </summary>
        /// <param name="length">Length</param>
        /// <returns>string</returns>
        private static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}