using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.PageModels.BaseModel
{
    internal class LoginPageBase
    {
        [FindsBy(How = How.Id, Using = "username")]
        public IWebElement Username { get; set; }
        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement Password { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/form/button")]
        public IWebElement LoginFormSummitButton { get; set; }
        [FindsBy(How = How.Id, Using = "flash")]
        public IWebElement ResultStatusMessage { get; set; }
    }
}
