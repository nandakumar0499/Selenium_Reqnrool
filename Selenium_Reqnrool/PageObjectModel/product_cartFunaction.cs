using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Selenium_Reqnrool.PageObjectModel
{
    public  class product_cartFunaction
    {

        private IWebDriver driver;



        public product_cartFunaction(IWebDriver driver)
        {
            this.driver = driver;
        }

         By search = By.XPath("(//input[@name=\"q\"])[1]");

        By allone = By.XPath("(//div[@class=\"RG5Slk\"])[1]");

        


        public product_cartFunaction userinput(string text)
        {
            driver.FindElement(search).SendKeys(text);
            return this;
        }


        public product_cartFunaction allonee()
        {
            driver.FindElement(allone).Click();
            return this;
        }
    }
}
