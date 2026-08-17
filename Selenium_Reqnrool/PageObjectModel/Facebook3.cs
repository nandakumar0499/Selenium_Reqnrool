using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Selenium_Reqnrool.PageObjectModel
{
    public class Facebook3
    {

        private IWebDriver driver;


        public Facebook3(IWebDriver driver)
        {
            this.driver = driver;
        }

   
             By username = By.XPath("//input[@name=\"email\"]");

        public Facebook3 userinput(string text)
        {
            driver.FindElement(username).SendKeys(text);
            return this;
        }


        

    }
}
