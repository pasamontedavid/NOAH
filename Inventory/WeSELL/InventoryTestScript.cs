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

namespace Noah.WeSELL
{
    public class InventoryTestScript: BaseConfig
    {
        [Test]

        public void ItemGroupTypeAssignment()
        {
            this.Login("dpppasamonte", "noah123");
            String moduleName = "RE - Inventory";
            String XpathLocator = "(//div[normalize-space()='" + moduleName+ "'])[1]";
            //click module button 
            driver.Value.FindElement(By.XPath("(//div[normalize-space()='Modules'])[1]")).Click();

            //select module
            driver.Value.FindElement(By.XPath(XpathLocator)).Click();
            //check if in correct module
            StringAssert.Contains(driver.Value.FindElement(By.CssSelector(".etitle")).Text, moduleName.ToUpper());

        }

        [Test]
        public void OpenNoah()
        {
            //login
            driver.Value.FindElement(By.XPath("//input[@type='text']")).SendKeys("bmdasuncion");
            driver.Value.FindElement(By.XPath("//input[@type='password']")).SendKeys("noah123");
            driver.Value.FindElement(By.CssSelector("#Button1")).Click();

            //Thread.Sleep(10000);
            WebDriverWait wait = new WebDriverWait(driver.Value, TimeSpan.FromSeconds(10));
            String expURL = "https://flinoahuat.federalland.ph/FLI_app/home.aspx?a2z4i7e=";
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlContains(expURL));

            //click module button
            driver.Value.FindElement(By.XPath("(//div[normalize-space()='Modules'])[1]")).Click();

            //select module
            String moduleName = "Workflow Management (WFM)";
            String XpathLocator = "(//div[normalize-space()='" + moduleName+ "'])[1]";
            driver.Value.FindElement(By.XPath(XpathLocator)).Click();
            //Thread.Sleep(1000);
            //check if in correct module
            StringAssert.Contains(driver.Value.FindElement(By.CssSelector(".etitle")).Text, moduleName.ToUpper());
            //Select Menu Group
            driver.Value.FindElement(By.XPath(DataConfigurationLocator)).Click();
            //Select Sub Menu Group
            Actions a = new Actions(driver.Value);
            a.DoubleClick(driver.Value.FindElement(By.Id("nws-lista15"))).Perform();
            //Select Item Menu
            driver.Value.FindElement(By.Id("emi-TWFMTRANTYPEACTIVITYTYPE")).Click();
            Thread.Sleep(5000);

            //driver.SwitchTo(driver.FindElement(By.Id("emi-Form-WFMTRANTYPEACTIVITYTYPE_xform")));
            driver.Value.SwitchTo().Frame("emi-Form-WFMTRANTYPEACTIVITYTYPE_xform");
            driver.Value.FindElement(By.XPath("//div[@id='noah-webui-default-New']")).Click();
            driver.Value.FindElement(By.Id("noah-webui-default-Save")).Click();
            driver.Value.FindElement(By.Id("Message_Yes")).Click();
            




        }



        [Test]
        [TestCase("dldasig", "Passw0rd")]
        [TestCase("dldasig", "Passw0rd")]
        [TestCase("dldasig", "Passw0rd")]
        [TestCase("dldasig", "Passw0rd")]
        [TestCase("dldasig", "Passw0rd")]
        [TestCase("dldasig", "Passw0rd")]
        [TestCase("dldasig", "Passw0rd")]
        [TestCase("dldasig", "Passw0rd")]
        [TestCase("dldasig", "Passw0rd")]
        [TestCase("dldasig", "Passw0rd")]
        [TestCase("dldasig", "Passw0rd")]
        [TestCase("dldasig", "Passw0rd")]
        [TestCase("dldasig", "Passw0rd")]
        [TestCase("dldasig", "Passw0rd")]
        [TestCase("dldasig", "Passw0rd")]
        [TestCase("dldasig", "Passw0rd")]
        [TestCase("dldasig", "Passw0rd")]
        [TestCase("dldasig", "Passw0rd")]
        [TestCase("dldasig", "Passw0rd")]
        [TestCase("dldasig", "Passw0rd")]
        [TestCase("dldasig", "Passw0rd")]
        [TestCase("dldasig", "Passw0rd")]
        [TestCase("dldasig", "Passw0rd")]
        [TestCase("dldasig", "Passw0rd")]
        [TestCase("dldasig", "Passw0rd")]
        [TestCase("dldasig", "Passw0rd")]
        [TestCase("dldasig", "Passw0rd")]
        [TestCase("dldasig", "Passw0rd")]
        [TestCase("dldasig", "Passw0rd")]
        [TestCase("dldasig", "Passw0rd")]
        [TestCase("dldasig", "Passw0rd")]
        [TestCase("dldasig", "Passw0rd")]
        [TestCase("dldasig", "Passw0rd")]
        [TestCase("dldasig", "Passw0rd")]
        [TestCase("dldasig", "Passw0rd")]
        [TestCase("dldasig", "Passw0rd")]
        [TestCase("dldasig", "Passw0rd")]
        [TestCase("dldasig", "Passw0rd")]
        public void ParallelLogin(String username, String password)
        {
            targetproject = "NOAH";
            //login
            driver.Value.FindElement(By.XPath("//input[@type='text']")).SendKeys(username);
            driver.Value.FindElement(By.XPath("//input[@type='password']")).SendKeys(password);
            driver.Value.FindElement(By.CssSelector("#Button1")).Click();
            String expURL = "https://flinoahuat.federalland.ph/FLI_app/home.aspx?a2z4i7e=";

            WebDriverWait wait = new WebDriverWait(driver.Value, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlContains("home"));
            StringAssert.Contains(expURL, driver.Value.Url);
        }


        [Test]
        [TestCase("gmberba", "noah123")]
        [TestCase("gobuenaventura", "noah123")]
        [TestCase("gopava", "noah123")]
        [TestCase("grbernardino", "noah123")]
        [TestCase("gvsaunar", "noah123")]
        [TestCase("hntorino", "noah123")]
        [TestCase("hsyulo", "noah123")]
        [TestCase("iaabiva", "noah123")]
        [TestCase("iacpua", "noah123")]
        [TestCase("icustodio", "noah123")]
        [TestCase("iiafermin", "noah123")]
        [TestCase("irbvelasco", "noah123")]
        [TestCase("irjdeluna", "noah123")]
        [TestCase("jabbautista", "noah123")]
        [TestCase("jadigmayo", "noah123")]
        [TestCase("jadrocido", "noah123")]
        [TestCase("jamontiveros", "noah123")]
        [TestCase("jasantonio", "noah123")]
        [TestCase("jascanico", "noah123")]
        [TestCase("jasnovero", "noah123")]
        [TestCase("jasoliman", "noah123")]
        [TestCase("jatbailon", "noah123")]
        [TestCase("jbalba", "noah123")]
        [TestCase("jbhapin", "noah123")]
        [TestCase("jbmaragon", "noah123")]
        [TestCase("jbmoral", "noah123")]
        [TestCase("jcang", "noah123")]
        [TestCase("jcaquino", "noah123")]
        [TestCase("jcbelen", "noah123")]
        [TestCase("jccornelia", "noah123")]
        [TestCase("jcdeveza", "noah123")]
        [TestCase("jcebao", "noah123")]
        [TestCase("jchernandez", "noah123")]
        [TestCase("jclgarcia", "noah123")]
        [TestCase("jclumabi", "noah123")]
        [TestCase("jcsiador", "noah123")]
        [TestCase("jdrosales", "noah123")]
        [TestCase("jedelima", "noah123")]
        [TestCase("jegbautista", "noah123")]
        [TestCase("jehepistola", "noah123")]
        [TestCase("jfccabato", "noah123")]
        [TestCase("jfjasareno", "noah123")]
        [TestCase("jgbonsilao", "noah123")]
        [TestCase("jgdedel", "noah123")]
        [TestCase("jjalvaro", "noah123")]
        [TestCase("jjmumali", "noah123")]
        [TestCase("jjmvillafria", "noah123")]
        [TestCase("jjsfrancisco", "noah123")]
        [TestCase("jkscruz", "noah123")]
        [TestCase("jlajulian", "noah123")]
        [TestCase("jllaibale", "noah123")]
        [TestCase("jlmcerteza", "noah123")]
        [TestCase("jlpua", "noah123")]
        [TestCase("jlrosales", "noah123")]
        [TestCase("jmejareno", "noah123")]
        [TestCase("jmercado", "noah123")]
        [TestCase("jmquizana", "noah123")]
        [TestCase("jmrktanada", "noah123")]
        [TestCase("jmyumul", "noah123")]
        [TestCase("jocaneso", "noah123")]
        [TestCase("jpdicen", "noah123")]
        [TestCase("jphsamonte", "noah123")]
        [TestCase("jpnfojas", "noah123")]
        [TestCase("jpvalencia", "noah123")]
        [TestCase("jraantonio", "noah123")]
        [TestCase("jrcangeles", "noah123")]
        [TestCase("jrfmaristela", "noah123")]
        [TestCase("jrlsalas", "noah123")]
        [TestCase("jrqmalsi", "noah123")]
        [TestCase("jrrtolentino", "noah123")]
        [TestCase("jrsoriano", "noah123")]
        [TestCase("jrzgomez", "noah123")]
        [TestCase("jsccredo", "noah123")]
        [TestCase("jsjaravata", "noah123")]
        [TestCase("jspascaran", "noah123")]
        [TestCase("jsprangan", "noah123")]
        [TestCase("jsrsales", "noah123")]
        [TestCase("jssy", "noah123")]
        [TestCase("jstinamisan", "noah123")]
        [TestCase("jtestrella", "noah123")]
        [TestCase("jtfermato", "noah123")]
        [TestCase("jubdeo", "noah123")]
        [TestCase("jvtadique", "noah123")]
        [TestCase("jzspingol", "noah123")]
        [TestCase("kamperez", "noah123")]
        [TestCase("karceledonio", "noah123")]
        [TestCase("kasalvador", "noah123")]
        [TestCase("kbsdevicente", "noah123")]
        [TestCase("kddimaculangan", "noah123")]
        [TestCase("kfsborja", "noah123")]
        [TestCase("kghipolito", "noah123")]
        [TestCase("kjmguadalquiver", "noah123")]
        [TestCase("kjmhernando", "noah123")]
        [TestCase("kjrpineda", "noah123")]
        [TestCase("kmdelloma", "noah123")]
        [TestCase("kmlpaderes", "noah123")]
        [TestCase("kmvcabochan", "noah123")]
        [TestCase("kotonsay", "noah123")]
        [TestCase("kpmajuelo", "noah123")]
        [TestCase("kracasas", "noah123")]
        [TestCase("krpagbong", "noah123")]
        [TestCase("ksgaspay", "noah123")]
        [TestCase("laletaban", "noah123")]
        [TestCase("lanmagbitang", "noah123")]
        [TestCase("lbjordan", "noah123")]
        [TestCase("lcalongcop", "noah123")]
        [TestCase("lcdyico", "noah123")]
        [TestCase("lctugade", "noah123")]
        [TestCase("lmcabanilla", "noah123")]
        [TestCase("lmcrivas", "noah123")]
        [TestCase("lmsdelarosa", "noah123")]
        [TestCase("loabadilla", "noah123")]
        [TestCase("lobundoc", "noah123")]
        [TestCase("lpemascarina", "noah123")]
        [TestCase("lrubalde", "noah123")]
        [TestCase("lsumagang", "noah123")]
        [TestCase("lucruz", "noah123")]
        [TestCase("maacunanan", "noah123")]
        [TestCase("maamanlapat", "noah123")]
        [TestCase("macramos", "noah123")]
        [TestCase("madrosario", "noah123")]
        [TestCase("maggawaran", "noah123")]
        [TestCase("magonate", "noah123")]
        [TestCase("maguevarra", "noah123")]
        [TestCase("mamadayan", "noah123")]
        [TestCase("mamnavarro", "noah123")]
        [TestCase("mapastrana", "noah123")]
        [TestCase("masgosiengfiao", "noah123")]
        [TestCase("mbera", "noah123")]
        [TestCase("mbescamillan", "noah123")]
        [TestCase("mbmalbaciete", "noah123")]
        [TestCase("mcbfrancisco", "noah123")]
        [TestCase("mcdvalencia", "noah123")]
        [TestCase("mcgduenas", "noah123")]
        [TestCase("mclomod", "noah123")]
        [TestCase("mcmfernandez", "noah123")]
        [TestCase("mcmricamara", "noah123")]
        [TestCase("mcpacosta", "noah123")]
        [TestCase("mctsales", "noah123")]
        [TestCase("mdcarmona", "noah123")]
        [TestCase("mddmagat", "noah123")]
        [TestCase("mdprado", "noah123")]
        [TestCase("megredondo", "noah123")]
        [TestCase("meparana", "noah123")]
        [TestCase("mfgestuista", "noah123")]
        [TestCase("mgalegaspi", "noah123")]
        [TestCase("mgbadoy", "noah123")]
        [TestCase("mgccabibijan", "noah123")]
        [TestCase("mgdeleon", "noah123")]
        [TestCase("mgsalazar", "noah123")]
        [TestCase("mhcpacione", "noah123")]
        [TestCase("mhfullero", "noah123")]
        [TestCase("mipbasilio", "noah123")]
        [TestCase("mjalugo", "noah123")]
        [TestCase("mjcborillo", "noah123")]
        [TestCase("mjdellomes", "noah123")]
        [TestCase("mjeanjaquet", "noah123")]
        [TestCase("mjlluna", "noah123")]
        [TestCase("mjmnicol", "noah123")]
        [TestCase("mjtchan", "noah123")]
        [TestCase("mjvillamero", "noah123")]
        [TestCase("mkdmcervas", "noah123")]
        [TestCase("mkebobier", "noah123")]
        [TestCase("mlcacarranceja", "noah123")]
        [TestCase("mllsaclao", "noah123")]
        [TestCase("mlmalpis", "noah123")]
        [TestCase("mlpsicat", "noah123")]
        [TestCase("mlrdalisay", "noah123")]
        [TestCase("mlvbigueras", "noah123")]
        [TestCase("mmamusa", "noah123")]
        [TestCase("mmatienza", "noah123")]
        [TestCase("mmmendoza", "noah123")]
        [TestCase("mmsequerra", "noah123")]
        [TestCase("mmsresurreccion", "noah123")]
        [TestCase("mmvillaluz", "noah123")]
        [TestCase("mohfernandez", "noah123")]
        [TestCase("mramores", "noah123")]
        [TestCase("mrcpbaclig", "noah123")]
        [TestCase("mrdvijar", "noah123")]
        [TestCase("mrgconcon", "noah123")]
        [TestCase("mrlandicho", "noah123")]
        [TestCase("mrschavez", "noah123")]
        [TestCase("mtdelosreyes", "noah123")]
        [TestCase("mtsantiago", "noah123")]
        [TestCase("musanjuan", "noah123")]
        [TestCase("mvramirez", "noah123")]
        [TestCase("mymedina", "noah123")]
        [TestCase("mzamamangpang", "noah123")]
        [TestCase("mzsbundoc", "noah123")]
        [TestCase("nbtanquis", "noah123")]
        [TestCase("ndconcepcion", "noah123")]
        [TestCase("neguevarra", "noah123")]
        [TestCase("nhilagan", "noah123")]
        [TestCase("nicabungcal", "noah123")]
        [TestCase("nkppaderna", "noah123")]
        [TestCase("nmudtohan", "noah123")]
        [TestCase("ocbenedicto", "noah123")]
        [TestCase("ommvallarta", "noah123")]
        [TestCase("pabmarasigan", "noah123")]
        [TestCase("pabvisaya", "noah123")]
        [TestCase("pcdeleon", "noah123")]
        [TestCase("pcsandiego", "noah123")]
        [TestCase("pebeleno", "noah123")]
        [TestCase("pfgozo", "noah123")]
        [TestCase("pjbangeles", "noah123")]
        [TestCase("pltconte", "noah123")]
        [TestCase("pmdelmar", "noah123")]
        [TestCase("pmlparcon", "noah123")]
        [TestCase("pnmoralde", "noah123")]
        [TestCase("pvbliberato", "noah123")]
        [TestCase("raalcoy", "noah123")]
        [TestCase("racpascua", "noah123")]
        [TestCase("ragponio", "noah123")]
        [TestCase("raifrancisco", "noah123")]
        [TestCase("rastodomingo", "noah123")]
        [TestCase("raviguilla", "noah123")]
        [TestCase("rbdeclaro", "noah123")]
        [TestCase("rcdejesus", "noah123")]
        [TestCase("rclirasan", "noah123")]
        [TestCase("rcnaval", "noah123")]
        [TestCase("rcpanopio", "noah123")]
        [TestCase("rcparumog", "noah123")]
        [TestCase("rcquimson", "noah123")]
        [TestCase("rdmamaradlo", "noah123")]
        [TestCase("rdmendoza", "noah123")]
        [TestCase("rdsabalvaro", "noah123")]
        [TestCase("rggarcia", "noah123")]
        [TestCase("rhvidal", "noah123")]
        [TestCase("rjssoldevilla", "noah123")]
        [TestCase("rlquiñones", "noah123")]
        [TestCase("rmabad", "noah123")]
        [TestCase("rmechavaria", "noah123")]
        [TestCase("rmhayagan", "noah123")]
        [TestCase("rmlcabaltera", "noah123")]
        [TestCase("rmmmejia", "noah123")]
        [TestCase("rmmorate", "noah123")]
        [TestCase("rmmpastrana", "noah123")]
        [TestCase("rqestella", "noah123")]
        [TestCase("rqqueddeng", "noah123")]
        [TestCase("rrcanlas", "noah123")]
        [TestCase("rregos", "noah123")]
        [TestCase("rsabanares", "noah123")]
        [TestCase("rsrufo", "noah123")]
        [TestCase("rtlunar", "noah123")]
        [TestCase("rtpalanca", "noah123")]
        [TestCase("S-0000000001", "noah123")]
        [TestCase("S-0000000002", "noah123")]
        [TestCase("S-0000000003", "noah123")]
        [TestCase("S-0000000004", "noah123")]
        [TestCase("S-0000000005", "noah123")]
        [TestCase("S-0000000006", "noah123")]
        [TestCase("S-0000000007", "noah123")]
        [TestCase("S-0000000008", "noah123")]
        [TestCase("S-0000000009", "noah123")]
        [TestCase("sacastillo", "noah123")]
        [TestCase("samdelacruz", "noah123")]
        [TestCase("sanunez", "noah123")]
        [TestCase("scabanez", "noah123")]
        [TestCase("sfmendoza", "noah123")]
        [TestCase("slflordeliza", "noah123")]
        [TestCase("slmmanalo", "noah123")]
        [TestCase("slppena", "noah123")]
        [TestCase("slreguna", "noah123")]
        [TestCase("smafrando", "noah123")]
        [TestCase("smdbola", "noah123")]
        [TestCase("smmlawas", "noah123")]
        [TestCase("snkentote", "noah123")]
        [TestCase("stsamsin", "noah123")]
        [TestCase("tfmirasol", "noah123")]
        [TestCase("tjrportos", "noah123")]
        [TestCase("tlooperario", "noah123")]
        [TestCase("tobucasas", "noah123")]
        [TestCase("velanas", "noah123")]
        [TestCase("versarte", "noah123")]
        [TestCase("vrrevilla", "noah123")]
        [TestCase("vtcgarcia", "noah123")]
        [TestCase("wpferry", "noah123")]
        [TestCase("ysgatus", "noah123")]
        [TestCase("zmcasoberano", "noah123")]
        [TestCase("rcaragon", "noah123")]
        [TestCase("jgareniego", "noah123")]



        [Parallelizable(ParallelScope.All)]
        public void changepassword(String username, String password)
        {

            driver.Value.FindElement(By.Id("txtUsername")).Click();
            driver.Value.FindElement(By.Id("txtUsername")).SendKeys(username);
            driver.Value.FindElement(By.Id("txtPassword")).Click();
            driver.Value.FindElement(By.Id("txtPassword")).SendKeys(password);
            driver.Value.FindElement(By.Id("Button1")).Click();
            driver.Value.FindElement(By.Id("txtOldPass")).Click();
            driver.Value.FindElement(By.Id("txtOldPass")).SendKeys(password);
            driver.Value.FindElement(By.Id("txtNewPass")).SendKeys(password);
            driver.Value.FindElement(By.Id("txtConfirm")).SendKeys(password);
            driver.Value.FindElement(By.Id("btnChange")).Click();
            driver.Value.FindElement(By.CssSelector("#main_menuSystem > .toolBar-menu-label")).Click();
            driver.Value.FindElement(By.CssSelector(".nwHomeClick-007")).Click();
            driver.Value.FindElement(By.Id("Message_Yes")).Click();
            driver.Value.Close();
        }




        [Test]

        [TestCase("UAT1215001", "UAT TEST 1215001")]
        [TestCase("UAT1215002", "UAT TEST 1215002")]
        [TestCase("UAT1215003", "UAT TEST 1215003")]
        [TestCase("UAT1215004", "UAT TEST 1215004")]
        [TestCase("UAT1215005", "UAT TEST 1215005")]
        [TestCase("UAT1215006", "UAT TEST 1215006")]
        [TestCase("UAT1215007", "UAT TEST 1215007")]
        [TestCase("UAT1215008", "UAT TEST 1215008")]
        [TestCase("UAT1215009", "UAT TEST 1215009")]
        [TestCase("UAT1215010", "UAT TEST 1215010")]
        [TestCase("UAT1215011", "UAT TEST 1215011")]
        [TestCase("UAT1215012", "UAT TEST 1215012")]
        [TestCase("UAT1215013", "UAT TEST 1215013")]
        [TestCase("UAT1215014", "UAT TEST 1215014")]
        [TestCase("UAT1215015", "UAT TEST 1215015")]
        [TestCase("UAT1215016", "UAT TEST 1215016")]
        [TestCase("UAT1215017", "UAT TEST 1215017")]
        [TestCase("UAT1215018", "UAT TEST 1215018")]
        [TestCase("UAT1215019", "UAT TEST 1215019")]
        [TestCase("UAT1215020", "UAT TEST 1215020")]
        [TestCase("UAT1215021", "UAT TEST 1215021")]
        [TestCase("UAT1215022", "UAT TEST 1215022")]
        [TestCase("UAT1215023", "UAT TEST 1215023")]
        [TestCase("UAT1215024", "UAT TEST 1215024")]
        [TestCase("UAT1215025", "UAT TEST 1215025")]
        [TestCase("UAT1215026", "UAT TEST 1215026")]
        [TestCase("UAT1215027", "UAT TEST 1215027")]
        [TestCase("UAT1215028", "UAT TEST 1215028")]
        [TestCase("UAT1215029", "UAT TEST 1215029")]
        [TestCase("UAT1215030", "UAT TEST 1215030")]
        [TestCase("UAT1215031", "UAT TEST 1215031")]
        [TestCase("UAT1215032", "UAT TEST 1215032")]
        [TestCase("UAT1215033", "UAT TEST 1215033")]
        [TestCase("UAT1215034", "UAT TEST 1215034")]
        [TestCase("UAT1215035", "UAT TEST 1215035")]
        [TestCase("UAT1215036", "UAT TEST 1215036")]
        [TestCase("UAT1215037", "UAT TEST 1215037")]
        [TestCase("UAT1215038", "UAT TEST 1215038")]
        [TestCase("UAT1215039", "UAT TEST 1215039")]
        [TestCase("UAT1215040", "UAT TEST 1215040")]
        [TestCase("UAT1215041", "UAT TEST 1215041")]
        [TestCase("UAT1215042", "UAT TEST 1215042")]
        [TestCase("UAT1215043", "UAT TEST 1215043")]
        [TestCase("UAT1215044", "UAT TEST 1215044")]
        [TestCase("UAT1215045", "UAT TEST 1215045")]
        [TestCase("UAT1215046", "UAT TEST 1215046")]
        [TestCase("UAT1215047", "UAT TEST 1215047")]
        [TestCase("UAT1215048", "UAT TEST 1215048")]
        [TestCase("UAT1215049", "UAT TEST 1215049")]
        [TestCase("UAT1215050", "UAT TEST 1215050")]

        public void Step1_ProjectProfileProfitCenter(String Code,String Desc)
        {

            
            ArrayList Level = new ArrayList();
            String[] Step4CodeList = { "test01", "test02", "test03" };
            String[] Step4DescList = { "Description 1", "Description 2", "Description 3" };
            String ProjectTagValue = "Horizontal";

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

    }
}
