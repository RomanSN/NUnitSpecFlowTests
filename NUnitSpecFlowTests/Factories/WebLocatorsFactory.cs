using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnitSpecFlowTests.PageObjects;
using NUnitSpecFlowTests.PageObjects.MainPage;
using NUnitSpecFlowTests.PageObjects.LoginPage;
using NUnitSpecFlowTests.PageObjects.Common;
using NUnitSpecFlowTests.PageObjects.CustomerEditor;

namespace NUnitSpecFlowTests.Factories
{
    class WebLocatorsFactory
    {
        public static readonly WebLocatorsFactory Factory = new WebLocatorsFactory();

        private LoginPageLoc loginPage;
        private MainPageLoc mainPage;
        private CommonLoc common;
        private CustomerEditorLoc customerEeditorLoc;

        public LoginPageLoc LoginPage
        {
            get
            {
                if (loginPage == null)
                {
                    loginPage = new LoginPageLoc();
                    return loginPage;
                }
                return loginPage;
            }

        }
        public MainPageLoc MainPage
        {
            get
            {
                if (mainPage == null)
                {
                    mainPage = new MainPageLoc();
                    return mainPage;
                }
                return mainPage;
            }
        }
        public CommonLoc Common
        {
            get
            {
                if (common == null)
                {
                    common = new CommonLoc();
                    return common;
                }
                return common;
            }
        }
        public CustomerEditorLoc CustomerEditor
        {
            get
            {
                if (customerEeditorLoc == null)
                {
                    customerEeditorLoc = new CustomerEditorLoc();
                    return customerEeditorLoc;
                }
                return customerEeditorLoc;
            }
        }
    }
}
