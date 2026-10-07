using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using static Selenium_Reqnrool.Hooks.Broswer__SetUp;
namespace Selenium_Reqnrool.StepDefinitions
{
    [Binding]
    public class Flipkart__product__Add
    {

        [Given("Open  Url")]
        public void GivenOpenUrl()
        {
           driver.Navigate().GoToUrl("https://www.flipkart.com/");
        }

        [When("Search the product  and get all products names")]
        public void WhenSearchTheProductAndGetAllProductsNames()
        {
            driver.FindElement(By.XPath("//input[@name=\"q\"]")).SendKeys("Iphone 14 pro max"+Keys.Enter);


            IList<IWebElement> productNames = driver.FindElements(By.XPath("//div[@class=\"RG5Slk\"]"));

            for(int i = 0; i < productNames.Count; i++)
            {
                Console.WriteLine("${i+1}. {productNames[i].Text}");
            }
            productNames[0].Click();
        }

        [Then("Verify the product add to cart first Iteam succussfully")]
        public void ThenVerifyTheProductAddToCartFirstIteamSuccussfully()
        {
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id=\"slot-list-container\"]/div/div[2]/div/div/div/div[1]/div/div[2]/div/div[4]/div/div/div/div/div/div/div/div[2]/div/div[1]/div/div[2]/div[3]/div/div/div/a/div[4]")).Click();
            Thread.Sleep(3000);

           /*string productText =driver.FindElement(By.XPath("//div[@class=\"aWGL6T\"]")).Text;
            Console.WriteLine("Product Name: " + productText);*/

            Console.WriteLine("Product is added to cart succussfully");
        }

    }
}
