using OpenQA.Selenium;

namespace DemoBlaze.WebPages
{
    internal class CartPage
    {
        public static readonly By PLACEORDER_BUTTON = By.XPath("//button[text()='Place Order']");
        public static readonly By ORDER_NAME_FIELD = By.XPath("//input[@id='name']");
        public static readonly By ORDER_COUNTRY_FIELD = By.XPath("//input[@id='country']");
        public static readonly By ORDER_CITY_FIELD = By.XPath("//input[@id='city']");
        public static readonly By ORDER_CARD_FIELD = By.XPath("//input[@id='card']");
        public static readonly By ORDER_MONTH_FIELD = By.XPath("//input[@id='month']");
        public static readonly By ORDER_YEAR_FIELD = By.XPath("//input[@id='year']");
        public static readonly By PURCHASE_BUTTON = By.XPath("//button[text()='Purchase']");
        public static readonly By PURCHASE_MESSAGE = By.XPath("//p[@class='lead text-muted ']");
        public static readonly By PURCHASE_OK_BUTTON = By.XPath("//button[.='OK']");

    }
}
