using System;
using System.Collections.Generic;
using System.Text;
using static Selenium_Reqnrool.Hooks.PlayWrigth_Broswer_SetUP;
namespace Selenium_Reqnrool.StepDefinitions
{
    [Binding]
    public class SBI_STEP_3
    {


        [Given("Navigate SBI  Urll")]
        public async Task GivenNavigateSBIUrll()
        {
            await page.GotoAsync("https://onlinesbi.sbi.bank.in/");
        }

        [When("Verify the logoo")]
        public async Task WhenVerifyTheLogoo()
        {
            Console.WriteLine("logo");
        }

        [Then("Verify the Titlee")]
        public void ThenVerifyTheTitlee()
        {
            Console.WriteLine("Title");

        }

    }
}
