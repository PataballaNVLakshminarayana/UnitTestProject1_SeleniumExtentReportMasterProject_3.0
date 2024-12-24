using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace UnitTestProject1_SeleniumExtentReportMasterProject_3._0
{
    [TestClass]
    public class UnitTest1_ExtentReportsSeries : WebDriverCallingPage
    {
        public TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }
        [AssemblyInitialize()]
        public static void AssemblyInit(TestContext context)
        {
            string directpath = @"D:\ExtentReports\" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".html";
            CreateEReport(directpath);
        }
        [AssemblyCleanup()]
        public static void AssemblyCleanup()
        {
            _EReports.Flush();
        }
        HomeLoginPage Homepage = new HomeLoginPage();
        WebDriverCallingPage Webcalling = new WebDriverCallingPage();
        //By _Username = By.Id("username");
        //By _Password = By.Id("password");
        //By _LoginBtn = By.Id("login");
        [TestInitialize()]
        public void TestInit()
        {
            //ExecutionBrowser = ConfigurationManager.AppSettings["ExecutionBrowser"].ToString();
            SeleniumInit();
            _Test = _EReports.CreateTest(TestContext.TestName);
        }
        [TestCleanup()]
        public  void TestCleanup()
        {
            CloseSeleniumInit();
        }
        [TestMethod]
        public void ExtentReport_Series()
        {
            //WebDriverCallingPage.SeleniumInit();
            Homepage.HomeLogin_Page("https://adactinhotelapp.com/", "nagalakshmin", "l@kshmin");
            //Homepage.HomeLogin_Page("https://adactinhotelapp.com/", "nagalakshmin", "l@kshmin");
            Thread.Sleep(10000);
            //_driver.Quit();
        }
    }
}
