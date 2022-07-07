using DemoBlaze.UI.Actions;
using DemoBlaze.UI.Models;
using DemoBlaze.WebPages;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace DemoBlaze.StepDefinitions
{
    [Binding]
    internal class PurchaseStepDefinitions
    {

        private BaseUserActions _webUser;
        ScenarioContext _scenarioContext;

        internal PurchaseStepDefinitions(BaseUserActions webUser, ScenarioContext scenarioContext)
        {
            _webUser = webUser;
            _scenarioContext = scenarioContext;
        }
        
        [When(@"I click on a product")]
        public void WhenIClickOnAProduct()
        {
            _webUser.WaitforStaleElement(HomePage.PRODUCT_ID);
            _webUser.ClicksOn(HomePage.PRODUCT_ID);
        }

        [When(@"I add it to cart")]
        public void WhenIAddItToCart()
        {
            _webUser.ClicksOn(ProductPage.ADDTOCART_BUTTON);
            _webUser.DismissAlert();
        }

        [When(@"I click on Cart button")]
        public void WhenIClickOnCartButton()
        {
            _webUser.ClicksOn(HomePage.NAVBAR_CART);
        }

        [When(@"I click on Place Order button")]
        public void WhenIClickOnPlaceOrderButton()
        {
            _webUser.ClicksOn(CartPage.PLACEORDER_BUTTON);
        }

        [When(@"I enter the following data:")]
        public void WhenIEnterTheFollowingData(Table table)
        {
            var currentUser = table.CreateInstance<User>();
            
            _webUser.TypesInto(CartPage.ORDER_NAME_FIELD, currentUser.Name);
            _webUser.TypesInto(CartPage.ORDER_COUNTRY_FIELD, currentUser.Country);
            _webUser.TypesInto(CartPage.ORDER_CITY_FIELD, currentUser.City);
            _webUser.TypesInto(CartPage.ORDER_CARD_FIELD, currentUser.Creditcard);
            _webUser.TypesInto(CartPage.ORDER_MONTH_FIELD, currentUser.Month);
            _webUser.TypesInto(CartPage.ORDER_YEAR_FIELD, currentUser.Year);
        }

        [When(@"I click on Purchase button")]
        public void WhenIClickOnPurchaseButton()
        {
            _webUser.ClicksOn(CartPage.PURCHASE_BUTTON);
        }

        [Then(@"I see information for the placed order")]
        public void ThenISeeInformationForThePlacedOrder()
        {
            var orderMessage = _webUser.WaitsUntilVisible(CartPage.PURCHASE_MESSAGE);
            Assert.That(orderMessage.Displayed, "Order message is not displayed");
        }
    }
}
