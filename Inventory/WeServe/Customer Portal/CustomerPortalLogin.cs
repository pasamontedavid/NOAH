using NOAH.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOAH.WeServe.Customer_Portal
{
    public class CustomerPortalLogin:BaseConfig
    {
        [Test]
        [TestCase("C-00000000000037", "P@ssw0rd")]
        [TestCase("C-00000000000037", "P@ssw0rd")]
        [TestCase("C-00000000000037", "P@ssw0rd")]
        [TestCase("C-00000000000037", "P@ssw0rd")]
        [TestCase("C-00000000000037", "P@ssw0rd")]
        [TestCase("C-00000000000037", "P@ssw0rd")]
        [TestCase("C-00000000000037", "P@ssw0rd")]
        [TestCase("C-00000000000037", "P@ssw0rd")]
        [TestCase("C-00000000000037", "P@ssw0rd")]
        [TestCase("C-00000000000037", "P@ssw0rd")]
        [TestCase("C-00000000000037", "P@ssw0rd")]
        [TestCase("C-00000000000037", "P@ssw0rd")]
        [TestCase("C-00000000000037", "P@ssw0rd")]
        [TestCase("C-00000000000037", "P@ssw0rd")]
        [TestCase("C-00000000000037", "P@ssw0rd")]
        [TestCase("C-00000000000037", "P@ssw0rd")]
        [TestCase("C-00000000000037", "P@ssw0rd")]
        [TestCase("C-00000000000037", "P@ssw0rd")]
        [TestCase("C-00000000000037", "P@ssw0rd")]
        [TestCase("C-00000000000037", "P@ssw0rd")]
        [TestCase("C-00000000000037", "P@ssw0rd")]
        [TestCase("C-00000000000037", "P@ssw0rd")]
        [TestCase("C-00000000000037", "P@ssw0rd")]
        [TestCase("C-00000000000037", "P@ssw0rd")]
        [TestCase("C-00000000000037", "P@ssw0rd")]
        [TestCase("C-00000000000037", "P@ssw0rd")]
        [TestCase("C-00000000000037", "P@ssw0rd")]
        [TestCase("C-00000000000037", "P@ssw0rd")]
        [TestCase("C-00000000000037", "P@ssw0rd")]
        [TestCase("C-00000000000037", "P@ssw0rd")]
        [TestCase("C-00000000000037", "P@ssw0rd")]
        [TestCase("C-00000000000037", "P@ssw0rd")]
        [TestCase("C-00000000000037", "P@ssw0rd")]
        [TestCase("C-00000000000037", "P@ssw0rd")]
        [TestCase("C-00000000000037", "P@ssw0rd")]
        [TestCase("C-00000000000037", "P@ssw0rd")]
        [TestCase("C-00000000000037", "P@ssw0rd")]
        [TestCase("C-00000000000037", "P@ssw0rd")]
        [TestCase("C-00000000000037", "P@ssw0rd")]
        [TestCase("C-00000000000037", "P@ssw0rd")]
        [TestCase("C-00000000000037", "P@ssw0rd")]
        [TestCase("C-00000000000037", "P@ssw0rd")]
        [TestCase("C-00000000000037", "P@ssw0rd")]
        [TestCase("C-00000000000037", "P@ssw0rd")]




        //[Parallelizable(ParallelScope.All)]
        public void ParallelLogin(String username, String password)
        {
            targetproject = "CustomerPortal";

            driver.Value.Url = "https://flinoahuat.federalland.ph/FLI_CustomerPortalV10/login?a=sdasdas2121dsf68j821dgdfyhikjhkj&bb=sdasdas2121dsf68j821dgdfyhikjhk&c=sdasdas2121dsf68j821dgdfyhikjhk&jauas=jaskdashdj23lkklj454545&nwdev=p8dev&jkskdjsfhdhfgdjf=deskskdsdsd&d=sdasdas2121dsf68j821dgdfyhikjhk&a2z4i7e=";
            driver.Value.FindElement(By.Id("txtUsername")).SendKeys(username);
            driver.Value.FindElement(By.Id("txtPassword")).SendKeys(password);
            driver.Value.FindElement(By.Id("Button1")).Click();

            String expURL = "https://flinoahuat.federalland.ph/FLI_CustomerPortalV10/home?";

            WebDriverWait wait = new WebDriverWait(driver.Value, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlContains("home"));
            StringAssert.Contains(expURL, driver.Value.Url);
        }
    }
}
