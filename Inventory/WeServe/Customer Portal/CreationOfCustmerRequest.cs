using NOAH.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using RazorEngine.Compilation.ImpromptuInterface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOAH.WeServe.Customer_Portal
{
    public class CreationOfCustmerRequest:BaseConfig
    {
        public void LoginCust(String username, String password)
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

        [Test]
        [TestCase("C-00000000000037", "P@ssw0rd", "WCSTBC", "Stress001")]
        [TestCase("C-00000000000038", "P@ssw0rd", "WCSTBC", "Stress002")]
        [TestCase("C-00000000000039", "P@ssw0rd", "WCSTBC", "Stress003")]
        [TestCase("C-00000000000041", "P@ssw0rd", "WCSTBC", "Stress004")]
        [TestCase("C-00000000000042", "P@ssw0rd", "WCSTBC", "Stress005")]
        [TestCase("C-00000000000043", "P@ssw0rd", "WCSTBC", "Stress006")]
        [TestCase("C-00000000000044", "P@ssw0rd", "WCSTBC", "Stress007")]
        [TestCase("C-00000000000045", "P@ssw0rd", "WCSTBC", "Stress008")]
        [TestCase("C-00000000000046", "P@ssw0rd", "WCSTBC", "Stress009")]
        [TestCase("C-00000000000047", "P@ssw0rd", "WCSTBC", "Stress010")]
        [TestCase("C-00000000000048", "P@ssw0rd", "WCSTBC", "Stress011")]
        [TestCase("C-00000000000049", "P@ssw0rd", "WCSTBC", "Stress012")]
        [TestCase("C-00000000000050", "P@ssw0rd", "WCSTBC", "Stress013")]
        [TestCase("C-00000000000051", "P@ssw0rd", "WCSTBC", "Stress014")]
        [TestCase("C-00000000000052", "P@ssw0rd", "WCSTBC", "Stress015")]
        [TestCase("C-00000000000053", "P@ssw0rd", "WCSTBC", "Stress016")]
        [TestCase("C-00000000000054", "P@ssw0rd", "WCSTBC", "Stress017")]
        [TestCase("C-00000000000055", "P@ssw0rd", "WCSTBC", "Stress018")]
        [TestCase("C-00000000000056", "P@ssw0rd", "WCSTBC", "Stress019")]
        [TestCase("C-00000000000057", "P@ssw0rd", "WCSTBC", "Stress020")]
        [TestCase("C-00000000000058", "P@ssw0rd", "WCSTBC", "Stress021")]
        [TestCase("C-00000000000059", "P@ssw0rd", "WCSTBC", "Stress022")]
        [TestCase("C-00000000000060", "P@ssw0rd", "WCSTBC", "Stress023")]
        [TestCase("C-00000000000061", "P@ssw0rd", "WCSTBC", "Stress024")]
        [TestCase("C-00000000000062", "P@ssw0rd", "WCSTBC", "Stress025")]
        [TestCase("C-00000000000063", "P@ssw0rd", "WCSTBC", "Stress026")]
        [TestCase("C-00000000000064", "P@ssw0rd", "WCSTBC", "Stress027")]
        [TestCase("C-00000000000065", "P@ssw0rd", "WCSTBC", "Stress028")]
        [TestCase("C-00000000000066", "P@ssw0rd", "WCSTBC", "Stress029")]
        [TestCase("C-00000000000067", "P@ssw0rd", "WCSTBC", "Stress030")]
        [TestCase("C-00000000000068", "P@ssw0rd", "WCSTBC", "Stress031")]
        [TestCase("C-00000000000069", "P@ssw0rd", "WCSTBC", "Stress032")]
        [TestCase("C-00000000000070", "P@ssw0rd", "WCSTBC", "Stress033")]
        [TestCase("C-00000000000071", "P@ssw0rd", "WCSTBC", "Stress034")]
        [TestCase("C-00000000000072", "P@ssw0rd", "WCSTBC", "Stress035")]
        [TestCase("C-00000000000073", "P@ssw0rd", "WCSTBC", "Stress036")]
        [TestCase("C-00000000000074", "P@ssw0rd", "WCSTBC", "Stress037")]
        [TestCase("C-00000000000075", "P@ssw0rd", "WCSTBC", "Stress038")]
        [TestCase("C-00000000000076", "P@ssw0rd", "WCSTBC", "Stress039")]
        [TestCase("C-00000000000077", "P@ssw0rd", "WCSTBC", "Stress040")]
        [TestCase("C-00000000000078", "P@ssw0rd", "WCSTBC", "Stress041")]
        [TestCase("C-00000000000079", "P@ssw0rd", "WCSTBC", "Stress042")]
        [TestCase("C-00000000000080", "P@ssw0rd", "WCSTBC", "Stress043")]
        [TestCase("C-00000000000081", "P@ssw0rd", "WCSTBC", "Stress045")]
        [Parallelizable(ParallelScope.All)]
        public void CreateRequest(String username, String password, string acctType , string custno)
        {
            LoginCust(username, password);
            driver.Value.FindElement(By.Id("btnRequests")).Click();
            driver.Value.FindElement(By.Id("btnRequestEntry")).Click();
            Thread.Sleep(1000);
            driver.Value.FindElement(By.Id("noah-webui-default-New")).Click();
            driver.Value.FindElement(By.CssSelector("#lugTranType .col-8 div")).Click();
            portallookups(acctType);
            Thread.Sleep(2000);
            driver.Value.FindElement(By.Id("idvallugLocForm")).SendKeys("BP01");
            driver.Value.FindElement(By.Id("idvallugLocForm")).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            driver.Value.FindElement(By.Id("txtField1")).SendKeys(custno);
            driver.Value.FindElement(By.Id("txtField6")).SendKeys("STRESSTESTING");//project
             
            driver.Value.FindElement(By.Id("noah-webui-default-Save")).Click();
            driver.Value.FindElement(By.Id("btnYes")).Click();
            Thread.Sleep(1000);
            driver.Value.FindElement(By.Id("btnOk")).Click();

            driver.Value.FindElement(By.Id("noah-webui-default-Process")).Click();
            Thread.Sleep(1000);
            driver.Value.FindElement(By.Id("btnYes")).Click();
            driver.Value.FindElement(By.Id("btnOk")).Click();


        }



    }
}
