using DemoBlaze.UI.Actions;
using DemoBlaze.UI.WebContext;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using DemoBlaze.UI.Models;
using DemoBLaze.Common.Configurations;
using OpenQA.Selenium;
using DemoBlaze.WebPages;


namespace DemoBlaze.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {

        private BaseUserActions _webUser;
        ScenarioContext _scenarioContext;

        internal LoginStepDefinitions(BaseUserActions webUser, ScenarioContext scenarioContext)
        {
            _webUser = webUser;
            _scenarioContext = scenarioContext;
        }

        [Given(@"I navigate to main page")]
        public void GivenINavigateToMainPage()
        {
            _webUser.OpenPage(ConfigurationProvider.GetValue[ConfigurationLabels.BaseWebUrl]);
        }

        [Given(@"I click on Log in button")]
        public void GivenIClickOnLogInButton()
        {
            _webUser.ClicksOn(HomePage.NAVBAR_LOGIN);
        }

        [When(@"I input username '(.*)' and password '(.*)' in login form")]
        public void WhenIInputUsernameAndPasswordInLoginForm(string username, string password)
        {
            _webUser.TypesInto(HomePage.LOGIN_USERNAME_FIELD, username);
            _webUser.TypesInto(HomePage.LOGIN_PASSWORD_FIELD, password);
        }

        [When(@"I click on Log in button on pop up")]
        public void WhenIClickOnLogInButtonOnPopUp()
        {
            _webUser.ClicksOn(HomePage.LOGIN_BUTTON);
        }

        [Then(@"the user should be logged in successfully")]
        public void ThenTheUserShouldBeLoggedInSuccessfully()
        {
            var welcomeMessage = _webUser.WaitsUntilVisible(HomePage.WELCOME_USER);

            Assert.That(welcomeMessage.Displayed, "Welcome message is not displayed.");
        }

    }
}
