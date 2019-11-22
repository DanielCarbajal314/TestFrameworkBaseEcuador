using Automation.Infrastructure;
using Automation.PageModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace Automation.Test.StepDefinitions
{
    [Binding]
    public class LoginInTheAppSteps
    {
        DriverFactory factory = new DriverFactory(WebBrowser.Chrome);
        LoginPage loginPage;

        [Given(@"Im on the login screen")]
        public void GivenImOnTheLoginScreen()
        {
            this.loginPage = new LoginPage(factory);
        }
        
        [Given(@"I write ""(.*)"" as username")]
        public void GivenIWriteAsUsername(string p0)
        {
            this.loginPage.WriteDownUsername(p0);
        }
        
        [Given(@"I write ""(.*)"" as password")]
        public void GivenIWriteAsPassword(string p0)
        {
            this.loginPage.WriteDownPassword(p0);
        }
        
        [When(@"I press the login button")]
        public void WhenIPressTheLoginButton()
        {
            this.loginPage.SummitCredentials();
        }
        
        [Then(@"the login should fail")]
        public void ThenTheLoginShouldFail()
        {
            Assert.IsFalse(this.loginPage.LoginWasASuccess());
            this.loginPage.Clear();
        }
    }
}
