using NUnitSpecFlowTests.Models;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSpecFlowTests.PageObjects.MainPage
{
    class MainPageLoc
    {
       public By ManagerBtn { get; } = By.XPath("//li/a[@href='Managerhomepage.php']");
       public By AddCustomerBtn { get; } = By.XPath("//li/a[@href='addcustomerpage.php']");
    }
}
