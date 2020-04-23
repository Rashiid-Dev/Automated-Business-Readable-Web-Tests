using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace DemoWebApp.Tests
{
    public class LoanApplicationTests
    {
        private const string HomeUrl = "http://localhost:40077/";

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

                
    }
}
