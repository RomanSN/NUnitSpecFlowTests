using System.Drawing;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using NUnitSpecFlowTests.Factories;


namespace NUnitSpecFlowTests.Extensions
{
    public static class WebElementExtensions
    {
        private static readonly IWebDriver wd = Factories.DriverFactory.SeleniumDriver;

        public static void SelectByText(this IWebElement element, string text)
        {
            SelectElement select = new SelectElement(element);
            select.SelectByText(text);
        }
        public static void ClearAndSendKeys(this IWebElement element, string text)
        {
            element.Click();
            element.Clear();
            element.SendKeys(text);
        }
        public static void ClickAndHold(this IWebElement element)
        {
            Actions act = new Actions(wd);
            act.MoveToElement(element).ClickAndHold(element).Build().Perform();
        }
        public static void MoveAndClick(this IWebElement element)
        {
            Actions act = new Actions(wd);
            act.MoveToElement(element).Click(element).Build().Perform();
        }
        public static void DoubleClick(this IWebElement element)
        {
            Actions act = new Actions(wd);
            act.MoveToElement(element).DoubleClick(element).Build().Perform();
        }
        public static void MoveTo(this IWebElement element)
        {
            Actions act = new Actions(wd);
            act.MoveToElement(element).Build().Perform();
        }
    }
}
