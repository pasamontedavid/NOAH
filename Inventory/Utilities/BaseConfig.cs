using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.UI;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using OpenQA.Selenium.Interactions;
using System.Security.Cryptography.X509Certificates;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium.DevTools.V105.Page;
using Microsoft.Extensions.Options;

namespace NOAH.Utilities
{
    public class BaseConfig
    {
        public ExtentReports EXTENTREPORTS;
        public ExtentTest test;
        public String targetproject="";
        //report
        [OneTimeSetUp]
        public void reportSetup()
        {
            string WorkDirectory = Environment.CurrentDirectory;
            string ProjectDirectory = Directory.GetParent(WorkDirectory).Parent.Parent.FullName;
            string TestreportPATH= ProjectDirectory + "//TestReport.html";
            var htmlReporter = new ExtentHtmlReporter(TestreportPATH);
            EXTENTREPORTS = new ExtentReports();
            EXTENTREPORTS.AttachReporter(htmlReporter);
            EXTENTREPORTS.AddSystemInfo("Name", "NOAH WeSELL");
            EXTENTREPORTS.AddSystemInfo("Host Name", "https://flinoahuat.federalland.ph/FLI_app/home.aspx?a2z4i7e=");
            EXTENTREPORTS.AddSystemInfo("Environtment", "UAT");
            EXTENTREPORTS.AddSystemInfo("Tester", "David Philip Pasamonte");

        }


        public ThreadLocal<IWebDriver> driver = new ThreadLocal<IWebDriver>();
        public String moduleName;

        public String DataConfigurationLocator = "(//div[@class='emi-icons143'][normalize-space()='Data Configuration'])[1]";
        public String DataSetupLocator = "(//div[@class='emi-icons143'][normalize-space()='Data Setup'])[1]";
        public String DocumentEntryLocator = "//div[contains(text(),'Document Entry')]";
        public String ReportsAndInquiryLocator = "//div[contains(text(),'Reports and Inquiry')]";



        [SetUp]
        public void OpenBrowser()
        {
           test= EXTENTREPORTS.CreateTest(TestContext.CurrentContext.Test.Name);
            //setup chrome driver 
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("window-size=1920,1080");
            //chromeOptions.AddArguments("headless");
            driver.Value = new ChromeDriver(ChromeDriverService.CreateDefaultService(), chromeOptions, TimeSpan.FromMinutes(3));

            driver.Value.Manage().Window.Maximize();
            driver.Value.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            driver.Value.Url = "https://flinoahuat.federalland.ph/FLI_app/?a2z4i7e=";
            //driver.Url = "https://flinoahuat.federalland.ph/FLI_app/login?a=sdasdas2121dsf68j821dgdfyhikjhkj&bb=sdasdas2121dsf68j821dgdfyhikjhk&c=sdasdas2121dsf68j821dgdfyhikjhk&jauas=jaskdashdj23lkklj454545&nwdev=p8dev&jkskdjsfhdhfgdjf=deskskdsdsd&d=sdasdas2121dsf68j821dgdfyhikjhk&a2z4i7e=";
            //if(targetproject == "SellerPortal")
            //{
            //    Thread.Sleep(180000);
            //}
        }
        public void goToModule(String moduleName)
        {
            //click module button
            driver.Value.FindElement(By.XPath("(//div[normalize-space()='Modules'])[1]")).Click();


            String XpathLocator = "(//div[normalize-space()='" + moduleName + "'])[1]";
            driver.Value.FindElement(By.XPath(XpathLocator)).Click();

            //check if in correct module
            StringAssert.Contains(driver.Value.FindElement(By.CssSelector(".etitle")).Text, moduleName.ToUpper());

        }

        public void Login(String username, String password) 
        {
            //login
            driver.Value.FindElement(By.XPath("//input[@type='text']")).SendKeys(username);
            driver.Value.FindElement(By.XPath("//input[@type='password']")).SendKeys(password);
            driver.Value.FindElement(By.CssSelector("#Button1")).Click();
            String expURL = "https://flinoahuat.federalland.ph/FLI_app/home.aspx?a2z4i7e=";

            WebDriverWait wait = new WebDriverWait(driver.Value, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlContains("home"));
            //StringAssert.Contains(expURL, driver.Value.Url);


        }
        public void portallookups(String value)
        {
            //lookup actions
            driver.Value.FindElement(By.Id("txtlookupsearchF")).SendKeys(value); //Search Input
            driver.Value.FindElement(By.Id("txtlookupsearchF")).SendKeys(Keys.Enter);
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(driver.FindElement(By.CssSelector(".LookUpRefresh"))));
            Thread.Sleep(2000);
            driver.Value.FindElement(By.CssSelector(".lookuprow:nth-child(1) td:nth-child(2)")).Click();
        }


        public void lookups(String value)
        {
            //lookup actions
            driver.Value.FindElement(By.Id("txtlookupsearch")).SendKeys(value); //Search Input
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(driver.FindElement(By.CssSelector(".LookUpRefresh"))));
            Thread.Sleep(2000);
            driver.Value.FindElement(By.CssSelector(".LookUpRefresh")).Click();
            Thread.Sleep(3000);
            driver.Value.FindElement(By.CssSelector(".nwLoopUpTableCon tbody tr:nth-child(2)")).Click();
            Thread.Sleep(2000);

        }

        public void lookupscheckbox(String value)
        {
            //lookup actions
            driver.Value.FindElement(By.Id("txtlookupsearch")).SendKeys(value); //Search Input
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(driver.FindElement(By.CssSelector(".LookUpRefresh"))));
            Thread.Sleep(2000);
            driver.Value.FindElement(By.CssSelector(".LookUpRefresh")).Click();
            Thread.Sleep(1000);
            driver.Value.FindElement(By.CssSelector(".nwLoopUpTableCon tbody tr:nth-child(2)")).Click();
            driver.Value.FindElement(By.Id("LookUpAddtoList")).Click();

        }

        public void ProcessButton()
        {
            driver.Value.FindElement(By.Id("noah-webui-default-Process")).Click();
            driver.Value.FindElement(By.Id("Message_Yes")).Click();
            driver.Value.FindElement(By.Id("Message_Ok")).Click();
        }


        public void newButton()
        {
            driver.Value.FindElement(By.XPath("//div[@id='noah-webui-default-New']")).Click();
        }

        public void SaveButton()
        {
            //Save
            //Save button
            //Save
            driver.Value.FindElement(By.CssSelector("#noah-webui-default-Save .noah-webui-Toolbox-Item-Title")).Click();
            driver.Value.FindElement(By.Id("Message_Yes")).Click();
            Thread.Sleep(2000);
            String ActualMessage = driver.Value.FindElement(By.CssSelector("#dimMessageBox .message_content")).Text;
            StringAssert.Contains("Saved successfully", ActualMessage);
            driver.Value.FindElement(By.Id("Message_Ok")).Click();
        }
        public void Processbtn()
        {

            driver.Value.FindElement(By.Id("noah-webui-default-Process")).Click();
            driver.Value.FindElement(By.Id("Message_Yes")).Click();
            driver.Value.FindElement(By.Id("Message_Ok")).Click();
        }

        public void SystemGlobalModule()
        {
            //select module
             moduleName = "Systems Global (SG)";
            String XpathLocator = "(//div[normalize-space()='" + moduleName + "'])[1]";
            driver.Value.FindElement(By.XPath(XpathLocator)).Click();
        }

        public void Modulechecker(String moduleName)
        {
            StringAssert.Contains(driver.Value.FindElement(By.CssSelector(".etitle")).Text, moduleName.ToUpper());
        }

        public void moduleButton()
        {
            //click module button
            driver.Value.FindElement(By.XPath("(//div[normalize-space()='Modules'])[1]")).Click();
        }

        public void CodeTextInput(String value)
        {
            driver.Value.FindElement(By.Id("txtCode")).SendKeys(value);
        }

        public void DescriptionTextInput(String value)
        {
            driver.Value.FindElement(By.Id("txtDescription")).SendKeys(value);
        }

        public void NoSeriesTextInput(String value)
        {
            driver.Value.FindElement(By.Id("txtNoSeries")).SendKeys(value);
            Thread.Sleep(1000);
        }

        public void ItemMasterSubModule()
        {
            //Select Sub Menu Group
            Actions a = new Actions(driver.Value);
            a.DoubleClick(driver.Value.FindElement(By.Id("nws-lista47"))).Perform();
            Thread.Sleep(2000);
        }
        public void ItemGroupTypeAssignmentSubModule()
        {
            //Select Sub Menu Group
            Actions a = new Actions(driver.Value);
            a.DoubleClick(driver.Value.FindElement(By.Id("nws-lista8"))).Perform();
            Thread.Sleep(2000);
        }

        public void SaveLockButton()
        {
            driver.Value.FindElement(By.Id("btnSaveLock")).Click();
            driver.Value.FindElement(By.Id("Message_Yes")).Click();
            driver.Value.FindElement(By.Id("Message_Ok")).Click();
        }

        public void Logout(String target)
        {
            if (target == "NOAH")
            {
                driver.Value.SwitchTo().ParentFrame();
                driver.Value.FindElement(By.Id("main_menuSystem")).Click();
                driver.Value.FindElement(By.CssSelector(".nwHomeClick-007")).Click();
                driver.Value.FindElement(By.Id("Message_Yes")).Click();
            }
            else if (target == "SellerPortal")
            {
                driver.Value.SwitchTo().ParentFrame();
                driver.Value.FindElement(By.CssSelector(".nav-user-name")).Click();
                driver.Value.FindElement(By.LinkText("Logout")).Click();
                Thread.Sleep(1000);

            }else if(target == "CustomerPortal")
            {
                driver.Value.FindElement(By.Id("btnNavUser")).Click();
                driver.Value.FindElement(By.Id("btnLogoutF")).Click();
                Thread.Sleep(1000);
            }


        }

        public void PropertySalesInventoryModule()
        {
            moduleName = "Property Sales - Inventory (REIV)";
            String XpathLocator = "(//div[normalize-space()='" + moduleName + "'])[1]";
            driver.Value.FindElement(By.XPath(XpathLocator)).Click();
        }

        [TearDown]
        public void close()
        {
            var testresult = TestContext.CurrentContext.Result.Outcome.Status;
            var stacktrace = TestContext.CurrentContext.Result.StackTrace;
            var Messagelog = TestContext.CurrentContext.Result.Message;
            String filename = "Screenshot" + DateTime.Now.ToString("h_mm_ss") + ".png";
            if(testresult == TestStatus.Failed)
            {
                test.Fail("TEST FAILED", captureScreenShot(driver.Value, filename) );
                test.Log(Status.Info,"LOGTRACE" + stacktrace);
                if (Messagelog != null)
                {
                    test.Log(Status.Fail, "Message: " + Messagelog);
                }
            }else if (testresult == TestStatus.Passed)
            {
                test.Pass("TEST PASSED", captureScreenShot(driver.Value, filename));
                if (Messagelog != null)
                {
                    test.Log(Status.Pass, "Message: " + Messagelog);
                }
            }
           
            Logout(targetproject);
            Thread.Sleep(3000);
            EXTENTREPORTS.Flush();
            driver.Value.Quit();
            
        }

        public MediaEntityModelProvider captureScreenShot(IWebDriver driver, String ScreenshotName)
        {

            ITakesScreenshot ts = (ITakesScreenshot)driver;
            var screenshot = ts.GetScreenshot().AsBase64EncodedString;
           return MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenshot, ScreenshotName).Build();
        }


        public void WFMApproval(String username, String password, String transno)
        {
            this.Login(username, password);
            goToModule("Workflow Management (WFM)");
            driver.Value.FindElement(By.Id("nw-list4")).Click();

            //Select Sub Menu Group
            Actions a = new Actions(driver.Value);
            a.DoubleClick(driver.Value.FindElement(By.Id("nw-lista2"))).Perform();
            Thread.Sleep(2000);
            //Select Item Menu
            driver.Value.FindElement(By.Id("emi-TWFMAPPROVALTRAN")).Click();

            //Select Frame
            driver.Value.SwitchTo().Frame(driver.Value.FindElement(By.Id("emi-Form-WFMAPPROVALTRAN_xform")));
            this.newButton();
            Thread.Sleep(2000);
            driver.Value.FindElement(By.CssSelector("#settingstabsBut-2 a")).Click();
            driver.Value.FindElement(By.CssSelector("#atl_TransactionNo:nth-child(1)")).Click();
            this.lookupscheckbox(transno);
            Thread.Sleep(2000);
            driver.Value.FindElement(By.Id("noah-webui-default-Refresh")).Click();
            Thread.Sleep(3000);
            driver.Value.FindElement(By.CssSelector("#dataset0 td:nth-child(2) .chkapprove")).Click();
            this.Processbtn();
        }
    }
}
