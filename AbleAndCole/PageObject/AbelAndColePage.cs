using AbelAndCole.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbelAndCole.PageObject
{
    class AbelAndColePage
    {

        public AbelAndColePage() 
        {
            driver = Hooks1.driver;
        }
        IWebDriver driver;

        IWebElement AcceptCookies => driver.FindElement(By.XPath("//*[@id=\"ccc-notify-accept\"]"));
        IWebElement SearchSpace => driver.FindElement(By.XPath("//*[@id=\"search-term\"]"));
        IWebElement SearchButton => driver.FindElement(By.XPath("//*[@id=\"search-btn\"]"));
        IWebElement AddButton => driver.FindElement(By.XPath("//*[@id=\"product-list\"]/li[1]/div[3]/div[3]/div[2]/div[1]"));
        IWebElement HumusButton => driver.FindElement(By.XPath("//*[@id=\"product-list\"]/li[1]/div[3]/div[3]/div[2]/div[1]"));
        IWebElement PlusButton => driver.FindElement(By.XPath("//*[@id=\"product-list\"]/li[1]/div[3]/div[3]/div[2]/div[2]/div/div[3]"));
        IWebElement PlusHumusButton => driver.FindElement(By.XPath("//*[@id=\"product-list\"]/li[1]/div[3]/div[3]/div[2]/div[2]/div/div[3]"));
        IWebElement PopcornButton => driver.FindElement(By.XPath("//*[@id=\"product-list\"]/li[1]/div[3]/div[3]/div[2]/div[1]"));
        IWebElement PluspopcornButton => driver.FindElement(By.XPath("//*[@id=\"product-list\"]/li[1]/div[3]/div[3]/div[2]/div[2]/div/div[3]"));
        IWebElement BasketButton => driver.FindElement(By.XPath("//*[@id=\"BasketCount\"]"));
        IWebElement ItemBasket => driver.FindElement(By.XPath("/html/body/div[3]/div/div[2]/div[2]/div[1]"));



        public bool IsItemInTheBasketDisplayed()
        {
            return ItemBasket.Displayed;
        }
        public void ClickBasketButton()
        {
            BasketButton.Click();
        }
        public void ClickPluspopcornButton()
        {
            PluspopcornButton.Click();
        }
        public void AddPopcornButton()
        {
            PopcornButton.Click();
        }

        public void InputProduct3(string item3)
        {
            SearchSpace.SendKeys(item3);
        }

        public void ClickPlusButton()
        {
            PlusButton.Click();
        }

        public void ClickPlusHumusButton()
        {
            PlusHumusButton.Click();
        }

        public void AddHumusButton()
        {
            HumusButton.Click();
        }

        public void ClickOnAcceptButton()
        { 
            AcceptCookies.Click();
        
        }

        public void ClickOnSearchSpace()
        {
            SearchSpace.Click();
        }

        

        public void InputProduct2(string item2) 
        {
            SearchSpace.SendKeys(item2);
        }

        public void InputProduct1(string item1)
        {
            SearchSpace.SendKeys(item1);
        }

        public void ClickOnSearchButton() 
        {
            SearchButton.Click();
        }

        public void ClickOnAddButton() 
        { 
            AddButton.Click();
        
        }

        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }







    }
}
