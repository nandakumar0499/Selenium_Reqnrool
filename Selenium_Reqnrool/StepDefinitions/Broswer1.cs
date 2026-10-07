using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using static Selenium_Reqnrool.Hooks.Broswer__SetUp;

namespace Selenium_Reqnrool.StepDefinitions
{

    [Binding]
    public class Broswer1
    {

        

        [Given("Navigate to the broswer")]
        public void GivenNavigateToTheBroswer()
        {
           
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
