using OpenQA.Selenium;

namespace DemoBlaze.WebPages
{
    internal class HomePage
    {
        public static readonly By NAVBAR_SIGNUP = By.XPath("//a[@id='signin2']");

        public static readonly By SIGNUP_USERNAME_FIELD = By.XPath("//input[@id='sign-username']");

        public static readonly By SIGNUP_PASSWORD_FIELD = By.XPath("//input[@id='sign-password']");

        public static readonly By SIGNUP_BUTTON = By.CssSelector("div#signInModal > div[role='document'] .btn.btn-primary");

        public static readonly By WELCOME_USER = By.XPath("//a[@id='nameofuser']");

        public static readonly By NAVBAR_LOGIN =  By.XPath("//a[@id='login2']");

        public static readonly By NAVBAR_LOGOUT = By.XPath("//a[@id='logout2']");

        public static readonly By LOGIN_BUTTON = By.CssSelector("div#logInModal > div[role='document'] .btn.btn-primary");

        public static readonly By LOGIN_USERNAME_FIELD = By.XPath("//input[@id='loginusername']");

        public static readonly By LOGIN_PASSWORD_FIELD = By.XPath("//input[@id='loginpassword']");
    }
}
