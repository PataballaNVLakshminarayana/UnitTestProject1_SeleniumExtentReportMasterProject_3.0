using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Configuration;
using System.Threading;

namespace UnitTestProject1_SeleniumExtentReportMasterProject_3._0
{
    public class SearchHotelPage : WebDriverCallingPage
    {
        //By _LocationDropdown = By.Id("location");
        //By _HotelDropdown = By.Id("hotels");
        //By _RoomTypeDropdown = By.Id("room_type");
        //By _RoomCountDropdown = By.Id("room_nos");
        //By _CheckIn = By.Id("datepick_in");
        //By _CheckOut = By.Id("datepick_out");
        //By _AdultsRoomDropdown = By.Id("adult_room");
        //By _ChildrenRoomDropdown = By.Id("child_room");
        //By _SubmintBtn = By.Id("Submit");
        ////By _ResetBtn = By.Id("Reset");

        public void Search_Page()
        {
             //_Step = _Test.CreateNode("HomeLogin_Page");
            //_driver.Navigate().GoToUrl(_url);//
            //CaptureScreenshot();
           // _driver.Manage().Window.Maximize();
            _driver.FindElement(By.Id("location")).SendKeys("Sydney");
            _driver.FindElement(By.Id("hotels")).SendKeys("Hotel Hervey");
            _driver.FindElement(By.Id("room_type")).SendKeys("standard");
            _driver.FindElement(By.Id("room_nos")).SendKeys("2 - Two");
            _driver.FindElement(By.Id("datepick_in")).SendKeys("08/07/2021");
            _driver.FindElement(By.Id("datepick_out")).SendKeys("09/07/2021");
            _driver.FindElement(By.Id("adult_room")).SendKeys("2 - Two");
            _driver.FindElement(By.Id("child_room")).SendKeys("2 - Two");
            _driver.FindElement(By.Id("Submit")).Click();
            //_driver.FindElement(_ResetBtn).Click();
            Thread.Sleep(10000);
            _driver.Quit();
        }
    }
}
