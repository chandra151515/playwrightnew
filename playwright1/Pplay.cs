using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Playwright;

namespace playwright1
{
    [TestClass]
    public class Pplay
    {
    //this is play wright project change in master branch TEAM MEMBER
        
        Drivers drivers = new Drivers();

        [TestMethod]
        public async Task StartTest()
        {
           
           
            var playWright = await Playwright.CreateAsync();
            var browser = await playWright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var page = await browser.NewPageAsync();
            await page.GotoAsync("http://www.testingdevnets.com/");
            await page.SetViewportSizeAsync(1920, 1080);
            await page.Locator("//span[text()='Register']").ClickAsync();
            //await page.Locator("input[type='name']").FillAsync(JsonHelper.GetParam("name"));
            await page.Locator("input[type='email']").FillAsync("saikrishna@gmail.com");
            await page.Locator("input[type='tel']").FillAsync("9989751042");
            Thread.Sleep(4000);
        }
        [TestMethod]
        public async Task AzkaStart()
        {
            var playWright = await Playwright.CreateAsync();
            var browser = await playWright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var page = await browser.NewPageAsync();
            await page.GotoAsync("https://www.azkasurvey.com/login");
            await page.Locator("//input[@name=\"email\"]").FillAsync("chandra@azkasurvey.com");
            await page.Locator("//input[@name=\"password\"]").FillAsync("5xP4HaZl");
            await page.Locator("//button[text()='login']").ClickAsync();
            Thread.Sleep(4000);
        }
        [TestMethod]
        public async Task Amazon()
        {
            var playWright = await Playwright.CreateAsync();
            var browser = await playWright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var page = await browser.NewPageAsync();
            await page.GotoAsync("https://www.amazon.in/");
            Thread.Sleep(2000);
            await page.Locator("a[id=\"nav-link-accountList\"]").ClickAsync();
            Thread.Sleep(2000);
            await page.Locator("input[name=\"email\"]").FillAsync("9703030756");
            Thread.Sleep(2000);
            await page.Locator("input[id=\"continue\"]").ClickAsync();
            await page.Locator("input[type=\"password\"]").FillAsync("9701912075");
            await page.Locator("input[id=\"signInSubmit\"]").ClickAsync();
            Thread.Sleep(1000);
            await page.Locator("//input[@id=\"twotabsearchtextbox\"]").FillAsync("iPHONE");
            await page.Locator("//input[@id=\"nav-search-submit-button\"]").ClickAsync();
            Thread.Sleep(3000);
            await page.Locator("(//Span[text()='Apple iPhone 13 (128GB) - Blue'])[3]").ScrollIntoViewIfNeededAsync();
            await page.Locator("(//Span[text()='Apple iPhone 13 (128GB) - Blue'])[3]").ClickAsync();
            Thread.Sleep(3000);
            
            await page.Locator("//img[@alt=\"Pink\"]").ClickAsync();


        }
    }
}
    

