using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests
{
    public class PostHelper : HelperBase
    {
        public PostHelper(ApplicationManager appManager)
            :base(appManager)
        {

        }
        public void CreateNewPost(PostData post)
        {
            driver.FindElement(By.Name("blogentry_title")).Clear();
            driver.FindElement(By.Name("blogentry_title")).SendKeys(post.Title);

            driver.FindElement(By.Name("newTag")).Clear();
            driver.FindElement(By.Name("newTag")).SendKeys(post.Tag);
            driver.FindElement(By.Name("newTag")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("//div[@class='Buttons right']")).Click();
        }
    }
}
