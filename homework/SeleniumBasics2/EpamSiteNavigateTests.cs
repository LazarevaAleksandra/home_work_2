using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Collections.Generic;

namespace SeleniumBasics2
{
    [TestFixture]
    public class EpamSiteNavigateTests
    {
        private IWebDriver _driver;
        private const string link = "https://www.epam.com/";
        
        [SetUp]
        public void InicializeBrowser()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(link);
        }

        [Test]
        public void CheckTheListOfCountriesInTheCareerButtonTest()
        {
            var countries = new List<string> { "AMERICAS", "EMEA", "APAC" };
            _driver.FindElement(By.XPath("//*[@href = '/careers']")).Click();
            var careerOffice = _driver.FindElement(By.XPath("//*[@class='tabs__ul js-tabs-links-list']"));
            var careerElements = careerOffice.FindElements(By.XPath(".//div")).Select(item => item.GetAttribute("innerText"));

            Assert.That(careerElements.Count(), Is.EqualTo(3), "Invalid number of countries!");
            Assert.That(careerElements, Is.EqualTo(countries), "Incorrect country name!");
        }

        [Test]
        public void CheckForAWordInTheSearchBoxTest()
        {
            var linkAutomation = "https://www.epam.com/search?q=Automation";

            _driver.FindElement(By.XPath("//*[@class = 'header-search__button header__icon']")).Click();
            _driver.FindElement(By.XPath("//*[@id='new_form_search']")).SendKeys("Automation");
            _driver.FindElement(By.XPath("//*[@class = 'header-search__submit']")).Click();
            var articles = _driver.FindElements(By.XPath("//*[@class = 'search-results__item']")).Take(5)
                .Select(item => item.Text);

            Assert.That(_driver.Url, Is.EqualTo(linkAutomation), "Incorrect url is present!");
            Assert.That(articles, Is.All.Contain("Automation").IgnoreCase, "This word is not in the article!");
        }

        [Test]
        public void CheckIfTheTitleMatchesTheFirstArticleTest()
        {
            var linkBusinessAnalysis = "https://www.epam.com/search?q=Business+Analysis";

            _driver.FindElement(By.XPath("//*[@class = 'header-search__button header__icon']")).Click();
            _driver.FindElement(By.XPath("//*[@id='new_form_search']")).SendKeys("Business Analysis");
            _driver.FindElement(By.XPath("//*[@class = 'header-search__submit']")).Click();

            Assert.That(_driver.Url, Is.EqualTo(linkBusinessAnalysis), "Incorrect url is present!");

            var title = _driver.FindElement(By.XPath("//*[@class = 'search-results__title-link']")).GetAttribute("innerText");
            var titleOfTheFirstArticle = _driver.FindElement(By.XPath("//*[@class = 'search-results__title-link']"));
            _driver.FindElement(By.XPath("//button[@id='onetrust-accept-btn-handler']")).Click();
            Thread.Sleep(2000);
            titleOfTheFirstArticle.Click();
            var titleBusinessAnalysis = _driver.FindElement(By.XPath("//*[@class='layout-box__wrapper']//h1")).GetAttribute("innerText");

            Assert.AreEqual(titleBusinessAnalysis, title, "Incorrect title is present!");
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}

//Locators:
//1. //*[@class='tabs__ul js-tabs-links-list' and contains (@role, "tablist")] 
//2. //*[@id="main"]/following-sibling::div    //*[@id="main"]/preceding-sibling::div
//3  //*[@id="main"]/parent::div 
//4. //*[@id="main"]/first::div        //*[@id="main"]/last::div 
//5. .//*[@id="wrapper"]
