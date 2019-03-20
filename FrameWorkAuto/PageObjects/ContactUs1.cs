using OpenQA.Selenium;
using System;

namespace automationpractice
{

    public class ContactUs1
    {
        private IWebDriver driver;
        private IWebElement tag_email;
        private IWebElement tag_orderref;
        private IWebElement tag_message;
        private IWebElement tag_button;
        private IWebElement tag_dropdown;
        
        public ContactUs1(IWebDriver driver)
        {
            this.driver = driver;
            tag_email = Actions.buscarIds(driver, "email");
            tag_orderref = Actions.buscarIds(driver, "id_order");
            tag_message = Actions.buscarIds(driver, "message");
            tag_button = Actions.buscarIds(driver, "submitMessage");
            tag_dropdown = Actions.buscarIds(driver, "id_contact");
        }
        public void FillContactUsForm(string email, string orderref, string message)
        {
            Actions.Type(driver, tag_email, email);
            Actions.Type(driver, tag_orderref, orderref);
            Actions.Type(driver, tag_message, message);
            Actions.select_dropdown(driver, tag_dropdown, "2");
            Actions.ClickOn(driver, tag_button);
        
        }
        public string GetSuccessMessage()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            return Actions.buscarXpath(driver, "//*[@id=\"center_column\"]/p").Text;

        }
    }
}
