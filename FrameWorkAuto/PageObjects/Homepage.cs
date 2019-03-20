using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace automationpractice
{

    public class Homepage
    {

        private IWebElement tag;
        private IWebDriver driver;





        public Homepage(IWebDriver driver)
        {
            this.driver = driver;
            
        }

        
        

        public void ClickOnContackLink()
        {
            Actions.ClickOn(driver, tag);
        }


        public void GoToPage()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            tag = Actions.buscarIds(driver, "contact-link");
        }
    }
}