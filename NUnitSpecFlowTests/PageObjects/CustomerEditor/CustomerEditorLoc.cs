using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitSpecFlowTests.PageObjects.CustomerEditor
{
    class CustomerEditorLoc
    {
        public By NameInput { get; } = By.XPath("//input[@name='name']");
        public By MaleRadioBtn { get; } = By.XPath("//td/input[@type='radio'][1]");
        public By FemaleRadioBtn { get; } = By.XPath("//td/input[@type='radio'][2]");
        public By DoB { get; } = By.Id("dob");
        public By AddressInput { get; } = By.XPath("//textarea[@name='addr']");
        public By CityInput { get; } = By.XPath("//input[@name='city']");
        public By StateInput { get; } = By.XPath("//input[@name='state']");
        public By PinInput { get; } = By.XPath("//input[@name='pinno']");
        public By PhoneInput { get; } = By.XPath("//input[@name='telephoneno']");
        public By EmailInput { get; } = By.XPath("//input[@name='emailid']");
        public By SubmitBtn { get; } = By.XPath("//input[@name='sub']");
    }
}
