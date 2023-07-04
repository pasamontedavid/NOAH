using NOAH.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using RazorEngine.Compilation.ImpromptuInterface.Dynamic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOAH.Workflow_Management
{
    public class Approval:BaseConfig
    {
        [Test]
        [TestCase("cycamaclang","noah123", "BP0100000-APPACC-0000000186")]

        public void Approvals(String username, String password, String transno)
        {
            this.Login(username,password);
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
            driver.Value.FindElement(By.Id("noah-webui-default-Refresh")).Click();
            Thread.Sleep(3000);
            driver.Value.FindElement(By.CssSelector("#dataset0 td:nth-child(2) .chkapprove")).Click();
            this.Processbtn();
        }



        [Test]
        [TestCase("samplethea321@gmail.com", "TestSampleEmail123!")]
        [TestCase("samplethea456@gmail.com", "TestSampleEmail123!")]
        [TestCase("samplethea654@gmail.com", "TestSampleEmail123!")]
        [TestCase("samplethea234@gmail.com", "TestSampleEmail123!")]
        [TestCase("samplethea345@gmail.com", "TestSampleEmail123!")]
        [TestCase("samplethea1234@gmail.com", "TestSampleEmail123!")]
        [Parallelizable(ParallelScope.All)]
        public void QNELOGIN(String Email,String Pwd)
        {
            driver.Value.Url="https://account.qne.cloud/";
            driver.Value.FindElement(By.CssSelector(".ant-input-lg")).Click();
            driver.Value.FindElement(By.CssSelector(".ant-input-lg")).SendKeys(Email);
            driver.Value.FindElement(By.CssSelector(".ng-untouched")).Click();
            driver.Value.FindElement(By.CssSelector(".ng-untouched")).SendKeys(Pwd);
            driver.Value.FindElement(By.CssSelector(".ant-btn")).Click();

            String popupmsg = driver.Value.FindElement(By.CssSelector("div[class='alain-default__aside-user-info'] div")).Text;
            StringAssert.Contains(Email,popupmsg);
        }

        [Test]
        public void executer()
        {
            driver.Value.Url = "https://account.qne.cloud/";
            driver.Value.FindElement(By.CssSelector(".ant-input-lg")).Click();
            driver.Value.FindElement(By.CssSelector(".ant-input-lg")).SendKeys("samplethea1234@gmail.com");
            driver.Value.FindElement(By.CssSelector(".ng-untouched")).Click();
            driver.Value.FindElement(By.CssSelector(".ng-untouched")).SendKeys("TestSampleEmail123!");
            driver.Value.FindElement(By.CssSelector(".ant-btn")).Click();
        }


    }
}
