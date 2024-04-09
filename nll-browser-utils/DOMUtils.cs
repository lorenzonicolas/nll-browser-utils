using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace BrowserAutomation
{
    public class DOMUtils
    {
        public IWebDriver driver;

        public DOMUtils(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void clickOnSelectElement(string id, string textValue)
        {
            new SelectElement(driver.FindElement(By.Id(id)))
                .SelectByText(textValue);
        }

        public void clickOnSelectElementByXPath(string xpath, string textValue)
        {
            new SelectElement(driver.FindElement(By.XPath(xpath)))
                .SelectByText(textValue);
        }

        public void enterText(string elementId, string text)
        {
            var element = driver.FindElement(By.Id(elementId));
            element.Clear();
            element.SendKeys(text);
        }

        public void enterTextByXPath(string xpath, string text)
        {
            var element = driver.FindElement(By.XPath(xpath));
            element.Clear();
            element.SendKeys(text);
        }

        public void enterTextByXPath(string xpath, int text)
        {
            var element = driver.FindElement(By.XPath(xpath));
            element.Clear();
            element.SendKeys(text.ToString());
        }

        public void clickOnElement(string id)
        {
            driver
                .FindElement(By.Id(id))
                .Click();
        }

        public void clickOnElementByXPath(string xpath)
        {
            driver
                .FindElement(By.XPath(xpath))
                .Click();
        }

        public IWebElement tryFindElement(By by)
        {
            try
            {
                return driver.FindElement(by);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool elementVisible(By by)
        {
            try
            {
                return driver.FindElement(by).Displayed;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
