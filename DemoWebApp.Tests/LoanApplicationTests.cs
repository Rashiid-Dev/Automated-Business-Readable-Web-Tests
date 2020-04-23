using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using DemoWebApp.Tests.POM;

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
                var applicationPageModel = new ApplicationPageModel(driver);

                applicationPageModel.NavigateToApplicationPage();

                applicationPageModel.EnterFirstName("Rashiid");
                applicationPageModel.EnterLastName("Jama");
                applicationPageModel.ClickLoan();
                applicationPageModel.ClickAcceptTerms();
                applicationPageModel.ClickSubmit();                        

                IWebElement ConfirmationNameSpan = driver.FindElement(By.Id("firstName"));
                string confirmationName = ConfirmationNameSpan.Text;
                Assert.Equal("Rashiid", confirmationName);

            }
        }

                
    }
}
