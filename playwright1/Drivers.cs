using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Playwright;

namespace playwright1
{
    public class Drivers
    {  
       
        public static async Task Internet()
        {
            var playWright = await Playwright.CreateAsync();
            var browser = await playWright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var page = await browser.NewPageAsync();
        }
    }
}
