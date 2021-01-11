using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace DemoQA_exercise.PageObjects
{
    partial class HomePage
    {
        public void FillInForm()
        {
            firstNameFieldTextBox.SendKeys("Irina");
            lastNameFieldTextBox.SendKeys("Eris");
            emailFieldTextBox.SendKeys("irina.eris@yahoo.com");
            genderFemaleRadioButton.Click();
            mobileFieldTextBox.SendKeys("0777009898");
            Thread.Sleep(1000);

            birthFieldTextBox.Click();
            monthDropDown.Click();
            yearDropDown.Click();
            yearSelection.Click();
            dateSelection.Click();
            Thread.Sleep(1000);

            subjectsTextBox.Click();
            subjectsTextBox.SendKeys("English");
            subjectsTextBox.SendKeys(Keys.Tab);
            Thread.Sleep(1000);

            hobbiesCheckBox.Click();
            Thread.Sleep(1000);

            //pictureChooseFileButton.Click();
            currentAddressFieldTextBox.SendKeys("Bulevardul Muncii");

            stateTextBox.SendKeys("Haryana");
            stateTextBox.SendKeys(Keys.Tab);
            cityTextBox.SendKeys("Karnal");
            cityTextBox.SendKeys(Keys.Tab);
            Thread.Sleep(1000);

            submitButton.Click();
            Thread.Sleep(1000);

            closeButton.Click();

        }
       
    }
}
