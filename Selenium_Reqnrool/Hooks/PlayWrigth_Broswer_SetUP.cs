using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Playwright;

namespace Selenium_Reqnrool.Hooks
{
    [Binding]
    public  class PlayWrigth_Broswer_SetUP
    {

        public static IPlaywright playwright
        { get; set; }
            public static IBrowser browser
        { get; set; }
        public static IBrowserContext context { get; set; }

        public static IPage page { get; set; }

        [BeforeTestRun]
        public static async Task BeforeTestRun()
        {
            playwright = await Playwright.CreateAsync();
            browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false
            });
          
        }
        [BeforeScenario]
        public static async Task BeforeScenario()
        {
            context = await browser.NewContextAsync();
            page = await context.NewPageAsync();
        }






        [AfterScenario]
        public static async Task AfterScenario()
        {
            await page.CloseAsync();
            await context.CloseAsync();
        }

        [AfterTestRun]
        public static async Task AfterTestRun()
        {
            await browser.CloseAsync();
            playwright.Dispose();
        }
    }
}
