using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium_Reqnrool.PageObjectModel;

namespace Selenium_Reqnrool.StepDefinitions
{

    [Binding]
    public class facebook2
    {
       
        private IWebDriver driver;
        Facebook3 facebook3;
       facbook4 facebook4;



        [Given("BROSWER OPEN")]
        public void GivenBROSWEROPEN()
        {

            driver = new ChromeDriver();
           
        }

        [When("navigate to webpage")]
        public void WhenNavigateToWebpage()
        {
         driver.Navigate().GoToUrl("https://www.facebook.com/");
        }

        [Then("enter username")]
        public void ThenEnterUsername()
        {
            facebook3 = new Facebook3(driver);
            facebook3.userinput("jr ntr");
         

            facbook4 facebookk4 = new facbook4(driver);
              facebookk4.pass("123456789");

            facebook4 = new facbook4(driver);
            facebook4.pass("7563685"); 

            driver.Quit();
        }




    }
}
