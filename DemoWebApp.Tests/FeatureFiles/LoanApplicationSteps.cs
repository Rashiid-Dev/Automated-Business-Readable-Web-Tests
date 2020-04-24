using System;
using TechTalk.SpecFlow;

namespace DemoWebApp.Tests.FeatureFiles
{
    [Binding]
    public class LoanApplicationSteps
    {
        [Given(@"I am on the loan application screen")]
        public void GivenIAmOnTheLoanApplicationScreen()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I enter a first name of Rashiid")]
        public void GivenIEnterAFirstNameOfRashiid()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I enter a second name of Jama")]
        public void GivenIEnterASecondNameOfJama()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I select that I have an existing loan account")]
        public void GivenISelectThatIHaveAnExistingLoanAccount()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I confirm my acceptance of the terms and conditions")]
        public void GivenIConfirmMyAcceptanceOfTheTermsAndConditions()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I submit my application")]
        public void WhenISubmitMyApplication()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should see the application complete confirmation for Rashiid")]
        public void ThenIShouldSeeTheApplicationCompleteConfirmationForRashiid()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
