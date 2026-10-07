using System;
using System.Collections.Generic;
using System.Text;
using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;


namespace Selenium_Reqnrool.Hooks
{
    [Binding]
    class Broswer__SetUp
    {
        public static IWebDriver driver;

        [BeforeScenario]
        public void BeforeTest()
        {
            string broswer = Environment.GetEnvironmentVariable("BROWSER") ?? "edge";

            switch (broswer.ToLower())
            {
                case "chrome":
                    driver = new ChromeDriver();
                    break;

                case "firefox":
                    driver = new FirefoxDriver();
                    break;

                case "edge":
                    driver = new EdgeDriver();
                    break;

                default:
                    throw new ArgumentException($"Unsupported browser: {broswer}");
            }

            driver.Manage().Window.Maximize();

        }

        [AfterScenario]

        public void AfterTest(ScenarioContext scenarioContext)
        {
            if (scenarioContext.TestError != null)
            {
                string folderPath = Path.Combine(
                    TestContext.CurrentContext.WorkDirectory,
                    "Screenshots");

                Directory.CreateDirectory(folderPath);

                string fileName = scenarioContext.ScenarioInfo.Title
                    .Replace(" ", "_")
                    .Replace("/", "_")
                    + "_" +
                    DateTime.Now.ToString("yyyyMMdd_HHmmss")
                    + ".png";

                string filePath = Path.Combine(folderPath, fileName);

                Screenshot screenshot =
                    ((ITakesScreenshot)driver).GetScreenshot();

                screenshot.SaveAsFile(filePath);

                TestContext.WriteLine("Screenshot saved at: " + filePath);
            }


            driver.Quit();
        }
        
    
    }
}
