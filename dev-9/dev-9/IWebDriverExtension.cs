using OpenQA.Selenium;
using System;

namespace dev_9
{
    public static class IWebDriverExtension
    {
        public static IWebElement WaitAndFindElementBy(this IWebDriver driver, By by)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            return driver.FindElement(by);
        }
    }
}
