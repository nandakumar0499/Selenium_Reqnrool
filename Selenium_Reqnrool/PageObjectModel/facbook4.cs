using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Selenium_Reqnrool.PageObjectModel
{
    public  class facbook4
    {

        private IWebDriver driver;

        public facbook4(IWebDriver driver)
        {
            this.driver = driver;
        }


        By password = By.XPath("//input[@name=\"pass\"]");


        public facbook4 pass (string text)
        {

            driver.FindElement(password).SendKeys(text);
            return this;    


        }


    }
}
