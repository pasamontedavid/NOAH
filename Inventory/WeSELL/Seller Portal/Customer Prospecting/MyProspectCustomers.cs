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
    public class MyProspectCustomers:BaseConfig
    {

        [Test]
        
        [TestCase("julius", "Babao", "S-0000000037", "P@ssw0rd")]
        [TestCase("Mike", "Enriquez", "S-0000000037", "P@ssw0rd")]
        [TestCase("Mel", "Mel", "S-0000000037", "P@ssw0rd")]

        //[Parallelizable(ParallelScope.All)]
        public void AddIndividual(String Lname,String Fname,String Username, String Password)
        {

            targetproject = "SellerPortal";

            driver.Value.Url = "https://flinoahuat.federalland.ph/FLI_SellerPortalV10/Login?a=sdasdas2121dsf68j821dgdfyhikjhkj&bb=sdasdas2121dsf68j821dgdfyhikjhk&c=sdasdas2121dsf68j821dgdfyhikjhk&jauas=jaskdashdj23lkklj454545&nwdev=p8dev&jkskdjsfhdhfgdjf=deskskdsdsd&d=sdasdas2121dsf68j821dgdfyhikjhk&a2z4i7e=";
            driver.Value.FindElement(By.Id("txtUsername")).SendKeys(Username);
            driver.Value.FindElement(By.Id("txtPassword")).SendKeys(Password);
            driver.Value.FindElement(By.Id("Button1")).Click();
            Thread.Sleep(1000);
            driver.Value.FindElement(By.Id("btnCust")).Click();
            driver.Value.FindElement(By.Id("btnProspectCust")).Click();
            WebDriverWait wait = new WebDriverWait(driver.Value, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlContains("SBMyProspectCustomers"));
            String expURL = "https://flinoahuat.federalland.ph/FLI_SellerPortalV10/SBMyProspectCustomers";
            StringAssert.Contains(expURL, driver.Value.Url);
            driver.Value.FindElement(By.CssSelector(".btn-tb-new")).Click();
            driver.Value.FindElement(By.Id("lblIndividual")).Click(); //Customer Type
            driver.Value.FindElement(By.Id("lblNewInquiry")).Click();//Sales Tagging
            SelectElement CustClass = new SelectElement(driver.Value.FindElement(By.Id("cmbCustClass")));
            CustClass.SelectByText("Local");//customer classification
            driver.Value.FindElement(By.Id("txtLastName")).SendKeys(Lname);//lastname
            driver.Value.FindElement(By.Id("txtFirstName")).SendKeys(Fname);//firstname
            SelectElement Salutation = new SelectElement(driver.Value.FindElement(By.Id("cmbSalutation")));
            Salutation.SelectByText("Mr.");//Salutation
            SelectElement Gender = new SelectElement(driver.Value.FindElement(By.Id("cmbGender")));
            Gender.SelectByText("Male");//Gender
            driver.Value.FindElement(By.Id("txtIndivBday")).SendKeys("07/19/1996");//date of birth
            SelectElement CivilStatus = new SelectElement(driver.Value.FindElement(By.Id("cmbCivilStatus")));
            CivilStatus.SelectByText("Single");//Civil Status
            SelectElement Nationality = new SelectElement(driver.Value.FindElement(By.Id("cmbNationality")));
            Nationality.SelectByText("Philippines");//Nationality
            driver.Value.FindElement(By.Id("txtMobileNo")).SendKeys("09056421581");
            driver.Value.FindElement(By.Id("txtEmail")).SendKeys("bmdasuncion@federalland.ph");
            SelectElement Province = new SelectElement(driver.Value.FindElement(By.Id("cmbProvince")));
            Province.SelectByText("Isabela");
            SelectElement Municipality = new SelectElement(driver.Value.FindElement(By.Id("cmbMunicipality")));
            Municipality.SelectByText("City of Santiago");
            SelectElement Barangay = new SelectElement(driver.Value.FindElement(By.Id("cmbBarangay")));
            Barangay.SelectByText("Plaridel");
            driver.Value.FindElement(By.Id("txtZip")).SendKeys("3311");
            SelectElement HdykSeller = new SelectElement(driver.Value.FindElement(By.Id("cmbHDYKTSPI")));
            HdykSeller.SelectByText("Open House");
            SelectElement ReasonBuying = new SelectElement(driver.Value.FindElement(By.Id("cmbReasonForBuyingPI")));
            ReasonBuying.SelectByText("Primary Home");
            SelectElement DeliveryChannel = new SelectElement(driver.Value.FindElement(By.Id("cmbDevChanPI")));
            DeliveryChannel.SelectByText("Face to Face");
            driver.Value.FindElement(By.Id("lblYesNomi")).Click();
            driver.Value.FindElement(By.Id("btnOk")).Click();
            driver.Value.FindElement(By.CssSelector(".btn-tb-save")).Click();
            driver.Value.FindElement(By.Id("btnYes")).Click();
            Thread.Sleep(1000);
            //String successtxt = driver.Value.FindElement(By.CssSelector(".mdl-msg-txt")).Text;
            //StringAssert.Contains("Saved Successfully", successtxt);
            driver.Value.FindElement(By.Id("btnOk")).Click();
            Thread.Sleep(5000);
            driver.Value.FindElement(By.CssSelector(".btn-tb-process")).Click();
            driver.Value.FindElement(By.Id("btnYes")).Click();
            Thread.Sleep(1000);
            driver.Value.FindElement(By.Id("btnOk")).Click();

        }

    }
}
