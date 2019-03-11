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

public static void Type (WebDriver driver)