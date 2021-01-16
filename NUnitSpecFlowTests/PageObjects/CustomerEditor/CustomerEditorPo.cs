using System;
using System.Collections.Generic;
using System.Text;
using NUnitSpecFlowTests.Extensions;

namespace NUnitSpecFlowTests.PageObjects.CustomerEditor
{
    class CustomerEditorPo: WebPageBase
    {
        public void FillNewCustomerForm(string name, string gender, string dob, string address, string city, string state, int pin, int phone, string email)
        {
            driver.WaitForElementClickable(locs.CustomerEditor.NameInput).ClearAndSendKeys(name);
            if (gender.Equals("male"))
            {
                driver.WaitForElementClickable(locs.CustomerEditor.MaleRadioBtn).Click();
            }
            else if (gender.Equals("female"))
            {
                driver.WaitForElementClickable(locs.CustomerEditor.MaleRadioBtn).Click();
            }
            else { throw new Exception("Not permitted gender"); }
            driver.WaitForElementClickable(locs.CustomerEditor.DoB).SendKeys(dob.ToString());
            driver.WaitForElementClickable(locs.CustomerEditor.AddressInput).ClearAndSendKeys(address);
            driver.WaitForElementClickable(locs.CustomerEditor.CityInput).ClearAndSendKeys(city);
            driver.WaitForElementClickable(locs.CustomerEditor.StateInput).ClearAndSendKeys(state);
            driver.WaitForElementClickable(locs.CustomerEditor.PinInput).ClearAndSendKeys(pin.ToString());
            driver.WaitForElementClickable(locs.CustomerEditor.PhoneInput).ClearAndSendKeys(phone.ToString());
            driver.WaitForElementClickable(locs.CustomerEditor.EmailInput).ClearAndSendKeys(email);
        }

        public void Submit()
        {
            driver.WaitForElementClickable(locs.CustomerEditor.SubmitBtn).Click();
        }
    }
}
