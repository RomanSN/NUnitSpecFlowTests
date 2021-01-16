using System.Configuration;
using System.Diagnostics;
using NUnitSpecFlowTests.Extensions;
using System.Threading;

namespace NUnitSpecFlowTests.PageObjects.MainPage
{
    class MainPagePo: WebPageBase
    {
        public void OpenAddCustomerForm()
        {
            driver.WaitForElementClickable(locs.MainPage.AddCustomerBtn).Click();
            driver.WaitForElementVisible(locs.CustomerEditor.NameInput);
        }
        public void LogOut()
        {
        }
    }
}
