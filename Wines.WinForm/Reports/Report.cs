using System.Data;
using System.Diagnostics;
using System.IO;
using NLog;

namespace Wines.WinForm.Reports
{
    internal class Report
    {
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        ///     Show all user report
        /// </summary>
        /// <param name="users">User list</param>
        public void ShowAllUsers(DataTable users)
        {
            var content = string.Empty;
            foreach (DataRow user in users.Rows)
            {
                // Open TR
                content += "<tr>";

                // ID
                content += $"<td>{user.ItemArray[0]}</td>";

                // FullName
                content += $"<td>{user.ItemArray[1]}</td>";

                // Username
                content += $"<td>{user.ItemArray[2]}</td>";

                // Active
                content += $"<td>{user.ItemArray[3]}</td>";

                // PurchaseRight
                content += $"<td>{user.ItemArray[4]}</td>";

                // GeneratePurchase
                content += $"<td>{user.ItemArray[5]}</td>";

                // DailySale
                content += $"<td>{user.ItemArray[5]}</td>";

                // Stock
                content += $"<td>{user.ItemArray[7]}</td>";


                // close TR
                content += "</tr>";
            }

            GenerateReport(ReportType.Users, content);
        }

        /// <summary>
        ///     Generate html report
        /// </summary>
        /// <param name="type">Report Type</param>
        /// <param name="content">Content</param>
        private void GenerateReport(ReportType type, string content)
        {
            var file = ReportHelper.CopyReportTemplate(type);

            //replace content
            var fileContent = File.ReadAllText(file);
            fileContent = fileContent.Replace("@content@", content);

            File.WriteAllText(file, fileContent);

            OpenHTMLReport(file);
            _logger.Debug($"Report {type}, File {file}");
        }

        /// <summary>
        ///     Open html file in default browser
        /// </summary>
        /// <param name="file">File path</param>
        private void OpenHTMLReport(string file)
        {
            var startInfo = new ProcessStartInfo(file);
            startInfo.WindowStyle = ProcessWindowStyle.Maximized;
            Process.Start(startInfo);
        }
    }
}