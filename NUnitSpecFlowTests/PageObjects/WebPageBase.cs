using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnitSpecFlowTests.Extensions;
using NUnitSpecFlowTests.Factories;
using OpenQA.Selenium;

namespace NUnitSpecFlowTests.PageObjects
{
    class WebPageBase
    {
        protected WebLocatorsFactory locs = WebLocatorsFactory.Factory;
        protected WebPageFactory pages = WebPageFactory.Factory;
        protected IWebDriver driver = DriverFactory.SeleniumDriver;
    }
}
