using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;

namespace XAPT
{
    

    [TestFixture]
    public class ChromeTesting : Hooks
    {

       

        [Test]

        public void ChromeWikipediaTest()
        {

            //1- Open the Browser.    
            //2-  Navigate to the Wikipedia site.
            Driver.Navigate().GoToUrl("https://www.wikipedia.org");

            //3- Choose english language.
            Driver.FindElement(By.LinkText("English — Wikipedia — The Free Encyclopedia")).Click();


            //4- Get the search results panel that contains the link for result.
            Driver.FindElement(By.Name("search")).SendKeys("Test Automation");
            Driver.FindElement(By.Name("go")).Click();


            //Again Navigate the page to search the Keyword Unit Testing  
            Driver.Navigate().GoToUrl("https://en.wikipedia.org/wiki/Test_automation");
            IWebElement body = Driver.FindElement(By.TagName("Unit Testing"));


            //5- Validate the following text
            // a. Unit testing text. 

            Assert.That(Driver.PageSource.Contains("Unit Test"), Is.EqualTo(true),
                                                      "Unit Test Does not Exits");

            // b- Existence of Test Automation Interface Model picture
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://en.wikipedia.org/wiki/Test_automation#Graphical_User_Interface_(GUI)_testing");

            try
            {
                Assert.IsTrue(driver.FindElement(By.Id("thumbimage")).Displayed);
                Console.Write("Existence of Test Automation Interface Model picture");
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
            Console.Read();

            //6- Search for the link of Behavior driven development and navigate to there

            IWebElement query = driver.FindElement(By.Name("search"));
            query.SendKeys("Behavior-drivern Development");
            query.Submit();
            Assert.IsTrue(driver.PageSource.Contains("https://en.wikipedia.org/wiki/Behavior-driven_development"));
            Assert.AreEqual("Behavior-drivern Development - WikipediaSearch", driver.Title);
            Driver.Navigate().GoToUrl("https://en.wikipedia.org/wiki/Behavior-driven_development");
        }

        
       public void CleanUp() 
       {

        Driver.Close();

         Console.WriteLine("Close the brwoser");
        }
    }
}
