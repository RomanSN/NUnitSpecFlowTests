using System.Configuration;
using System.Diagnostics;
using NUnitSpecFlowTests.Extensions;

namespace NUnitSpecFlowTests.PageObjects.LoginPage
{
    class LoginPagePo : WebPageBase
    {
        public void NavigateTo()
        {
            driver.Url = ConfigurationManager.AppSettings["TargetServerUrl"];
            driver.WaitForElementClickable(locs.LoginPage.UserIdInput);
        }
        public void Login(string userId, string password)
        {
            driver.WaitForElementClickable(locs.LoginPage.UserIdInput).SendKeys(userId);
            driver.WaitForElementClickable(locs.LoginPage.PasswordInput).SendKeys(password);
            driver.WaitForElementClickable(locs.LoginPage.LoginBtn).Click();
            driver.WaitForElementVisible(locs.MainPage.ManagerBtn, 30000);
        }
    }
}
