using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Configuration;
using System.Net.Http;
using System.Threading;

namespace UnitTestProject1_SeleniumExtentReportMasterProject_3._0
{
    [TestClass]
    public class UnitTest1_ExtentReportsSeries : WebDriverCallingPage
    {
        HomeLoginPage Homepage = new HomeLoginPage();
        WebDriverCallingPage Webcalling = new WebDriverCallingPage();
        SearchHotelPage Searchpage = new SearchHotelPage();
        //private static HttpClient _httpClient;
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
        [TestInitialize()]
        public void TestInit()
        {
            //ExecutionBrowser = ConfigurationManager.AppSettings["ExecutionBrowser"].ToString();
            _Test = _EReports.CreateTest(TestContext.TestName);
        }
        //[TestCleanup()]
        //public  void TestCleanup()
        //{
        //    CloseSeleniumInit();
        //}

        [TestMethod]
        public void HomeLoginPage_Series()
        {
            WebDriverCallingPage.SeleniumInit();
            Homepage.HomeLogin_Page("https://adactinhotelapp.com/", "nagalakshmin", "l@kshmin");
            WebDriverCallingPage.TakeScreenshot(AventStack.ExtentReports.Status.Pass,"the test case is passed");
            Thread.Sleep(10000);
            _driver.Quit();
        }
        //[TestMethod]
        //public void SearchHotelPage_Series()
        //{
        //   WebDriverCallingPage.SeleniumInit();
        //    Homepage.HomeLogin_Page("https://adactinhotelapp.com/", "nagalakshmin", "l@kshmin");
        //    Searchpage.Search_Page();
        //    Thread.Sleep(10000);
        //    _driver.Quit();
        //}
         
    }
}
