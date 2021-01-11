using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DemoQA_exercise.PageObjects
{
    partial class HomePage
    {
        public IWebDriver _driver;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }
        private IWebElement firstNameFieldTextBox => _driver.FindElement(By.XPath("//*[@id='firstName']"));
        private IWebElement lastNameFieldTextBox => _driver.FindElement(By.XPath("//input[@id='lastName']"));
        private IWebElement emailFieldTextBox => _driver.FindElement(By.XPath("//input[@class='mr-sm-2 form-control']"));
        private IWebElement genderFemaleRadioButton => _driver.FindElement(By.XPath("//*[@id='genterWrapper']/div[2]/div[2]/label"));
        private IWebElement mobileFieldTextBox => _driver.FindElement(By.XPath("//input[@id='userNumber']"));
        
        private IWebElement birthFieldTextBox => _driver.FindElement(By.XPath("//*[@id='dateOfBirth']/div[1]"));
        private IWebElement monthDropDown => _driver.FindElement(By.XPath("//*[@id='dateOfBirth']/div[2]/div[2]/div/div/div[2]/div[1]/div[2]/div[1]/select/option[9]"));
        private IWebElement yearDropDown => _driver.FindElement(By.XPath("//*[@id='dateOfBirth']/div[2]/div[2]/div/div/div[2]/div[1]/div[2]/div[2]/select"));
        private IWebElement yearSelection => _driver.FindElement(By.XPath("//option[@value='1989']"));
        private IWebElement dateSelection => _driver.FindElement(By.XPath("//*[@id='dateOfBirth']/div[2]/div[2]/div/div/div[2]/div[2]/div[5]/div[4]"));

        private IWebElement subjectsTextBox => _driver.FindElement(By.XPath("//input[@id='subjectsInput']"));
        private IWebElement hobbiesCheckBox => _driver.FindElement(By.XPath("//label[@for='hobbies-checkbox-2']"));
        private IWebElement currentAddressFieldTextBox => _driver.FindElement(By.XPath("//*[@id='currentAddress']"));
        private IWebElement stateTextBox => _driver.FindElement(By.XPath("//*[@id='react-select-3-input']"));
        private IWebElement cityTextBox => _driver.FindElement(By.XPath("//*[@id='react-select-4-input']"));

        private IWebElement submitButton => _driver.FindElement(By.XPath("//button[@type='submit']"));

        private IWebElement closeButton => _driver.FindElement(By.XPath("//*[@id='closeLargeModal']"));


        //private IWebElement pictureChooseFileButton => _driver.FindElement(By.XPath("//*[@id='uploadPicture']"));

    }
}

