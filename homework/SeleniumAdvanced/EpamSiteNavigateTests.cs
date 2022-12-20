using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;

namespace SeleniumAdvanced
{
    [TestFixture]
    public class EpamSiteNavigateTests
    {
        private IWebDriver _driver;
        private WebDriverWait _waiter;
        private Actions _action;
        private IJavaScriptExecutor? _javaScriptExecutor;
        private const string link = "https://www.epam.com";
        

        [SetUp]
        public void InicializeBrowserAndWaits()
        {
            _driver = new ChromeDriver();
            _waiter = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));
            _action = new Actions(_driver);
            _javaScriptExecutor = _driver as IJavaScriptExecutor;
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(link);
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(40);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);                  
        }

        [Test]
        public void CheckTheOpeningOfTheLinkInTheCareerTabTest()
        {
            var linkJob = "https://www.epam.com/careers/job-listings";
            var career = _driver.FindElement(By.XPath("//*[@href = '/careers']"));
            _action.MoveToElement(career);
            _action.Perform();
            _driver.FindElement(By.XPath("//*[@href = '/careers/job-listings']")).Click();
            
            Assert.That(_driver.Url, Is.EqualTo(linkJob), "Incorrect url is present!");
        }

        [Test]
        public void CheckListOfLanguagesTest()
        {
            var expectedlistOfLanguages = new List<string> {"Global (English)", "Hungary (English)", 
                "СНГ (Русский)", "Česká Republika (Čeština)", "India (English)", "Україна (Українська)", 
                "Czech Republic (English)", "日本 (日本語)", "中国 (中文)", "DACH (Deutsch)", "Polska (Polski)"};

            _driver.FindElement(By.XPath("//*[@class='location-selector__button']")).Click();

            var actualListOfLanguages = _waiter.Until(_driver => _driver.FindElements
            (By.XPath("//*[@class = 'location-selector__item']")))
                .Select(language => language.GetAttribute("innerText")); 

            Assert.That(actualListOfLanguages, Is.EqualTo(expectedlistOfLanguages), "Incorrect list of languages is present!");
        }

        [Test]
        public void CheckSeeMoreThan20Articles()
        {
            _javaScriptExecutor.ExecuteScript("arguments[0].click()", _driver.FindElement(By.XPath("//*[@class='header-search__button header__icon']")));
            _driver.FindElement(By.XPath("//*[@class='frequent-searches__item' and contains(text(), 'Cloud')]")).Click();
            _driver.FindElement(By.XPath("//*[@class='header-search__submit']")).Click();
            _action.ScrollToElement(_driver.FindElement(By.XPath("//*[@class='search-results__footer']"))).Perform();
            var actualResult = _driver.FindElements(By.XPath("//*[@class='search-results__item']"));
            Assert.That(actualResult, Has.Count.EqualTo(20), "Incorrect number of articles on the site");
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }     
}
