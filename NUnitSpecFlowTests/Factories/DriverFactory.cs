using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace NUnitSpecFlowTests.Factories
{
    class DriverFactory
    {
        public enum Browsers
        {
            Firefox,
            Chrome
        }

        private static IWebDriver driver;

        public static IWebDriver SeleniumDriver
        {
            get
            {
                if (driver == null)
                {
                    throw new NullReferenceException("The WebDriver browser instance was not initialized. You should first call the method InitBrowser.");
                }
                return driver;
            }
            private set
            {
                driver = value;
            }
        }

        public static void InitDriver(Browsers browser)
        {
            switch (browser)
            {
                case Browsers.Firefox:
                    if (driver == null)
                    {
                        driver = new FirefoxDriver();
                    }
                    break;

                case Browsers.Chrome:
                    if (driver == null)
                    {
                        var options = new ChromeOptions();
                        options.AddArgument("no-sandbox");
                        options.AddArgument("--disable-gpu");
                        driver = new ChromeDriver(@"C:\SelfDev\NUnitSpecFlowTests\SeleniumDrivers", options);
                        driver.Manage().Window.Maximize();
                    }
                    break;

                default:
                    if (driver == null)
                    {
                        var options = new ChromeOptions();
                        options.AddArgument("no-sandbox");
                        options.AddArgument("--disable-gpu");
                        driver = new ChromeDriver(@"C:\SelfDev\NUnitSpecFlowTests\SeleniumDrivers", options);
                        driver.Manage().Window.Maximize();
                    }
                    break;
            }
        }

        public static void DriverQuit()
        {
            driver.Quit();
            driver = null;
        }
    }
}
