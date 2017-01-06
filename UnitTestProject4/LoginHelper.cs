using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests
{
    public class LoginHelper : HelperBase
    {
        public LoginHelper(ApplicationManager appmanager)
            : base (appmanager)
        {

        }
        public void LogIn(AccountData usr)
        {
            driver.FindElement(By.Name("email")).Clear();
            driver.FindElement(By.Name("email")).SendKeys(usr.Username);
            driver.FindElement(By.Name("password")).Clear();
            driver.FindElement(By.Name("password")).SendKeys(usr.Password);
            driver.FindElement(By.CssSelector("input[value='Войти']")).Click();
        }
    }
}
