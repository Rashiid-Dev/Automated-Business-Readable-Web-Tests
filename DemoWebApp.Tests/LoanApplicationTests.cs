using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace DemoWebApp.Tests
{
    public class LoanApplicationTests
    {
        private const string HomeUrl = "http://localhost:40077/";
        private const string StartLoanUrl = "http://localhost:40077/Home/StartLoanApplication";

        [Fact]
        [Trait("Category","Smoke")]
        public void StartApplication()
        {
            using (IWebDriver driver = new FirefoxDriver())
            {
                driver.Manage().Window.Maximize();

                driver.Navigate().GoToUrl(HomeUrl);

                driver.FindElement(By.Id("startApplication")).Click();

            }
        }

        [Fact]
        public void SubmitApplication()
        {
            using (IWebDriver driver = new FirefoxDriver())
            {
                driver.Manage().Window.Maximize();

                driver.Navigate().GoToUrl(StartLoanUrl);

                driver.FindElement(By.Id("FirstName")).SendKeys("Rashiid");
                driver.FindElement(By.Id("LastName")).SendKeys("Jama");
                driver.FindElement(By.Id("Loan")).Click();
                driver.FindElement(By.Id("TermsAcceptance")).Click();
                driver.FindElement(By.CssSelector(".btn.btn-primary")).Click();

                IWebElement ConfirmationNameSpan = driver.FindElement(By.Id("firstName"));
                string confirmationName = ConfirmationNameSpan.Text;
                Assert.Equal("Rashiid", confirmationName);

            }
        }

                
    }
}
