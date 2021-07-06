using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Automated
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            
        {

            //Launch Chrome
            IWebDriver driver = new ChromeDriver();
            //Enter URL
            driver.Navigate().GoToUrl("file:///C:/Users/S%20com/OneDrive/Documents/Registration%20View.htm");
            //Chrome browser maximize
            driver.Manage().Window.Maximize();
            //Assert Registration Page open
            Assert.AreEqual("Welcome: Registration", driver.Title);
            //Enter email
            IWebElement emailTextBox = driver.FindElement(By.Name("email"));
            emailTextBox.Clear();
            emailTextBox.SendKeys("daniyal@gmail.com");
            //Enter password
            IWebElement passwordTextBox = driver.FindElement(By.Name("password"));
            passwordTextBox.Clear();
            passwordTextBox.SendKeys("123456");
            //Select Gender
            IWebElement genderRadiobuttons = driver.FindElement(By.Name("gender_female"));
            genderRadiobuttons.Click();
            //Select courses
            IWebElement coursesCheckboxes = driver.FindElement(By.Name("subject_SQA"));
            coursesCheckboxes.Click();
            coursesCheckboxes = driver.FindElement(By.Name("subject_DevOps"));
            coursesCheckboxes.Click();
            //Select Location
            IWebElement myLocationdropdown = driver.FindElement(By.Id("myLocation"));
            SelectElement location = new SelectElement(myLocationdropdown);
            location.SelectByValue("2");
            //Select timeSlot
            IWebElement timeSlotMultipleList = driver.FindElement(By.Id("timeSlot"));
            SelectElement timeSlot = new SelectElement(timeSlotMultipleList);
            timeSlot.SelectByText("3:00PM - 6:00 PM");

            //Click Register button
            IWebElement registerButton = driver.FindElement(By.Id("register"));
            registerButton.Click();

            //Assert registration successfully message appear.
            IWebElement messagetext = driver.FindElement(By.Id("demo1"));
            Assert.AreEqual("Registration Successfully", messagetext.Text);

        }

    }
}
}
