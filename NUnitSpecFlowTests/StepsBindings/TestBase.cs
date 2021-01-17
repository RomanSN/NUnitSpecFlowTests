using System;
using System.Configuration;
using System.Threading;
using Microsoft.Extensions.Configuration;
using NUnitSpecFlowTests.Factories;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace NUnitSpecFlowTests.StepsBindings
{
    [Binding]
    class TestBase
    {
        protected static WebPageFactory webPo = WebPageFactory.Factory;
        protected static IWebDriver driver;
        protected static WebLocatorsFactory locs = WebLocatorsFactory.Factory;
        

        [BeforeTestRun]
        protected static void InitTests()
        {
            DriverFactory.InitDriver(DriverFactory.Browsers.Chrome);
            var config = new ConfigurationBuilder().AddJsonFile("secrets.json").Build();
            driver = DriverFactory.SeleniumDriver;
            webPo.LoginPage.NavigateTo();
            webPo.LoginPage.Login(
                config["userId"], 
                config["password"]
                );
        }


        public void SetUp()
        {
        }

        public void TearDown()
        {
        }

        [AfterTestRun]
        public static void EndTestSuite()
        {
            DriverFactory.DriverQuit();
        }
    }
}
