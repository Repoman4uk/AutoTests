using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumTests
{
    public class ApplicationManager
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private NavigationHelper navigation;
        private LoginHelper usr;
        private PostHelper post;
        private static ThreadLocal<ApplicationManager> app = new ThreadLocal<ApplicationManager>();
        private ApplicationManager()
        {
            driver = new ChromeDriver(@"D:\");
            driver.Manage().Window.Maximize();
            baseURL = SettingsLoader.BaseURL;
            verificationErrors = new StringBuilder();
            navigation = new NavigationHelper(this,baseURL);
            usr = new LoginHelper(this);
            post = new PostHelper(this);
        }
        public static ApplicationManager GetInstance()
        {
            if (!app.IsValueCreated)
            {
                ApplicationManager appManager = new ApplicationManager();
                appManager.Navigation.OpenHomePage();
                app.Value = appManager;
            }
            return app.Value;
        }
        public IWebDriver Driver
        {
            get
            {
                return driver;
            }
        }
        public NavigationHelper Navigation
        {
            get
            {
                return navigation;
            }
        }
        public LoginHelper User
        {
            get
            {
                return usr;
            }
        }
        public PostHelper Post
        {
            get
            {
                return post;
            }
        }
        ~ApplicationManager()
        {
            try
            {
                driver.Quit();

            }
            catch (Exception)
            {

            }
        }
        public void Stop()
        {
            
        }
    }
}
