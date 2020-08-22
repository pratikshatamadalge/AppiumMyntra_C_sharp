using System;
using System.Collections.Generic;
using System.Text;

namespace MyntraAutomation.ExtentReport
{
    using AventStack.ExtentReports;
    using AventStack.ExtentReports.Reporter;

    class ReportManager
    {
        private static ExtentReports extent;
        private static ExtentHtmlReporter htmlReporter;

        /// <summary>
        /// To get instance of extent report.
        /// </summary>
        /// <returns> extent class object.</returns>
        public static ExtentReports GetInstance()
        {
            if (extent == null)
            {
                string reportPath = @"F:\VS\MobileAutomation\Demo\ExtentReport\index.html";
                htmlReporter = new ExtentHtmlReporter(reportPath);
                extent = new ExtentReports();
                extent.AttachReporter(htmlReporter);
            }
            return extent;
        }
    }
}
