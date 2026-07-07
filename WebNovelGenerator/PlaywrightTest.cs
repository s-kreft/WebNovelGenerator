using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebNovelGenerator
{
    internal class PlaywrightTest
    {
        public async Task GetScreenshot()
        {
            using var playwright = await Playwright.CreateAsync();
            await using var browser = await playwright.Chromium.LaunchAsync();
            var page = await browser.NewPageAsync();
            await page.GotoAsync("https://playwright.dev/dotnet");
            await page.ScreenshotAsync(new()
            {
                Path = "screenshot.png"
            });
            Console.WriteLine("Screenshot downloaded");
        }
    }
}
