using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NOAH.Utilities;
using System.Threading.Channels;
using RazorEngine.Compilation.ImpromptuInterface;

namespace NOAH.WeSELL.Seller_Portal.LOI
{
    public class LOI_Transaction:BaseConfig
    {
        [Test]
        
        [TestCase("li-P0025400000021P1", ".lvl-b-box #boxcont div:nth-child(1) .lvl-c-lbl", "S-0000000008", "P@ssw0rd")]
        [TestCase("li-P0025400000021P1", ".lvl-b-box #boxcont div:nth-child(1) .lvl-c-lbl", "S-0000000009", "P@ssw0rd")]
        [TestCase("li-P0025400000021P1", ".lvl-b-box #boxcont div:nth-child(1) .lvl-c-lbl", "S-0000000010", "P@ssw0rd")]
        [TestCase("li-P0025400000021P1", ".lvl-b-box #boxcont div:nth-child(1) .lvl-c-lbl", "S-0000000011", "P@ssw0rd")]
        [TestCase("li-P0025400000021P1", ".lvl-b-box #boxcont div:nth-child(1) .lvl-c-lbl", "S-0000000012", "P@ssw0rd")]
        [TestCase("li-P0025400000021P1", ".lvl-b-box #boxcont div:nth-child(1) .lvl-c-lbl", "S-0000000013", "P@ssw0rd")]
        [TestCase("li-P0025400000021P1", ".lvl-b-box #boxcont div:nth-child(1) .lvl-c-lbl", "S-0000000014", "P@ssw0rd")]
        [TestCase("li-P0025400000021P1", ".lvl-b-box #boxcont div:nth-child(1) .lvl-c-lbl", "S-0000000015", "P@ssw0rd")]
        [TestCase("li-P0025400000021P1", ".lvl-b-box #boxcont div:nth-child(1) .lvl-c-lbl", "S-0000000016", "P@ssw0rd")]
        [TestCase("li-P0025400000021P1", ".lvl-b-box #boxcont div:nth-child(1) .lvl-c-lbl", "S-0000000017", "P@ssw0rd")]
        [TestCase("li-P0025400000021P1", ".lvl-b-box #boxcont div:nth-child(1) .lvl-c-lbl", "S-0000000018", "P@ssw0rd")]
        [TestCase("li-P0025400000021P1", ".lvl-b-box #boxcont div:nth-child(1) .lvl-c-lbl", "S-0000000020", "P@ssw0rd")]
        [TestCase("li-P0025400000021P1", ".lvl-b-box #boxcont div:nth-child(1) .lvl-c-lbl", "S-0000000021", "P@ssw0rd")]
        [TestCase("li-P0025400000021P1", ".lvl-b-box #boxcont div:nth-child(1) .lvl-c-lbl", "S-0000000022", "P@ssw0rd")]
        [TestCase("li-P0025400000021P1", ".lvl-b-box #boxcont div:nth-child(1) .lvl-c-lbl", "S-0000000023", "P@ssw0rd")]
        [TestCase("li-P0025400000021P1", ".lvl-b-box #boxcont div:nth-child(1) .lvl-c-lbl", "S-0000000024", "P@ssw0rd")]
        [TestCase("li-P0025400000021P1", ".lvl-b-box #boxcont div:nth-child(1) .lvl-c-lbl", "S-0000000025", "P@ssw0rd")]
        [TestCase("li-P0025400000021P1", ".lvl-b-box #boxcont div:nth-child(1) .lvl-c-lbl", "S-0000000026", "P@ssw0rd")]
        [TestCase("li-P0025400000021P1", ".lvl-b-box #boxcont div:nth-child(1) .lvl-c-lbl", "S-0000000027", "P@ssw0rd")]
        [TestCase("li-P0025400000021P1", ".lvl-b-box #boxcont div:nth-child(1) .lvl-c-lbl", "S-0000000028", "P@ssw0rd")]
        [TestCase("li-P0025400000021P1", ".lvl-b-box #boxcont div:nth-child(1) .lvl-c-lbl", "S-0000000029", "P@ssw0rd")]
        [TestCase("li-P0025400000021P1", ".lvl-b-box #boxcont div:nth-child(1) .lvl-c-lbl", "S-0000000030", "P@ssw0rd")]
        [TestCase("li-P0025400000021P1", ".lvl-b-box #boxcont div:nth-child(1) .lvl-c-lbl", "S-0000000031", "P@ssw0rd")]
        [TestCase("li-P0025400000021P1", ".lvl-b-box #boxcont div:nth-child(1) .lvl-c-lbl", "S-0000000032", "P@ssw0rd")]
        [TestCase("li-P0025400000021P1", ".lvl-b-box #boxcont div:nth-child(1) .lvl-c-lbl", "S-0000000033", "P@ssw0rd")]
        [TestCase("li-P0025400000021P1", ".lvl-b-box #boxcont div:nth-child(1) .lvl-c-lbl", "S-0000000034", "P@ssw0rd")]
        [TestCase("li-P0025400000021P1", ".lvl-b-box #boxcont div:nth-child(1) .lvl-c-lbl", "S-0000000035", "P@ssw0rd")]
        [TestCase("li-P0025400000021P1", ".lvl-b-box #boxcont div:nth-child(1) .lvl-c-lbl", "S-0000000036", "P@ssw0rd")]
        [TestCase("li-P0025400000021P1", ".lvl-b-box #boxcont div:nth-child(1) .lvl-c-lbl", "S-0000000037", "P@ssw0rd")]
        [TestCase("li-P0025400000021P1", ".lvl-b-box #boxcont div:nth-child(1) .lvl-c-lbl", "S-0000000039", "P@ssw0rd")]
        [TestCase("li-P0025400000021P1", ".lvl-b-box #boxcont div:nth-child(1) .lvl-c-lbl", "S-0000000040", "P@ssw0rd")]
        [TestCase("li-P0025400000021P1", ".lvl-b-box #boxcont div:nth-child(1) .lvl-c-lbl", "S-0000000041", "P@ssw0rd")]
        [TestCase("li-P0025400000021P1", ".lvl-b-box #boxcont div:nth-child(1) .lvl-c-lbl", "S-0000000042", "P@ssw0rd")]
        [TestCase("li-P0025400000021P1", ".lvl-b-box #boxcont div:nth-child(1) .lvl-c-lbl", "S-0000000043", "P@ssw0rd")]
        [TestCase("li-P0025400000021P1", ".lvl-b-box #boxcont div:nth-child(1) .lvl-c-lbl", "S-0000000044", "P@ssw0rd")]
        [TestCase("li-P0025400000021P1", ".lvl-b-box #boxcont div:nth-child(1) .lvl-c-lbl", "S-0000000045", "P@ssw0rd")]
        [TestCase("li-P0025400000021P1", ".lvl-b-box #boxcont div:nth-child(1) .lvl-c-lbl", "S-0000000046", "P@ssw0rd")]
        [TestCase("li-P0025400000021P1", ".lvl-b-box #boxcont div:nth-child(1) .lvl-c-lbl", "S-0000000047", "P@ssw0rd")]
        [TestCase("li-P0025400000021P1", ".lvl-b-box #boxcont div:nth-child(1) .lvl-c-lbl", "S-0000000048", "P@ssw0rd")]
        [TestCase("li-P0025400000021P1", ".lvl-b-box #boxcont div:nth-child(1) .lvl-c-lbl", "S-0000000049", "P@ssw0rd")]
        [TestCase("li-P0025400000021P1", ".lvl-b-box #boxcont div:nth-child(1) .lvl-c-lbl", "S-0000000050", "P@ssw0rd")]

        //[Parallelizable(ParallelScope.All)]
        public void AddIndividual(String Project, string Unit, String Username, String Password)
        {

            targetproject = "SellerPortal";

            driver.Value.Url = "https://flinoahuat.federalland.ph/FLI_SellerPortalV10/Login?a=sdasdas2121dsf68j821dgdfyhikjhkj&bb=sdasdas2121dsf68j821dgdfyhikjhk&c=sdasdas2121dsf68j821dgdfyhikjhk&jauas=jaskdashdj23lkklj454545&nwdev=p8dev&jkskdjsfhdhfgdjf=deskskdsdsd&d=sdasdas2121dsf68j821dgdfyhikjhk&a2z4i7e=";
            driver.Value.FindElement(By.Id("txtUsername")).SendKeys(Username);
            driver.Value.FindElement(By.Id("txtPassword")).SendKeys(Password);
            driver.Value.FindElement(By.Id("Button1")).Click();
            Thread.Sleep(1000);
            driver.Value.FindElement(By.Id("btnHome")).Click();
            driver.Value.FindElement(By.Id("btnLOI")).Click();
            Thread.Sleep(1000);
            driver.Value.FindElement(By.Id("btnLOI")).Click();
            driver.Value.FindElement(By.Id("btnHome")).Click();
            Thread.Sleep(1000);

            driver.Value.FindElement(By.Id(Project)).Click();
            Thread.Sleep(1000);
            driver.Value.FindElement(By.CssSelector(Unit)).Click();
            Thread.Sleep(3000);
            driver.Value.FindElement(By.Id("btnLOIEnt")).Click();
            
            Thread.Sleep(5000);

            driver.Value.SwitchTo().Frame("iFrame1");
            driver.Value.FindElement(By.Id("btnCustClassification")).Click();
            
            driver.Value.FindElement(By.CssSelector("#dimTableLookUpCon tbody tr:nth-child(2)")).Click();
            Thread.Sleep(2000);
            driver.Value.FindElement(By.Id("btnProsCustomer")).Click();
            Thread.Sleep(2000);
            driver.Value.FindElement(By.CssSelector("#dimTableLookUpCon tbody tr:nth-child(1)")).Click();
            Thread.Sleep(2000);
            driver.Value.FindElement(By.Id("btnHoldingType")).Click();
            Thread.Sleep(2000);
            driver.Value.FindElement(By.Id("txtlookupsearchF")).SendKeys("013");
            driver.Value.FindElement(By.Id("nkbtnsearch")).Click();
            Thread.Sleep(2000);
            driver.Value.FindElement(By.CssSelector("#dimTableLookUpCon tbody tr:nth-child(1)")).Click();
            driver.Value.FindElement(By.CssSelector(".btn-tb-save")).Click();
            driver.Value.FindElement(By.Id("btnYes")).Click();
            Thread.Sleep(1000);
            driver.Value.FindElement(By.Id("btnOk")).Click();
            Thread.Sleep(5000);
            driver.Value.FindElement(By.CssSelector(".btn-tb-process")).Click();
            driver.Value.FindElement(By.Id("btnYes")).Click();
            Thread.Sleep(1000);
            driver.Value.FindElement(By.Id("btnOk")).Click();
            driver.Value.SwitchTo().ParentFrame();
            driver.Value.FindElement(By.CssSelector("#popup div .btn-cancel")).Click();
        }

    }
}
