using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1_SeleniumExtentReportMasterProject_3._0
{
    public class WebDriverCallingPage
    {
        public static IWebDriver _driver;
        public static string ExecutionBrowser { get; set; }
        public static ExtentReports _EReports;
        public static ExtentTest _Test;
        public static ExtentTest _Step;

        //public static void createReport(string resultpath)
        //{
        //    _EReports = new ExtentReports();
        //   var directpath = @resultpath;
        //    var sparkReporter = new ExtentSparkReporter(directpath);
        //    _EReports.AttachReporter(sparkReporter);
        //}
        public static void CloseSeleniumInit()
        {
            _driver.Close();
            _driver.Quit();
            _driver.Dispose();
        }
        public static void CreateEReport(string Filename)
        {
            _EReports = new ExtentReports();
            var directpath = @Filename;
            var sparkReporter = new ExtentSparkReporter(directpath);
            _EReports.AttachReporter(sparkReporter);
        }
        public static IWebDriver SeleniumInit()
        {
            IWebDriver Chrome_driver = new ChromeDriver();
            _driver = Chrome_driver;
            return _driver;
        }
        //public static void CaptureScreenshot(Status status, string stepDetais )
        //{
        //    string path= @"D:\ExtentReports\" + DateTime.Now.ToString("yymmddhhmmss") + ".png";
        //    Screenshot screenshot= ((ITakesScreenshot)_driver).GetScreenshot();
        //    File.WriteAllBytes(path, screenshot.AsByteArray);
        //    _Step.Log(status, stepDetais, MediaEntityBuilder.CreateScreenCaptureFromPath(path).Build());
        //}
    }
}
