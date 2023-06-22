using NOAH.PageObjects.WeServe.MoveInAndTurnover;
using NOAH.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using RazorEngine.Compilation.ImpromptuInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOAH.WeServe.MoveInAndTurnover
{
    public class QualifiedForMoveInReport:BaseConfig
    {
        [Test]

        public void InitialOpen()
        {
            this.Login("dpppasamonte", "noah123");
            this.targetproject = "NOAH";

            goToModule("Property Sales - Turnover and Move-In (REMI)");
            //Menu Group
            driver.Value.FindElement(By.XPath(ReportsAndInquiryLocator)).Click();
            //Sub-Menu Group
            Actions a = new Actions(driver.Value);
            a.DoubleClick(driver.Value.FindElement(By.Id("nws-lista6"))).Perform();
            Thread.Sleep(2000);
            driver.Value.FindElement(By.Id("emi-TMIQUALIFIEDFORMOVEINREPORT")).Click();
            QualifiedForMoveInReportPageObject objects = new QualifiedForMoveInReportPageObject(driver.Value);

            driver.Value.SwitchTo().Frame(objects.GotoMenuItem());

            

        }

    }
}
