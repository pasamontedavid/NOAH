using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NOAH.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V105.DOM;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NOAH.WeServe.SellerProfiling
{
    public class CreationOfNewApplicantfromSalesAdmin:BaseConfig
    {

        String TransNo;


       [Test]
        [TestCase("BC901", "LNAME 1000", "FNAME 1000", "7191943", "579100314572")]
        [TestCase("BC902", "LNAME 1001", "FNAME 1001", "7191944", "579100314573")]
        [TestCase("BC9031", "LNAME 1022", "FNAME 1022", "7191945", "579100314584")]
        [TestCase("BC904", "LNAME 1003", "FNAME 1003", "7191946", "579100314575")]
        [TestCase("BC905", "LNAME 1004", "FNAME 1004", "7191947", "579100314576")]
        [TestCase("BC906", "LNAME 1005", "FNAME 1005", "7191948", "579100314577")]
        [TestCase("BC907", "LNAME 1006", "FNAME 1006", "7191949", "579100314578")]
        [TestCase("BC908", "LNAME 1007", "FNAME 1007", "7191950", "579100314579")]
        [TestCase("BC909", "LNAME 1008", "FNAME 1008", "7191951", "579100314580")]
        [TestCase("BC910", "LNAME 1009", "FNAME 1009", "7191952", "579100314581")]
        [TestCase("BC911", "LNAME 1010", "FNAME 1010", "7191953", "579100314582")]
        [TestCase("BC912", "LNAME 1011", "FNAME 1011", "7191954", "579100314583")]
        [TestCase("BC913", "LNAME 1012", "FNAME 1012", "7191955", "579100314584")]
        [TestCase("BC914", "LNAME 1013", "FNAME 1013", "7191956", "579100314585")]
        [TestCase("BC915", "LNAME 1014", "FNAME 1014", "7191957", "579100314586")]
        [TestCase("BC916", "LNAME 1015", "FNAME 1015", "7191958", "579100314587")]
        [TestCase("BC917", "LNAME 1016", "FNAME 1016", "7191959", "579100314588")]
        [TestCase("BC918", "LNAME 1017", "FNAME 1017", "7191960", "579100314589")]
        [TestCase("BC919", "LNAME 1018", "FNAME 1018", "7191961", "579100314590")]
        [TestCase("BC920", "LNAME 1019", "FNAME 1019", "7191962", "579100314591")]
        [TestCase("BC921", "LNAME 1020", "FNAME 1020", "7191963", "579100314592")]
        [TestCase("BC922", "LNAME 1021", "FNAME 1021", "7191964", "579100314593")]
        [TestCase("BC923", "LNAME 1022", "FNAME 1022", "7191965", "579100314594")]
        [TestCase("BC924", "LNAME 1023", "FNAME 1023", "7191966", "579100314595")]
        [TestCase("BC925", "LNAME 1024", "FNAME 1024", "7191967", "579100314596")]
        [TestCase("BC926", "LNAME 1025", "FNAME 1025", "7191968", "579100314597")]
        [TestCase("BC927", "LNAME 1026", "FNAME 1026", "7191969", "579100314598")]
        [TestCase("BC928", "LNAME 1027", "FNAME 1027", "7191970", "579100314599")]
        [TestCase("BC929", "LNAME 1028", "FNAME 1028", "7191971", "579100314600")]
        [TestCase("BC930", "LNAME 1029", "FNAME 1029", "7191972", "579100314601")]
        [TestCase("BC931", "LNAME 1030", "FNAME 1030", "7191973", "579100314602")]
        [TestCase("BC932", "LNAME 1031", "FNAME 1031", "7191974", "579100314603")]
        [TestCase("BC933", "LNAME 1032", "FNAME 1032", "7191975", "579100314604")]
        [TestCase("BC934", "LNAME 1033", "FNAME 1033", "7191976", "579100314605")]
        [TestCase("BC935", "LNAME 1034", "FNAME 1034", "7191977", "579100314606")]
        [TestCase("BC936", "LNAME 1035", "FNAME 1035", "7191978", "579100314607")]
        [TestCase("BC937", "LNAME 1036", "FNAME 1036", "7191979", "579100314608")]
        [TestCase("BC938", "LNAME 1037", "FNAME 1037", "7191980", "579100314609")]
        [TestCase("BC939", "LNAME 1038", "FNAME 1038", "7191981", "579100314610")]
        [TestCase("BC940", "LNAME 1039", "FNAME 1039", "7191982", "579100314611")]
        [TestCase("BC941", "LNAME 1040", "FNAME 1040", "7191983", "579100314612")]
        [TestCase("BC942", "LNAME 1041", "FNAME 1041", "7191984", "579100314613")]
        [TestCase("BC943", "LNAME 1042", "FNAME 1042", "7191985", "579100314614")]
        [TestCase("BC944", "LNAME 1043", "FNAME 1043", "7191986", "579100314615")]
        [TestCase("BC945", "LNAME 1044", "FNAME 1044", "7191987", "579100314616")]
        [TestCase("BC946", "LNAME 1045", "FNAME 1045", "7191988", "579100314617")]
        [TestCase("BC947", "LNAME 1046", "FNAME 1046", "7191989", "579100314618")]
        [TestCase("BC948", "LNAME 1047", "FNAME 1047", "7191990", "579100314619")]
        [TestCase("BC949", "LNAME 1048", "FNAME 1048", "7191991", "579100314620")]
        [TestCase("BC953", "Pasamonte3", "David3", "7191992", "579100314624")]




        public void fillup(string branchcode,string lastname, string firstname, string birthdate, string tin)
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
        public string getTransNo()
        {
            return TransNo;
        }

    }
}
