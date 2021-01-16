using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnitSpecFlowTests.Models;

namespace NUnitSpecFlowTests.Extensions
{
    public static class WebDriverExtensions
    {
        public static IWebElement FindElement(this IWebDriver driver, By by)
        {
            return driver.FindElement(by);
        }
        public static IList<IWebElement> FindElements(this IWebDriver driver, By by)
        {
            return driver.FindElements(by);
        }
        public static string SelectRandomListItem(this IWebDriver wd, By by, string attribute)
        {
            IList<IWebElement> elements = wd.FindElements(by);

            Random rnd = new Random();

            int index = rnd.Next(0, elements.Count() - 1);
            elements[index].Click();
            Thread.Sleep(500);
            if (attribute.Contains("text"))
            {
                return elements[index].Text;
            }
            else
            {
                return elements[index].GetAttribute(attribute);
            }
        }
        public static IWebElement WaitForElementVisible(this IWebDriver driver, By by, int miliseconds = 5000)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(miliseconds));
            wait.PollingInterval = TimeSpan.FromMilliseconds(50);
            return wait.Until<IWebElement>(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));
        }
        public static IWebElement WaitForElementClickable(this IWebDriver driver, By by, int miliseconds = 5000)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(miliseconds));
            wait.PollingInterval = TimeSpan.FromMilliseconds(50);
            return wait.Until<IWebElement>(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(by));
        }
        public static bool ElementExists(this IWebDriver driver, By by, int miliseconds = 1000)
        {
            try
            {
                if (miliseconds > 0)
                {
                    var wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(miliseconds));
                    wait.Until(drv => drv.FindElement(by));
                    return true;
                }
                driver.FindElement(by);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static void WaitForElementNotVisible(this IWebDriver driver, By by, int miliseconds)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();

            while (true)
            {
                try
                {
                    driver.WaitForElementVisible(by, 250);
                }
                catch
                {
                    break;
                }

                if (timer.Elapsed.TotalMilliseconds > miliseconds)
                {
                    timer.Stop();
                    throw new Exception(string.Format("Element {0} still exists", by.ToString()));
                }
            }
        }
        public static void WaitForNewWindow(this IWebDriver driver, int miliseconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(miliseconds));
            wait.PollingInterval = TimeSpan.FromMilliseconds(50);
            wait.Until(drv => drv.WindowHandles.Count > 1);
        }
        public static void WaitForNewWindowIsClosed(this IWebDriver driver, int miliseconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(miliseconds));
            wait.PollingInterval = TimeSpan.FromMilliseconds(50);
            wait.Until(drv => drv.WindowHandles.Count == 1);
        }
        public static void WindowFocus(this IWebDriver driver)
        {
            IJavaScriptExecutor jsexecutor = (IJavaScriptExecutor)driver;
            jsexecutor.ExecuteScript(@"window.focus();");
        }
    }
}
