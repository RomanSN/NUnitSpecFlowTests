using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnitSpecFlowTests.PageObjects.MainPage;
using NUnitSpecFlowTests.PageObjects.LoginPage;
using NUnitSpecFlowTests.PageObjects.Common;
using NUnitSpecFlowTests.PageObjects.CustomerEditor;

namespace NUnitSpecFlowTests.Factories
{
    class WebPageFactory
    {
        public static readonly WebPageFactory Factory = new WebPageFactory();
        private LoginPagePo loginPage;
        private MainPagePo mainPage;
        private CommonMethods common;
        private CustomerEditorPo customerEditorPo;


        public LoginPagePo LoginPage
        {
            get
            {
                if (loginPage == null)
                {
                    loginPage = new LoginPagePo();
                    return loginPage;
                }
                return loginPage;
            }

        }
        public MainPagePo MainPage
        {
            get
            {
                if (mainPage == null)
                {
                    mainPage = new MainPagePo();
                    return mainPage;
                }
                return mainPage;
            }
        }
        public CommonMethods Common
        {
            get
            {
                if (common == null)
                {
                    common = new CommonMethods();
                    return common;
                }
                return common;
            }
        }
        public CustomerEditorPo CustomerEditor
        {
            get
            {
                if (customerEditorPo == null)
                {
                    customerEditorPo = new CustomerEditorPo();
                    return customerEditorPo;
                }
                return customerEditorPo;
            }
        }
    }
}
