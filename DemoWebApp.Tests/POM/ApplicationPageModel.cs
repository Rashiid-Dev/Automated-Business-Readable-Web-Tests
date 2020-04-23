using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace DemoWebApp.Tests.POM
{
    public class ApplicationPageModel
    {
        private readonly IWebDriver Driver;
        private const string StartLoanUrl = "http://localhost:40077/Home/StartLoanApplication";

        public ApplicationPageModel(IWebDriver driver)
        {
            Driver = driver;
        }

        public void NavigateToApplicationPage() => Driver.Navigate().GoToUrl(StartLoanUrl);
        public void EnterFirstName(string firstname) => Driver.FindElement(By.Id("FirstName")).SendKeys(firstname);
        public void EnterLastName(string lastname) => Driver.FindElement(By.Id("LastName")).SendKeys(lastname);
        public void ClickLoan() => Driver.FindElement(By.Id("Loan")).Click();
        public void ClickAcceptTerms() => Driver.FindElement(By.Id("TermsAcceptance")).Click();
        public void ClickSubmit() => Driver.FindElement(By.CssSelector(".btn.btn-primary")).Click();
    }

    
}
