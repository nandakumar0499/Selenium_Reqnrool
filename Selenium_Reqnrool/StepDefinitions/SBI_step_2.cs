using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using Selenium_Reqnrool.PageObjectModel;
using static Selenium_Reqnrool.Hooks.Broswer__SetUp;
namespace Selenium_Reqnrool.StepDefinitions
{
    [Binding]
    public  class SBI_step_2
    {



        [Given("Navigate SBI  Url")]
        public void GivenNavigateSBIUrl()
        {
            driver.Navigate().GoToUrl("https://onlinesbi.sbi.bank.in/");
        }
        [When("Click on  creat new useer r")]
        public void WhenClickOnCreatNewUseerR()
        {
            
            SBI1_POM n = new SBI1_POM(driver);
            n.clickOnCreatNewUser();
            

        }

        [Then("Fill Forms")]
        public void ThenFillForms()
        {
            String parentWindow = driver.CurrentWindowHandle;
            foreach (string window in driver.WindowHandles)
            {
                if (window != parentWindow)
                {
                    driver.SwitchTo().Window(window);
                    break;
                }

            }
            Thread.Sleep(10000);
            driver.FindElement(By.XPath("/html/body/app-root/app-registration/main/div/div[3]/app-new-user-registration/div/div/div[2]/div/div[1]/dff-icon-card/div/div")).Click();
            Thread.Sleep(5000);
            driver.Close();


            driver.SwitchTo().Window(parentWindow);

           string kk = driver.FindElement(By.XPath("(//div[@class=\"col\"])[1]")).Text;

            Console.WriteLine(kk);
            Console.WriteLine("Form is filled");


        }



    }
}
