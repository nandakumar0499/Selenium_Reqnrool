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
            Thread.Sleep(5000);
           bool isDisplayed = driver.FindElement(By.XPath("//h1[@class=\"v1zwn21n v1zwn27 _1psv1zeb9 _1psv1ze0\"]")).Displayed;

            Console.WriteLine("Product name is displayed: " + isDisplayed);

            bool iphoneImg = driver.FindElement(By.XPath("//div[@class=\"_1psv1zeb9 _1psv1ze0 _1psv1ze36 _1psv1ze5f\"]")).Displayed;

            Console.WriteLine("Iphone Img is displayed: " + iphoneImg);


            Console.WriteLine("Product is added to cart succussfully");
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            Thread.Sleep(3000);

            string  Title = driver.Title;
            Console.WriteLine("Title of the page is: " + Title);

            if(Title.Contains("Iphone 14 Pro Max- Buy Products Online at Best Price in India - All Categories | Flipkart.com"))
            {
                Console.WriteLine("Title is verified");
            }
            else
            {
                Console.WriteLine("Title is not verified");
            }

        }

    }
}
