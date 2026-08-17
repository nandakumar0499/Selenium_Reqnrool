using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_Reqnrool.StepDefinitions
{

    [Binding]
    public class Broswer1
    {

        private IWebDriver driver;

        [Given("Navigate to the broswer")]
        public void GivenNavigateToTheBroswer()
        {
            driver = new ChromeDriver();
        }

        [When("Open The Url")]
        public void WhenOpenTheUrl()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
        }

        [Then("Click Button")]
        public void ThenClickButton()
        {
           driver.FindElement(By.XPath("//textarea[@name=\"q\"]")).SendKeys("jr NTR");
        }

    }
}
