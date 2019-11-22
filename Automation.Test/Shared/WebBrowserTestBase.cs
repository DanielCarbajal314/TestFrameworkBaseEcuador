using Automation.Infrastructure;
using Automation.PageModels.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Test.Shared
{
    public class WebBrowserTestBase
    {
        protected DriverFactory driverFactory;
        protected BasePageModel pageModel;

        public void Initialize()
        {
            this.driverFactory = new DriverFactory(WebBrowser.Chrome);
        }

        public void Clear()
        {
            this.pageModel.Clear();
        }
    }
}
