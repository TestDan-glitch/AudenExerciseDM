using OpenQA.Selenium;

namespace dotcomPPSSalesFlow.Pages
{
    class HomePage
    {
        public IWebDriver WebDriver { get; }

        public HomePage(IWebDriver driver)
        {
            WebDriver = driver;
        }

        IWebElement btnManageMyCookies => WebDriver.FindElement(By.Id("consent_prompt_pref_manager"));
        IWebElement btnConfirmCookies => WebDriver.FindElement(By.Id("preferences_prompt_submit"));
        IWebElement btnLoan => WebDriver.FindElement(By.XPath("//div[@id='root']/main/div[2]/div/div/button"));

        IWebElement btn24th => WebDriver.FindElement(By.XPath("//div[@id='root']/main/div/div[2]/section[2]/div/span[24]/button"));

      //  IWebElement btn24th => WebDriver.FindElement(By.CssSelector("#monthly[value='24']"));

      //  IWebElement btn24th => WebDriver.FindElement(By.CssSelector("span:nth-of-type(24) > button#monthly"));

      //  xpath=//div[@id='root']/main/div/div[2]/section[2]/div/span[24]/button

        public void clickBtnManageMyCookies() => btnManageMyCookies.Click();
        public void clickBtnConfirmCookies() => btnConfirmCookies.Click();
        public void OpenLoansPage() => btnLoan.Click();

        public IWebElement findBtn24th() => btn24th;


        public void ClickBtn24th() => btn24th.Click();

        public void CloseBrowser() => WebDriver.Quit();

    }
}
