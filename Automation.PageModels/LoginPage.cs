using Automation.Infrastructure;
using Automation.PageModels.BaseModel;
using Automation.PageModels.Shared;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.PageModels
{
    public class LoginPage:BasePageModel
    {
        private LoginPageBase loginPageBase;

        public LoginPage(DriverFactory DriverFactory)
        {
            this.driver = DriverFactory.BuildWebDriver();
            this.driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/login");
            this.loginPageBase = new LoginPageBase();
            PageFactory.InitElements(driver, loginPageBase);
        }

        public void WriteDownUsername(string username)
        {
            this.loginPageBase.Username.SendKeys(username);
        }

        public void WriteDownPassword(string password)
        {
            this.loginPageBase.Password.SendKeys(password);
        }


        public void SummitCredentials()
        {
            this.loginPageBase.LoginFormSummitButton.Click();
        }

        public bool LoginWasASuccess()
        {
            return !this.loginPageBase.ResultStatusMessage.Text.Contains("invalid");
        }
    }
}
