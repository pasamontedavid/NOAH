using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NOAH.PageObjects.WeServe.MoveInAndTurnover
{
    public class QualifiedForMoveInReportPageObject
    {

        private IWebDriver driver;
        public QualifiedForMoveInReportPageObject(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        //MenuItem
        [FindsBy(How = How.Id, Using = "emi-Form-MIQUALIFIEDFORMOVEINREPORT_xform")]
        private IWebElement MenuItem;
        public IWebElement GotoMenuItem()
        {
            return MenuItem;
        }

        //Newbtn
        [FindsBy(How = How.Id, Using = "noah-webui-default-New")]
        private IWebElement Newbtn;
        public IWebElement GotoNewbtn()
        {
            return Newbtn;
        }

        //Refreshbtn
        [FindsBy(How = How.Id, Using = "noah-webui-default-Refresh")]
        private IWebElement Refreshbtn;
        public IWebElement GotoRefreshbtn()
        {
            return Refreshbtn;
        }

        //Exportbtn
        [FindsBy(How = How.Id, Using = "noah-webui-default-Export")]
        private IWebElement Exportbtn;
        public IWebElement GotoExportbtn()
        {
            return Exportbtn;
        }

        //Monthlyradio
        [FindsBy(How = How.Id, Using = "radioMonthly")]
        private IWebElement Monthlyradio;
        public IWebElement GotoMonthlyradio()
        {
            return Monthlyradio;
        }

        //Annualradio
        [FindsBy(How = How.Id, Using = "radioAnnual")]
        private IWebElement Annualradio;
        public IWebElement GotoAnnualradio()
        {
            return Annualradio;
        }

        //Quarterradio
        [FindsBy(How = How.Id, Using = "radioQuarter")]
        private IWebElement Quarterradio;
        public IWebElement GotoQuarterradio()
        {
            return Quarterradio;
        }

        //DateCoveredradio
        [FindsBy(How = How.Id, Using = "radioDate")]
        private IWebElement DateCoveredradio;
        public IWebElement GotoDateCoveredradio()
        {
            return DateCoveredradio;
        }

        //Monthdd
        [FindsBy(How = How.Id, Using = "cmbMonth")]
        private IWebElement Monthdd;
        public IWebElement GotoMonthdd()
        {
            return Monthdd;
        }

        //Annualdd
        [FindsBy(How = How.Id, Using = "cboAnnual")]
        private IWebElement Annualdd;
        public IWebElement GotoAnnualdd()
        {
            return Annualdd;
        }

        //Quarterdd
        [FindsBy(How = How.Id, Using = "cmbQuarter")]
        private IWebElement Quarterdd;
        public IWebElement GotoQuarterdd()
        {
            return Quarterdd;
        }

        //Datefromtxt
        [FindsBy(How = How.Id, Using = "txtDateFrom")]
        private IWebElement Datefromtxt;
        public IWebElement GotoDatefromtxt()
        {
            return Datefromtxt;
        }

        //Datetotxt
        [FindsBy(How = How.Id, Using = "txtDateTo")]
        private IWebElement Datetotxt;
        public IWebElement GotoDatetotxt()
        {
            return Datetotxt;
        }

        //Sortdd
        [FindsBy(How = How.Id, Using = "cmbSortBy")]
        private IWebElement Sortdd;
        public IWebElement GotoSortdd()
        {
            return Sortdd;
        }

        //Typedd
        [FindsBy(How = How.Id, Using = "cmbType")]
        private IWebElement Typedd;
        public IWebElement GotoTypedd()
        {
            return Typedd;
        }

        //LocationAcctFormNav
        [FindsBy(How = How.Id, Using = "ui-id-1")]
        private IWebElement LocationAcctFormNav;
        public IWebElement GotoLocationAcctFormNav()
        {
            return LocationAcctFormNav;
        }

        //TransactionNoNav
        [FindsBy(How = How.Id, Using = "ui-id-2")]
        private IWebElement TransactionNoNav;
        public IWebElement GotoTransactionNoNav()
        {
            return TransactionNoNav;
        }

        //CustomerNameNav
        [FindsBy(How = How.Id, Using = "ui-id-3")]
        private IWebElement CustomerNameNav;
        public IWebElement GotoCustomerNameNav()
        {
            return CustomerNameNav;
        }

        //ProjectNav
        [FindsBy(How = How.Id, Using = "ui-id-4")]
        private IWebElement ProjectNav;
        public IWebElement GotoProjectNav()
        {
            return ProjectNav;
        }

        //SaveColumnbtn
        [FindsBy(How = How.CssSelector, Using = ".nwgrid_SaveWidth")]
        private IWebElement SaveColumnbtn;
        public IWebElement GotoSaveColumnbtn()
        {
            return SaveColumnbtn;
        }

        //ResetColumnbtn
        [FindsBy(How = How.CssSelector, Using = ".nwgrid_ResetWidth")]
        private IWebElement ResetColumnbtn;
        public IWebElement GotoResetColumnbtn()
        {
            return ResetColumnbtn;
        }

        //HideHeaderbtn
        [FindsBy(How = How.CssSelector, Using = ".nwgrid_HeaderShowHide")]
        private IWebElement HideHeaderbtn;
        public IWebElement GotoHideHeaderbtn()
        {
            return HideHeaderbtn;
        }

        //SearchReporttxt
        [FindsBy(How = How.CssSelector, Using = ".nwgrid_SearchNext")]
        private IWebElement SearchReporttxt;
        public IWebElement GotoSearchReporttxt()
        {
            return SearchReporttxt;
        }

        //Findbtn
        [FindsBy(How = How.CssSelector, Using = ".nwgrid_SearchFind")]
        private IWebElement Findbtn;
        public IWebElement GotoFindbtn()
        {
            return Findbtn;
        }

    }
}
