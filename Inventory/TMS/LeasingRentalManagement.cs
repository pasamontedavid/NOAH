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

namespace NOAH.TMS
{
    public class LeasingRentalManagement:BaseConfig
    {
        [Test]
        [TestCase("BP01-2000000000384", "POS01")]
        

        public void POSAssignement(String ContractNo, String POS)
        {
            this.Login("dpppasamonte","noah123");
            driver.Value.FindElement(By.Id("main_menuModule")).Click();//Click Module in Nav
            driver.Value.FindElement(By.CssSelector(".txt-search-submenu-module")).SendKeys("Leasing/Rental Management (LERM)");//Input for module
            driver.Value.FindElement(By.Id("noahwebApp-LERM")).Click();//selecting module
            driver.Value.FindElement(By.XPath(this.DataSetupLocator)).Click();//click data setup
            driver.Value.FindElement(By.CssSelector("#nws-lista50 .emi-buttonCollapse")).Click();//collapse sub menu
            driver.Value.FindElement(By.CssSelector("#emi-LERMPOSASSIGNMENT #emi-TLERMPOSASSIGNMENT")).Click();//click menu item
            driver.Value.SwitchTo().Frame("emi-Form-LERMPOSASSIGNMENT_xform");//switch frame
            this.newButton();//click new button
            driver.Value.FindElement(By.CssSelector("#lugContractNo #LookUplugContractNo")).Click();//open lookup
            this.lookups(ContractNo);//select item in lookup Contract No
            driver.Value.FindElement(By.CssSelector("#lugKey #btnKey")).Click();//generate key button
            driver.Value.FindElement(By.CssSelector("#nwGrid-nwData #dataset0 td .nwgInput")).SendKeys("testPOS");//input POS
            driver.Value.FindElement(By.CssSelector("#nwGrid-nwData #dataset0 td .txt_API")).Click();
            //driver.Value.FindElement(By.CssSelector("#nwGrid-nwData #dataset0 td .txt_FTP")).Click();
            IWebElement Setactive = driver.Value.FindElement(By.CssSelector("#nwGrid-nwData #dataset0 td .txtActive"));
            SelectElement setActive = new SelectElement(Setactive);
            setActive.SelectByText("YES");
            this.SaveButton();
        }

    }
}
