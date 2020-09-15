using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Net;



namespace TestAutomationProject
{
    class FirstTest
    {
        static void Main(string[] args)
        {
            
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(2000);

            IWebElement searchText = driver.FindElement(By.XPath("//input[@name='q']"));
            searchText.SendKeys("Mitto CH");
            searchText.SendKeys(Keys.Enter);
            


            System.Threading.Thread.Sleep(6000);



          
            IWebElement resultsPanel = driver.FindElement(By.Id("slim_appbar"));
            System.Collections.ObjectModel.ReadOnlyCollection<IWebElement> searchResults = resultsPanel.FindElements(By.XPath("//div[@id='rso']/div/div/div/a/h3"));

            foreach (IWebElement result in searchResults)
            {
                
                result.Click();
                Console.WriteLine("The Mitto page is found and open");


            }

            driver.Quit();
        }
    }
}

