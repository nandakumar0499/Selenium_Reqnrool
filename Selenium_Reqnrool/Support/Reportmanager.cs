using System;
using System.Collections.Generic;
using System.Text;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace Selenium_Reqnrool.Support
{
    public  class Reportmanager
    {
        private static ExtentReports extent;
        private static ExtentTest test;

        public static void StartReport()
        {
            string reportFolder = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "TestResults");

            Directory.CreateDirectory(reportFolder);

            string reportPath = Path.Combine(
                reportFolder,
                "ExtentReport.html");

            var sparkReporter =
                new ExtentSparkReporter(reportPath);

            extent = new ExtentReports();

            extent.AttachReporter(sparkReporter);

            extent.AddSystemInfo("Project", "Selenium_Reqnroll");
            extent.AddSystemInfo("Environment", "QA");
            extent.AddSystemInfo("Browser", "Chrome");
        }

        public static void StartTest(string testName)
        {
            test = extent.CreateTest(testName);
        }

        public static void Pass(string message)
        {
            test.Pass(message);
        }

        public static void Fail(string message)
        {
            test.Fail(message);
        }

        public static void Info(string message)
        {
            test.Info(message);
        }

        public static void EndReport()
        {
            extent.Flush();

            Console.WriteLine("Report generated successfully.");
        }
    }
}
