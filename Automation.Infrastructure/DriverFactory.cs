using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Infrastructure
{
    public class DriverFactory
    {
        private WebBrowser _browserType;
        public DriverFactory(WebBrowser browserType)
        {
            this._browserType = browserType;
        }

        public IWebDriver BuildWebDriver()
        {
            string location = ConfigurationManager.AppSettings["DriverLocation"];
            if (string.IsNullOrEmpty(location)) throw new Exception("Set up  DriverLocation setting first");
            if (_browserType.Equals(WebBrowser.Chrome))
                return new ChromeDriver(location);
            else
                return new FirefoxDriver(location);
        }
    }
}
