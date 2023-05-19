using NOAH.Utilities;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazorEngine.Compilation.ImpromptuInterface.Dynamic;

namespace NOAH.WeSELL.Seller_Portal.Customer_Prospecting
{
    public class SellerPortalLogin:BaseConfig
    {
        
        [Test]
        [TestCase("S-0000000039", "P@ssw0rd")]
        [TestCase("S-0000000039", "P@ssw0rd")]
        [TestCase("S-0000000039", "P@ssw0rd")]
        [TestCase("S-0000000039", "P@ssw0rd")]
        [TestCase("S-0000000039", "P@ssw0rd")]
        [TestCase("S-0000000039", "P@ssw0rd")]
        [TestCase("S-0000000039", "P@ssw0rd")]
        [TestCase("S-0000000039", "P@ssw0rd")]
        [TestCase("S-0000000039", "P@ssw0rd")]
        [TestCase("S-0000000039", "P@ssw0rd")]
        [TestCase("S-0000000039", "P@ssw0rd")]
        [TestCase("S-0000000039", "P@ssw0rd")]
        [TestCase("S-0000000039", "P@ssw0rd")]
        [TestCase("S-0000000039", "P@ssw0rd")]
        [TestCase("S-0000000039", "P@ssw0rd")]
        [TestCase("S-0000000039", "P@ssw0rd")]
        [TestCase("S-0000000039", "P@ssw0rd")]
        [TestCase("S-0000000039", "P@ssw0rd")]
        [TestCase("S-0000000039", "P@ssw0rd")]
        [TestCase("S-0000000039", "P@ssw0rd")]
        [TestCase("S-0000000039", "P@ssw0rd")]
        [TestCase("S-0000000039", "P@ssw0rd")]
        [TestCase("S-0000000039", "P@ssw0rd")]
        [TestCase("S-0000000039", "P@ssw0rd")]
        [TestCase("S-0000000039", "P@ssw0rd")]
        [TestCase("S-0000000039", "P@ssw0rd")]
        [TestCase("S-0000000039", "P@ssw0rd")]
        [TestCase("S-0000000039", "P@ssw0rd")]
        [TestCase("S-0000000039", "P@ssw0rd")]
        [TestCase("S-0000000039", "P@ssw0rd")]
        [TestCase("S-0000000039", "P@ssw0rd")]
        [TestCase("S-0000000039", "P@ssw0rd")]
        [TestCase("S-0000000039", "P@ssw0rd")]
        [TestCase("S-0000000039", "P@ssw0rd")]
        [TestCase("S-0000000039", "P@ssw0rd")]
        [TestCase("S-0000000039", "P@ssw0rd")]
        [TestCase("S-0000000039", "P@ssw0rd")]
        [TestCase("S-0000000039", "P@ssw0rd")]
        [TestCase("S-0000000039", "P@ssw0rd")]
        [TestCase("S-0000000039", "P@ssw0rd")]
        [TestCase("S-0000000039", "P@ssw0rd")]
        [TestCase("S-0000000039", "P@ssw0rd")]
        [TestCase("S-0000000039", "P@ssw0rd")]
        [TestCase("S-0000000039", "P@ssw0rd")]
        
        public void ParallelLogin(String username, String password)
        {
            targetproject = "SellerPortal";

            driver.Value.Url = "https://flinoahuat.federalland.ph/FLI_SellerPortalV10/Login?a=sdasdas2121dsf68j821dgdfyhikjhkj&bb=sdasdas2121dsf68j821dgdfyhikjhk&c=sdasdas2121dsf68j821dgdfyhikjhk&jauas=jaskdashdj23lkklj454545&nwdev=p8dev&jkskdjsfhdhfgdjf=deskskdsdsd&d=sdasdas2121dsf68j821dgdfyhikjhk&a2z4i7e=";
            driver.Value.FindElement(By.Id("txtUsername")).SendKeys(username);
            driver.Value.FindElement(By.Id("txtPassword")).SendKeys(password);
            driver.Value.FindElement(By.Id("Button1")).Click();

            String expURL = "https://flinoahuat.federalland.ph/FLI_SellerPortalV10/home?";

            WebDriverWait wait = new WebDriverWait(driver.Value, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlContains("home"));
            StringAssert.Contains(expURL, driver.Value.Url);
        }
    }
}
