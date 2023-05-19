using NOAH.Utilities;
using OpenQA.Selenium;
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

namespace NOAH.WeSELL

{
    public class Scenario1_ProjectBuildUp : BaseConfig
    {
        String Code = "UAT0126002", Desc = "UAT TEST 0126002";
        ArrayList Level = new ArrayList();
        String[] Step4CodeList = {"test01","test02", "test03" };
        String[] Step4DescList = { "Description 1", "Description 2", "Description 3" };
        String ProjectTagValue = "Horizontal";








        [Test]
        public void Step1_ProjectProfileProfitCenter()
        {
            this.Login("dpppasamonte", "noah123");
            //click module button
            driver.Value.FindElement(By.XPath("(//div[normalize-space()='Modules'])[1]")).Click();

            //select module
            String moduleName = "Systems Global (SG)";
            String XpathLocator = "(//div[normalize-space()='" + moduleName + "'])[1]";
            driver.Value.FindElement(By.XPath(XpathLocator)).Click();

            //check if in correct module
            StringAssert.Contains(driver.Value.FindElement(By.CssSelector(".etitle")).Text, moduleName.ToUpper());

            //Select Menu Group
            driver.Value.FindElement(By.XPath(DataSetupLocator)).Click();


            //Select Sub Menu Group
            Actions a = new Actions(driver.Value);
            a.DoubleClick(driver.Value.FindElement(By.Id("nws-lista52"))).Perform();
            Thread.Sleep(2000);
            //Select Item Menu
            driver.Value.FindElement(By.Id("emi-TSGSegment3")).Click();

            //Select Frame
            driver.Value.SwitchTo().Frame("emi-Form-SGSegment3_xform");
            //Click New Button
            this.newButton();

            //fillup
            driver.Value.FindElement(By.Id("txtCode")).SendKeys(Code);
            driver.Value.FindElement(By.Id("txtDescription")).SendKeys(Desc);
            driver.Value.FindElement(By.Id("txtShortDesc")).SendKeys(DateTime.Now.ToString());

            //Process
            //this.ProcessButton();


            //Save button
            //Save
            SaveButton();
            driver.Value.SwitchTo().ParentFrame();
            

        }


        [Test]

        public void Step2_ItemGroupTypeProjectType()
        {
            String  NoSeries="6", ItemGroup = "INVY",Receiving= "162100", Issuance= "112000", CashFlow= "INC_TAX_PAID";
            
            this.Login("dpppasamonte", "noah123");
            this.moduleButton();
            this.SystemGlobalModule();

            this.Modulechecker(moduleName);
            //Select Menu Group
            driver.Value.FindElement(By.XPath(DataSetupLocator)).Click();

            //Select Sub Menu Group
            Actions a = new Actions(driver.Value);
            a.DoubleClick(driver.Value.FindElement(By.Id("nws-lista47"))).Perform();
            Thread.Sleep(2000);
            //Select Item Menu
            driver.Value.FindElement(By.Id("emi-TSGItemGroupType")).Click();

            //Select Frame
            driver.Value.SwitchTo().Frame("emi-Form-SGItemGroupType_xform");

            //click new button
            this.newButton();

            //Code Input
            this.CodeTextInput(Code);

            //Description Input
            this.DescriptionTextInput(Desc);

            //Item Group Lookup
            driver.Value.FindElement(By.XPath("//div[@id='lugItemGroup'] /button")).Click();
            this.lookups(ItemGroup);

            //No. Series Input
            //driver.FindElement(By.Id("txtNoSeries")).SendKeys(NoSeries);
            this.NoSeriesTextInput(NoSeries);
            StringAssert.Contains(NoSeries, driver.Value.FindElement(By.Id("txtNoSeries")).GetAttribute("value"));



            //lookup Receiving
            driver.Value.FindElement(By.XPath("//div[@id='lugReceiving'] /button")).Click();
            this.lookups(Receiving);

            //lookup Receiving
            driver.Value.FindElement(By.XPath("//div[@id='lugIssuance'] /button")).Click();
            this.lookups(Issuance);

            //lookup Cashflow
            driver.Value.FindElement(By.XPath("//div[@id='lugCashFlow'] /button")).Click();
            this.lookups(CashFlow);

            //Save button
            this.SaveButton();
            driver.Value.SwitchTo().ParentFrame();


        }

        [Test]

        public void Step3_ItemGroupTypeConfiguration()
        {
            String ItemGroupType = Code;
            this.Login("dpppasamonte", "noah123");
            this.moduleButton();
            this.SystemGlobalModule();

            this.Modulechecker(moduleName);
            //Select Menu Group
            driver.Value.FindElement(By.XPath(DataSetupLocator)).Click();
            this.ItemMasterSubModule();
            //Select Item Menu
            driver.Value.FindElement(By.Id("emi-TSGItemConfiguration")).Click();
            //Switch Frame
            driver.Value.SwitchTo().Frame("emi-Form-SGItemConfiguration_xform");
            //Item Group Type Lookup
            driver.Value.FindElement(By.XPath("//div[@id='lugStock'] /button")).Click();
            this.lookups(ItemGroupType);
            Thread.Sleep(1000); 
            //Level Inputs
            for(int i = 1; i <= 10; i++)
            {
                String locator = "txtLevel"+ i.ToString();
                String SendValue = "Sample Level " + i.ToString();
                driver.Value.FindElement(By.Id(locator)).SendKeys(SendValue);
                Level.Add(SendValue);
                
            }

            this.SaveLockButton();
            driver.Value.SwitchTo().ParentFrame();




        }


        [Test]

        public void Step4_ItemClassification()
        {
            String CodeLocator;
            Level.Add("Sample Level 2");
            this.Login("dpppasamonte", "noah123");
            this.moduleButton();
            this.SystemGlobalModule();
            this.Modulechecker(moduleName);
            //Select Menu Group
            driver.Value.FindElement(By.XPath(DataSetupLocator)).Click();
            this.ItemMasterSubModule();


            //Select Item Menu
            driver.Value.FindElement(By.Id("emi-TSGItemClassification")).Click();
            //Switch Frame
            driver.Value.SwitchTo().Frame("emi-Form-SGItemClassification_xform");

            this.newButton();

            //Item Group Type Lookup
            driver.Value.FindElement(By.XPath("//div[@id='lugGroupType'] /button")).Click();
            this.lookups(Code);

            //Level Lookup
            driver.Value.FindElement(By.XPath("//div[@id='lugLevel'] /button")).Click();
            this.lookups(Level[0].ToString());
            Thread.Sleep(2000);

            driver.Value.FindElement(By.XPath("//table[@id='grid1-nwData']/tbody/tr[@id='neercs1']/td[2]")).Click();
            for (int a = 1; a < Step4CodeList.Count(); a++)
            {
                driver.Value.FindElement(By.Id("btnAddRow")).Click();
            }

            

            IList <IWebElement> CodeInputs = driver.Value.FindElements(By.XPath("//table[@id='grid1-nwData']/tbody/tr"));
                if (CodeInputs.Count < 1)
                {
                //Code input
                driver.Value.FindElement(By.XPath("//table[@id='grid1-nwData']/tbody/tr[@id='neercs1']/td[2]")).Click();
                driver.Value.FindElement(By.XPath("//table[@id='grid1-nwData']/tbody/tr[@id='neercs1']/td[2]/input")).SendKeys(Code);


                //Description Input
                driver.Value.FindElement(By.XPath("//table[@id='grid1-nwData']/tbody/tr[@id='neercs1']/td[3]")).Click();
                driver.Value.FindElement(By.XPath("//table[@id='grid1-nwData']/tbody/tr[@id='neercs1']/td[3]/input")).SendKeys(Code + Level[0]);

                    
                }
                else
                {
                    for(int i = 0; i < CodeInputs.Count; i++)
                    {
                        int tablerow = i + 1;
                    //Code input
                    driver.Value.FindElement(By.XPath("//table[@id='grid1-nwData']/tbody/tr["+ tablerow + "]/td[2]")).Click();
                    driver.Value.FindElement(By.XPath("//table[@id='grid1-nwData']/tbody/tr[" + tablerow + "]/td[2]/input")).SendKeys(Step4CodeList[i]);

                    //Description Input
                    driver.Value.FindElement(By.XPath("//table[@id='grid1-nwData']/tbody/tr["+ tablerow + "]/td[3]")).Click();
                    driver.Value.FindElement(By.XPath("//table[@id='grid1-nwData']/tbody/tr[" + tablerow + "]/td[3]/input")).SendKeys(Step4DescList[i]);
                    }
                }

            this.SaveButton();

            driver.Value.SwitchTo().ParentFrame();



            //TestContext.WriteLine(CodeInputs.Count);


            // driver.FindElements(By.XPath("(//input[@class='nwgInput nwCode'])"));



            //(//input[@class='nwgInput nwCode'])[3]
            //td[@class='gridDesc nwDescription gridTxt']//input


        }

        [Test]
        public void Step5_ItemGroupTypeAssignment()
        {

            this.Login("dpppasamonte", "noah123");
            this.moduleButton();
            this.PropertySalesInventoryModule();
            this.Modulechecker(moduleName);
            //Select Menu Group
            driver.Value.FindElement(By.XPath(DataConfigurationLocator)).Click();
            this.ItemGroupTypeAssignmentSubModule();

            //Select Item Menu
            driver.Value.FindElement(By.Id("emi-TIVITEMGROUPTYPEASSIGNMENT")).Click();
            //Switch Frame
            driver.Value.SwitchTo().Frame("emi-Form-IVITEMGROUPTYPEASSIGNMENT_xform");

            IList<IWebElement> Rows = driver.Value.FindElements(By.XPath("//table[@id='nwGridCon-nwData']/tbody/tr"));
            Actions a = new Actions(driver.Value);




            a.DoubleClick(driver.Value.FindElement(By.XPath("//table[@id='nwGridCon-nwData']/tbody/tr[" + Rows.Count + "]/td[@data-label='Item Group Type Code']"))).Perform();
            this.lookupscheckbox(Code);
            this.SaveButton();
            //Project tagging Horizontal/Vertical
            a.MoveToElement(driver.Value.FindElement(By.XPath("//table[@id='nwGridCon-nwData']/tbody/tr[10]/td[@data-label='Project Tagging']"))).Perform();
            IWebElement ProjectTagging = driver.Value.FindElement(By.XPath("//table[@id='nwGridCon-nwData']/tbody/tr[" + Rows.Count + "]/td[@data-label='Project Tagging']/select"));
            SelectElement ProjectTag = new SelectElement(ProjectTagging);
            ProjectTag.SelectByText(ProjectTagValue);



            this.SaveButton();
            driver.Value.SwitchTo().ParentFrame();

            


        }




        [Test]

        public void Step6_ProjectProfile()
        {
            this.Login("dpppasamonte","noah123");

            WebDriverWait wait = new WebDriverWait(driver.Value, TimeSpan.FromSeconds(10));
            String expURL = "https://flinoahuat.federalland.ph/FLI_app/home.aspx?a2z4i7e=";
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlContains(expURL));

            //click module button
            driver.Value.FindElement(By.XPath("(//div[normalize-space()='Modules'])[1]")).Click();

            //select module
            String moduleName = "Property Sales - Inventory (REIV)";
            String XpathLocator = "(//div[normalize-space()='" + moduleName + "'])[1]";
            driver.Value.FindElement(By.XPath(XpathLocator)).Click();

            //check if in correct module
            StringAssert.Contains(driver.Value.FindElement(By.CssSelector(".etitle")).Text, moduleName.ToUpper());

            //Select Menu Group
            driver.Value.FindElement(By.XPath(DataSetupLocator)).Click();

            //Select Sub Menu Group
            Actions a = new Actions(driver.Value);
            a.DoubleClick(driver.Value.FindElement(By.Id("nws-lista32"))).Perform();
            Thread.Sleep(2000);
            //Select Item Menu
            driver.Value.FindElement(By.Id("emi-TIVPROJECT")).Click();

            //Select Frame
            driver.Value.SwitchTo().Frame("emi-Form-IVPROJECT_xform");

            //Click NEW Button
            driver.Value.FindElement(By.XPath("//div[@id='noah-webui-default-New']")).Click();

            //Project Lookup
            driver.Value.FindElement(By.XPath("//div[@id='lugProject'] /button")).Click();//Click Lookup button

            //lookup actions
            this.lookups("P001510000");

            //Project Type Lookup
            driver.Value.FindElement(By.XPath("//div[@id='lugProjectType'] /button")).Click();//Click Lookup button

            ////lookup actions
            this.lookups("INVCONDO");


            //Location/Branch Lookup
            driver.Value.FindElement(By.XPath("//div[@id='lugLocation'] /button")).Click();//Click Lookup button

            //lookup actions
            this.lookups("S01J00000");




            //FullAddress lookup
            driver.Value.FindElement(By.XPath("//div[@id='lugFullAddress'] /button")).Click();//Click Lookup button

            //lookup actions
            this.lookups("137404010");

            //Save
            SaveButton();


            driver.Value.SwitchTo().ParentFrame();

        }

    }
}
