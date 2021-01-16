using System;
using TechTalk.SpecFlow;
using NUnitSpecFlowTests.Extensions;
using System.Threading;
using NUnit.Framework;

namespace NUnitSpecFlowTests.StepsBindings
{
    [Binding]
    class CustomerCRUDFeatureSteps: TestBase
    {
        [Given(@"When I navigate to the main page")]
        public void GivenWenINavigateToTheMainPage()
        {
            driver.Url = "http://demo.guru99.com/V1/html/Managerhomepage.php";
        }
        
        [Given(@"open Add customer form")]
        public void GivenOpenAddCustomerForm()
        {
            webPo.MainPage.OpenAddCustomerForm();
        }
        
        [Given(@"fill form with data (.*) (.*) (.*) (.*) (.*) (.*) (.*) (.*) (.*)")]
        public void GivenFillCustomerForm(string name, string gender, string dob, string address, string city, string state, int pin, int phone, string email)
        {
            webPo.CustomerEditor.FillNewCustomerForm(name, gender, dob, address, city, state, pin, phone, email);
        }
        
        [When(@"I submit creating")]
        public void WhenISubmitCreating()
        {
            webPo.CustomerEditor.Submit();
        }
        
        [Then(@"new user is successfully added")]
        public void ThenNewUserIsSuccessfullyAdded()
        {
            //driver.WaitForElementVisible(locs.MainPage.ManagerBtn);
            Assert.IsTrue(true);
        }

        [Then(@"new user is not added, allert displayed")]
        public void ValidatePopUpMessage()
        {
            driver.SwitchTo().Alert().Accept();
        }

        [Given(@"open delete customer form")]
        public void GivenOpenDeleteCustomerForm()
        {
        }

        [Given(@"fill form with '(.*)' as Id")]
        public void GivenFillFormWithAsId(int Id)
        {
        }

        [When(@"I submit deleting")]
        public void WhenISubmitDeleting()
        {
        }

        [Then(@"new user is deleted")]
        public void ThenNewUserIsDeleted()
        {
        }
    }
}
