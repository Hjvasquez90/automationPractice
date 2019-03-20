using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace automationpractice
{

    public class Actions
    {

        public static void ClickOn(IWebDriver driver, IWebElement element)
        {

            try
            {
                element.Click();

            }
            catch
            {
                IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
                executor.ExecuteScript("arguments[0].click();", element);
            }
        }

        public static void Type(IWebDriver driver, IWebElement element, string value)
        {
            element.SendKeys(value);
        }


        public static IWebElement buscarIds(IWebDriver webDriver, string id)
        {
            return webDriver.FindElement(By.Id(id));
        }

        public static IWebElement buscarClassname(IWebDriver webDriver, string buscarClase)
        {
            return webDriver.FindElement(By.ClassName(buscarClase));
        }

        public static IWebElement buscarXpath(IWebDriver webDriver, string xpath)
        {
            return webDriver.FindElement(By.XPath(xpath));
        }

        public static IWebElement buscarCss(IWebDriver webDriver, string css)
        {
            return webDriver.FindElement(By.CssSelector(css));
        }
        public static void select_dropdown(IWebDriver driver, IWebElement tag_dropdown, string value)
        {
            new SelectElement(tag_dropdown).SelectByValue(value);
        }
    }
}