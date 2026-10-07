using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Selenium_Reqnrool.PageObjectModel
{
    public  class SBI1_POM
    {
        private IWebDriver driver;
        public SBI1_POM(IWebDriver driver)
        {
            this.driver = driver;
        }

        By logo = By.XPath("//a[@id=\"logo\"]");

        By title = By.XPath("//title[contains(text(),'State Bank of India')]");

        By button = By.XPath("//span[text()=\"New User Registration / Activation\"]");
        public bool verifyLogo()
        {
         return driver.FindElement(logo).Displayed;
            Console.WriteLine(driver.FindElement(logo).Displayed);

        }

        public bool verifyTitle( string expectedTitle)
        {
           
            
            if(driver.FindElement(title).Text.Equals(expectedTitle))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void clickOnCreatNewUser()
        {
            driver.FindElement(button).Click();
            
        }

    }
}
