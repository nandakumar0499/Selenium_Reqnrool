using System;
using System.Collections.Generic;
using System.Text;
using static Selenium_Reqnrool.Hooks.Broswer__SetUp;
using Selenium_Reqnrool.PageObjectModel;
using OpenQA.Selenium;
namespace Selenium_Reqnrool.StepDefinitions
{
    [Binding]
    public  class SBI1Step
    {

        [Given("Open Url")]
        public void GivenOpenUrl()
        {
            driver.Navigate().GoToUrl("https://onlinesbi.sbi.bank.in/");
        }

        [When("Verify the logo")]
        public void WhenVerifyTheLogo()
        {
            SBI1_POM sbi1POM = new SBI1_POM(driver);
            sbi1POM.verifyLogo();
            if(sbi1POM.verifyLogo() == true)
            {
                Console.WriteLine("Logo is displayed");
            }
            else
            {
                Console.WriteLine("Logo is not displayed");
            }
        }

        [Then("Verify the Title")]
        public void ThenVerifyTheTitle()
        {
            bool result = new SBI1_POM(driver).verifyTitle("State Bank of India");
            if (result == true)
            {
                Console.WriteLine("Title is correct");
            }
            else
            {
                Console.WriteLine("Title is incorrect");
            }
        }

        [Then("click on creat new user..")]
        public void ThenClickOnCreatNewUser_()
        {
           SBI1_POM s = new SBI1_POM(driver);
            s.clickOnCreatNewUser();

        }

    }
}
