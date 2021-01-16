using NUnitSpecFlowTests.Models;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSpecFlowTests.PageObjects.LoginPage
{
    class LoginPageLoc
    {
        public By UserIdInput { get; } = By.XPath("//input[@name='uid']");

        public By PasswordInput { get; } = By.XPath("//input[@name='password']");

        public By LoginBtn { get; } = By.XPath("//input[@name='btnLogin']");
    }
}
