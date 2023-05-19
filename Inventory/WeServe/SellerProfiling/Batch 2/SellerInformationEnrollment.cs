using NOAH.Utilities;
using NOAH.Workflow_Management;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOAH.WeServe.SellerProfiling.Batch_2
{
    public class SellerInformationEnrollment:BaseConfig
    {
        string TransNo,AppNo;
       
        public void InformationEntry(string branchcode, string lastname, string firstname, string birthdate, string tin)
        {
            this.Login("dpppasamonte", "noah123");
            this.targetproject = "NOAH";

            goToModule("Real Estate - Seller Profiling and Contracting (RESM)");

            //Select Menu Group
            driver.Value.FindElement(By.XPath(DataSetupLocator)).Click();


            //Select Sub Menu Group
            Actions a = new Actions(driver.Value);
            a.DoubleClick(driver.Value.FindElement(By.Id("nws-lista3"))).Perform();
            Thread.Sleep(2000);
            //Select Item Menu
            driver.Value.FindElement(By.Id("emi-TSMAPPLICANTSELLERINFORMATION")).Click();

            //Select Frame
            driver.Value.SwitchTo().Frame("emi-Form-SMAPPLICANTSELLERINFORMATION_xform");
            //Click New Button
            this.newButton();
            driver.Value.FindElement(By.Id("LookUplugAccrType")).Click();
            this.lookups("LB");

            driver.Value.FindElement(By.Id("txtBranchCode")).SendKeys(branchcode);

            driver.Value.FindElement(By.Id("LookUplugSalTitle")).Click();
            this.lookups("0002");
            Thread.Sleep(1000);
            driver.Value.FindElement(By.Id("txtLname")).SendKeys(lastname);
            Thread.Sleep(1000);
            driver.Value.FindElement(By.Id("txtFname")).SendKeys(firstname);
            Thread.Sleep(1000);
            driver.Value.FindElement(By.Id("txtBdate")).SendKeys(birthdate);

            driver.Value.FindElement(By.Id("LookUplugGender")).Click();
            this.lookups("1");

            driver.Value.FindElement(By.Id("LookUplugCivStatus")).Click();
            this.lookups("01");
            driver.Value.FindElement(By.Id("LookUplugNationality")).Click();
            this.lookups("FIL");
            driver.Value.FindElement(By.Id("LookUplugSrcApp")).Click();
            this.lookups("TESTONLY");
            Thread.Sleep(1000);
            driver.Value.FindElement(By.Id("txtMobile1")).SendKeys("09056421581");
            Thread.Sleep(1000);
            driver.Value.FindElement(By.Id("txtemail1")).SendKeys("dpppasamonte@federalland.ph");

            driver.Value.FindElement(By.Id("txtPERhouseno")).SendKeys("1234");
            driver.Value.FindElement(By.Id("txtPERDistrict")).SendKeys("1234");

            //driver.Value.FindElement(By.Id("LookUplugPERMunCity")).Click();
            //this.lookups("133906000");
            driver.Value.FindElement(By.Id("idvallugPERMunCity")).SendKeys("133906000");


            driver.Value.FindElement(By.Id("txtIndivTin")).SendKeys(tin);
            Thread.Sleep(2000);
            this.SaveButton();
            Thread.Sleep(2000);
            AppNo = driver.Value.FindElement(By.Id("txtApplicantNo")).GetAttribute("value");
            //driver.Value.FindElement(By.Id("noah-webui-default-Refresh")).Click();
            Thread.Sleep(1000);
            driver.Value.FindElement(By.Id("btnReqCompliance")).Click();
            Thread.Sleep(3000);

            driver.Value.SwitchTo().Frame(driver.Value.FindElement(By.CssSelector(".nwmenuFrame")));

            driver.Value.FindElement(By.CssSelector("#dataset0 td .nwCheckBox1")).Click();
            driver.Value.FindElement(By.CssSelector("#dataset0 td .txtDocno")).SendKeys("Doc 123");
            driver.Value.FindElement(By.Id("noah-webui-default-Save")).Click();
            driver.Value.FindElement(By.Id("Message_Yes")).Click();
            driver.Value.FindElement(By.Id("Message_Ok")).Click();
            Thread.Sleep(3500);
            //Select Frame
            driver.Value.SwitchTo().DefaultContent();
            //Select Frame
            driver.Value.SwitchTo().Frame("emi-Form-SMAPPLICANTSELLERINFORMATION_xform");

            driver.Value.FindElement(By.CssSelector("#nwPopUpReqComp .BoxClose")).Click();
            TransNo = driver.Value.FindElement(By.Id("txtTranNo")).GetAttribute("value");
            driver.Value.FindElement(By.Id("noah-webui-default-Process")).Click();
            driver.Value.FindElement(By.Id("Message_Ok")).Click();
            TestContext.WriteLine(TransNo);

        }


        public void ApplicantEngagementEntryFillp()
        {

            this.Login("dpppasamonte", "noah123");
            this.targetproject = "NOAH";

            goToModule("Real Estate - Seller Profiling and Contracting (RESM)");

            //Select Menu Group
            driver.Value.FindElement(By.XPath(DataSetupLocator)).Click();


            //Select Sub Menu Group
            Actions a = new Actions(driver.Value);
            a.DoubleClick(driver.Value.FindElement(By.Id("nws-lista3"))).Perform();
            Thread.Sleep(2000);
            //Select Item Menu
            driver.Value.FindElement(By.Id("emi-TSMAPPLICANTENGAGEMENTENTRY")).Click();

            //Select Frame
            driver.Value.SwitchTo().Frame(driver.Value.FindElement(By.Id("emi-Form-SMAPPLICANTENGAGEMENTENTRY_xform")));
            //Click New Button
            this.newButton();

            //APPLICANT NO
            driver.Value.FindElement(By.Id("LookUplugApplicant")).Click();
            this.lookups(AppNo);
            Thread.Sleep(1000);
            //ENTRY TYPE
            driver.Value.FindElement(By.Id("LookUplugEntryType")).Click();
            this.lookups("NEW");
            Thread.Sleep(1000);
            //SELLER CLASSIFICATION
            driver.Value.FindElement(By.Id("LookUplugSellerClasse")).Click();
            this.lookups("FL013");
            Thread.Sleep(1000);
            //SELLER ROLE
            driver.Value.FindElement(By.Id("LookUplugSellerRole")).Click();
            this.lookups("DH1");

            //LINEUP CODE
            driver.Value.FindElement(By.Id("LookUplugLineUp")).Click();
            this.lookups("1.2");

            //CONTRACT TYPE
            driver.Value.FindElement(By.Id("LookUplugContractType")).Click();
            this.lookups("001");

            //CONTRACT START DATE
            driver.Value.FindElement(By.Id("dtpContractStartDate")).SendKeys(DateTime.Now.ToString("MM/dd/yyyy"));

            //CONTRACT END DATE
            driver.Value.FindElement(By.Id("dtpContractStartDate")).SendKeys(30+DateTime.Now.ToString("MM/dd/yyyy"));

            this.SaveButton();



        }


        [Test]
        [TestCase("9100", "L9100", "L9100", "7191992", "579101314641")]
        [TestCase("9101", "L9101", "L9100", "7191992", "579101314642")]
        public void Stresstest(string branchcode, string lastname, string firstname, string birthdate, string tin)
        {
            InformationEntry(branchcode, lastname, firstname, birthdate, tin);
            this.Logout(this.targetproject);
            this.WFMApproval("cycamaclang", "noah123", TransNo);
            this.Logout(this.targetproject);
            ApplicantEngagementEntryFillp();

        }
    }
}
