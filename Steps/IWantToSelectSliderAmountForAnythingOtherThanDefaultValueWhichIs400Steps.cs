using TechTalk.SpecFlow;
using dotcomPPSSalesFlow.Pages;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.Threading;

namespace dotcomPPSSalesFlow.Features
{
    [Binding]
    public class PPSSalesFlowSteps
    {
        HomePage homePage = null;
        IWebDriver driver = new ChromeDriver();

        [Given(@"Navigate to the Home page")]
        public void GivenNavigateToTheHomePage()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized");
    //        IWebDriver driver = new ChromeDriver(options);
            options.AddArgument("no-sandbox");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("https://www.auden.com/");
            homePage = new HomePage(driver);
            //homePage.clickBtnManageMyCookies();
            //homePage.clickBtnConfirmCookies();
        }

        [Given(@"I navigate to the Short Term Loans page")]
        public void GivenINavigateToTheShortTermLoansPage()
        {
            homePage.OpenLoansPage();
        }

        [Then(@"I select the a Saturday")]
        public void ThenISelectTheASaturday()
        {
            Thread.Sleep(3000);
            homePage.ClickBtn24th();
        }
    }
}
