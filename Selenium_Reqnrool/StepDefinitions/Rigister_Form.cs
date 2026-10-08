using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_Reqnrool.StepDefinitions
{
    [Binding]
    class Rigister_Form
    {

        IWebDriver driver;

        [Given("Open WebApplication Url")]
        public void GivenOpenWebApplicationUrl()
        {
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://testautomationpractice.blogspot.com/");
        }

        [When("Enter name and deatiles and  click on submit button")]
        public void WhenEnterNameAndDeatilesAndClickOnSubmitButton()
        {
            driver.FindElement(By.Id("name")).SendKeys("nanda");
            driver.FindElement(By.Id("email")).SendKeys("aaaa");

        }

        [Then("Click optin we need to perform the action")]
        public void ThenClickOptinWeNeedToPerformTheAction()
        {
            IWebElement aa = driver.FindElement(By.XPath("//input[contains(@id,\"monday\")]"));
            aa.Click();

            if (aa.Displayed)
            {
                Console.WriteLine("Element is displayed");

            }
            else
            {
                Console.WriteLine("Element is not displayed");

            }

            string name = driver.FindElement(By.Id("name")).Text;
            Console.WriteLine("Name: " + name);
            Thread.Sleep(3000);

            driver.FindElement(By.Id("name")).Clear();

        }
    }
}
