using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace TestMethodNUnit
{
    class Program
    {

        //Create the reference for our browser
        IWebDriver driver = new ChromeDriver();
        
        static void Main(string[] args)
        {
        }

        [SetUp]
        public void Initialize()
        {
            //Navigate to Google page 
            driver.Navigate().GoToUrl("http://www.google.com");
            Console.WriteLine("Opened the browser");
        }

        [Test]
        public void ExecuteTest()
        {
            //Find the element
            IWebElement element = driver.FindElement(By.Name("q"));

            //Perform Ops 
            element.SendKeys("executeautomation");
            Console.WriteLine("Performed operations");
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
            Console.WriteLine("Closed the browser");
        }
    }
}
