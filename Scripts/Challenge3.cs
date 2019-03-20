using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace automationpractice
{
    [TestClass]
    public class Challenge3
    {
        IWebDriver driver;

        

        [TestInitialize]
        public void TestInitialize()
        {
            driver = new ChromeDriver();

        }



        [TestMethod]
        public void TestMethod1()
        {

            Homepage homePage = new Homepage(driver);
            homePage.GoToPage();            
            homePage.ClickOnContackLink();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            ContactUs1 contactUsPage = new ContactUs1(driver);
            contactUsPage.FillContactUsForm("email@gol.com", " 102030", "message 123");
            string value = contactUsPage.GetSuccessMessage();
            Assert.AreEqual("Your message has been successfully sent to our team.",value );
        }

        [TestCleanup]
        public void TestCleanup()
        {
            driver.Quit();

        }
    }

}
