using System;
using System.Collections.Generic;
using System.Text;
using static Selenium_Reqnrool.Hooks.PlayWrigth_Broswer_SetUP;

namespace Selenium_Reqnrool.StepDefinitions
{
    [Binding]
    public  class Facebook_step
    {


        [Given("navigate to facebook Url")]
        public async Task GivenNavigateToFacebookUrl()
        {
            await page.GotoAsync("https://www.facebook.com");
        }

        [When("Enter the username and password")]
        public async Task WhenEnterTheUsernameAndPassword()
        {
           await page.Locator("//input[@id=\"_R_c9l6neappb6amH1_\"]").FillAsync("8525898625");
            await page.FillAsync("//input[@name=\"pass\"]", "Sree@123");
        }

        [Then("Click on login button")]
        public async Task ThenClickOnLoginButton()
        {
            await page.ClickAsync("//span[text()=\"Log in\"]");
            await page.WaitForTimeoutAsync(5000);


          Console.WriteLine(await page.TitleAsync());
            string title = await page.TitleAsync();

            if(title.Equals("Facebook"))
            {
                Console.WriteLine("Title is Verified");
            }
            else
            {
                Console.WriteLine("Title is Not Verified");
            }

            bool isVisible = await page.Locator("//div[@class=\"x106a9eq\"]").IsVisibleAsync();

            Console.WriteLine("Is the element visible? " + isVisible);
            if(isVisible)
            {
                Console.WriteLine("Logo is visible");
            }
            else
            {
                Console.WriteLine("Logo is not visible");
            }
        }

    }
}
