using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class Untitled : TestBase
    {
        
        [Test]
        public void LoginTest()
        {
            AccountData user = new AccountData(SettingsLoader.Login, SettingsLoader.Password);
            appManager.Navigation.OpenHomePage();
            appManager.User.LogIn(user);
            Thread.Sleep(5000);
            string currentUrl = appManager.Driver.Url;
            Assert.IsTrue(currentUrl.Equals("http://worldis.me/myfeed"));
        }
        [Test]
        public void InvalidUserLoginTest()
        {
            AccountData user = new AccountData("almazzmurzin@gmail.com", "qqwertyqwerty");
            appManager.Navigation.OpenHomePage();
            appManager.User.LogIn(user);
            Thread.Sleep(5000);
            string currentUrl = appManager.Driver.Url;
            Assert.IsTrue(currentUrl.Equals("http://worldis.me/"));
        }
        [Test]
        public void CreatePostTest()
        {
            AccountData user = new AccountData(SettingsLoader.Login, SettingsLoader.Password);
            appManager.Navigation.OpenHomePage();
            appManager.User.LogIn(user);
            PostData post = new PostData("Hello", "HelloTag");
            appManager.Navigation.OpenCreatePostPage();
            appManager.Post.CreateNewPost(post);
            Thread.Sleep(5000);
            string currentUrl = appManager.Driver.Url;
            Assert.IsTrue(!currentUrl.Contains("http://worldis.me/murzik944/blogs/add") && currentUrl.Contains("http://worldis.me/murzik944/blogs/"));
        }


    }
}
