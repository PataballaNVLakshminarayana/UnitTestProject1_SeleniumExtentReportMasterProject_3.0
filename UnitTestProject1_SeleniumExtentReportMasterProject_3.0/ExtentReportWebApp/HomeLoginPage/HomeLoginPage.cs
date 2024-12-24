using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Configuration;
using System.Threading;

namespace UnitTestProject1_SeleniumExtentReportMasterProject_3._0
{
    public class HomeLoginPage : WebDriverCallingPage
    {
        //public TestContext instance;
        //public TestContext TestContext
        //{
        //    set { instance = value; }
        //    get { return instance; }
        //}
        //[AssemblyInitialize()]
        //public static void AssemblyInitialize(TestContext TestContext)
        //{
        //    string resultpath = @"D:\ExtentReports\" + DateTime.Now.ToString("yyyyMMdd_HHmmss") +".html";
        //    createReport(resultpath);
        //}
        //[AssemblyCleanup()]
        //public static void AssemblyCleanup()
        //{
        //    _EReports.Flush();
        //}
        //[TestInitialize()]
        //public void TestInit()
        //{
        //    //ExecutionBrowser = ConfigurationManager.AppSettings["ExecutionBrowser"].ToString();
        //    SeleniumInit();
        //    _Test = _EReports.CreateTest(TestContext.TestName);
        //}
        //[TestCleanup()]
        //public void TestClean()
        //{
        //    CloseSeleniumInit();
        //}
        
        By _Username = By.Id("username");
        By _Password = By.Id("password");
        By _LoginBtn = By.Id("login");

        public void HomeLogin_Page(string _url, string username,string password)
        {
             //_Step = _Test.CreateNode("HomeLogin_Page");
            _driver.Navigate().GoToUrl(_url);//
            //CaptureScreenshot();
            _driver.Manage().Window.Maximize();
            _driver.FindElement(_Username).SendKeys(username);//
            _driver.FindElement(_Password).SendKeys(password);//
            _driver.FindElement(_LoginBtn).Click();
            Thread.Sleep(10000);
            _driver.Quit();
        }
    }
}
