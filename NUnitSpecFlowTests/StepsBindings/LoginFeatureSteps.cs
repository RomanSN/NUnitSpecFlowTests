using System;
using TechTalk.SpecFlow;
using NUnitSpecFlowTests.Extensions;

namespace NUnitSpecFlowTests.StepsBindings
{
    [Binding]
    class LoginFeatureSteps: TestBase
    {
        [Given(@"When user navigate to Gtpl Bank login page")]
        public void GivenWhenUserNavigateToGtplBankLoginPage()
        {
            webPo.LoginPage.NavigateTo();
        }
        
        [Given(@"type (.*) as userId into UserId field")]
        public void GivenTypeAsUserIdIntoUserIdField(string userId)
        {
            driver.WaitForElementClickable(locs.LoginPage.UserIdInput).SendKeys(userId);
        }
        
        [Given(@"type (.*) as password into Password field")]
        public void GivenTypeAsPasswordIntoPasswordField(string password)
        {
            driver.WaitForElementClickable(locs.LoginPage.PasswordInput).SendKeys(password);
        }
        
        [When(@"the Login button is clicked")]
        public void WhenTheLoginButtonIsClicked()
        {
            driver.WaitForElementClickable(locs.LoginPage.LoginBtn).Click();
        }
        
        [Then(@"main page of the application is opened")]
        public void ThenMainPageOfTheApplicationIsOpened()
        {
            driver.WaitForElementVisible(locs.MainPage.ManagerBtn);
        }
    }
}
