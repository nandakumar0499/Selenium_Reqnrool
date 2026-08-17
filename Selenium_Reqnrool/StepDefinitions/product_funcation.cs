using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using Selenium_Reqnrool.PageObjectModel;

namespace Selenium_Reqnrool.StepDefinitions
{
    [Binding]
    public  class product_funcation

    {


        private IWebDriver driver;
        [Given("Navigate to the Broswer")]
        public void GivenNavigateToTheBroswer()
        {
            driver = new ChromeDriver();
        }

        [When("open The  URL")]
        public void WhenOpenTheURL()
        {
           driver.Navigate().GoToUrl("https://www.flipkart.com/");

            Thread.Sleep(3000);

            driver.FindElement(By.XPath("//span[@class=\"b3wTlE\"]")).Click();
        }

        [Then("search for Loptop")]
        public void ThenSearchForLoptop()
        {
            product_cartFunaction aa = new product_cartFunaction(driver);
            aa.userinput("laptop");

            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.Enter).Perform();
        }

        [Then("Get all search result")]
        public void ThenGetAllSearchResult()
        {
            product_cartFunaction aa = new product_cartFunaction(driver);
            aa.allonee();
        }

        [Then("print product name and price")]
        public void ThenPrintProductNameAndPrice()
        {
         driver.SwitchTo().Window(driver.WindowHandles[1]);
           string productprice = driver.FindElement(By.XPath("//div[@class=\"_1psv1zeb9 _1psv1ze0 _1psv1ze2u _1psv1ze9x _1psv1ze7o _1psv1ze5f\"]")).Text;
            Console.WriteLine("Product  Price: " + productprice);
        }

        [Then("add first product to cart")]
        public void ThenAddFirstProductToCart()
        {
           // driver.FindElement(By.XPath("//div[@class=\"_1psv1zeb9 _1psv1ze0 _7dzyg20 _1psv1ze9l _1psv1ze7o _1psv1ze2u _1psv1ze53\"]/div[1]")).Click();
        }

        [When("verify the product is added to cart")]
        public void WhenVerifyTheProductIsAddedToCart()
        {
           // Console.WriteLine("Product is added to cart");
           driver.Quit();
        }



        
    }
}
