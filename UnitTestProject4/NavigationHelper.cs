using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests 
{
    public class NavigationHelper : HelperBase
    {
        private string baseURL;
        public NavigationHelper(ApplicationManager appManager, string baseURL)
            : base(appManager)
        {
            this.baseURL = baseURL;
        }
        public void OpenHomePage()
        {
            driver.Navigate().GoToUrl(baseURL);
        }
        public void OpenCreatePostPage()
        {
            driver.Navigate().GoToUrl(baseURL + "/murzik944/blogs/add");
        }   
    }
}
