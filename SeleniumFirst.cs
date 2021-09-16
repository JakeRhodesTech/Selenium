using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create the reference for the browser 
            IWebDriver driver = new ChromeDriver();

            //Navigate to Google page
            driver.Navigate().GoToUrl("http://www.google.com");

            //Find the element
            IWebElement element = driver.FindElement(By.Name("q"));

            // This step is blocked by the Google Terms & Conditions pop-up, causes 'element not interactable'. 
            // Can't sign in to get around because this is blocked in automated browsing 
            // Can't use adblock because the browser initialises without extentions. 
            //Perform Ops
            element.SendKeys("executeautomation");
        }
    }
}
