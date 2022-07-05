using DemoBlaze.Common.Helpers;
using DemoBlaze.UI.Actions;
using DemoBlaze.UI.Models;
using DemoBlaze.UI.WebContext;
using DemoBlaze.WebPages;
using DemoBLaze.Common.Configurations;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace DemoBlaze.UI.StepDefinitions
{
    [Binding]
    public class RegisterStepDefinitions
    {
        private BaseUserActions _webUser;
        ScenarioContext _scenarioContext;

        internal RegisterStepDefinitions(BaseUserActions webUser, ScenarioContext scenarioContext)
        {
            _webUser = webUser;
            _scenarioContext = scenarioContext;
        }

        [Given(@"I navigate to home page")]
        public void GivenINavigateToHomePage()
        {
            _webUser.OpenPage(ConfigurationProvider.GetValue[ConfigurationLabels.BaseWebUrl]);
        }

        [Given(@"I click on Sign up button")]
        public void GivenIClickOnSignUpButton()
        {
            _webUser.ClicksOn(HomePage.NAVBAR_SIGNUP);
        }

        [When(@"I input username '(.*)' and password '(.*)' in signup form")]
        public void WhenIInputUsernameAndPasswordInSignupForm(string username, string password)
        {
            if (username == WebLabels.GetRandomUser)
            {
                username = Helper.GetRandomUser();
            }

            _webUser.TypesInto(HomePage.SIGNUP_USERNAME_FIELD, username);
            _webUser.TypesInto(HomePage.SIGNUP_PASSWORD_FIELD, password);
        }

        [When(@"I click on Sign up button on pop up")]
        public void WhenIClickOnSignUpButtonOnPopUp()
        {
            _webUser.ClicksOn(HomePage.SIGNUP_BUTTON);
        }

        [Then(@"a message ""(.*)"" should appear")]
        public void ThenAMessageShouldAppear(string expectedMessage)
        {
            Assert.AreEqual(expectedMessage, _webUser.DismissAlert(), "Sign up messages are not the same.");
        }

        [Then(@"an error message ""(.*)"" should appear")]
        public void ThenAnErrorMessageShouldAppear(string expectedMessage)
        {
            Assert.AreEqual(expectedMessage, _webUser.DismissAlert(), "Sign up messages are not the same.");
        }
    }
}