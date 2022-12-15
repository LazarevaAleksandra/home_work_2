using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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
            _driver.FindElement(By.XPath("//*[@href = '/careers']")).Click();
            var careerOffice = _driver.FindElement(By.XPath("//*[@class='tabs__ul js-tabs-links-list']"));
            var careerElements = careerOffice.FindElements(By.XPath(".//div"));

            Assert.That(careerElements.Count(), Is.EqualTo(3), "Invalid number of countries!");
        }

        [Test]
        public void CheckForAWordInTheSearchBoxTest()
        {
            var linkAutomation = "https://www.epam.com/search?q=Automation";

            _driver.FindElement(By.XPath("//*[@class = 'header-search__button header__icon']")).Click();
            _driver.FindElement(By.XPath("//*[@id='new_form_search']")).SendKeys("Automation");
            _driver.FindElement(By.XPath("//*[@class = 'header-search__submit']")).Click();
            _driver.FindElement(By.XPath("//*[@class = 'search-results__items']"));

            Assert.That(_driver.Url, Is.EqualTo(linkAutomation), "Incorrect url is present!");
            Assert.True(_driver.PageSource.Contains("Automation"));
        }

        [Test]
        public void CheckIfTheTitleMatchesTheFirstArticleTest()
        {
            var linkBA = "https://www.epam.com/search?q=Business+Analysis";

            _driver.FindElement(By.XPath("//*[@class = 'header-search__button header__icon']")).Click();
            _driver.FindElement(By.XPath("//*[@id='new_form_search']")).SendKeys("Business Analysis");
            _driver.FindElement(By.XPath("//*[@class = 'header-search__submit']")).Click();

            Assert.That(_driver.Url, Is.EqualTo(linkBA), "Incorrect url is present!");

            var title = _driver.FindElement(By.XPath("//*[@class = 'search-results__title-link']")).GetAttribute("innerText");
            _driver.FindElement(By.XPath("//*[@class = 'search-results__title-link']")).Click();
            var titleBA =_driver.FindElement(By.XPath("//*[@class='title__bottom-line']//h1")).Text;

            Assert.AreEqual(titleBA, title);
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}

//Locators:
//1. //video
//2. //*[@id="main"]/following-sibling::div    //*[@id="main"]/preceding-sibling::div
//3  //*[@id="main"]/parent::div 
//4. //*[@id="main"]/first::div        //*[@id="main"]/last::div 
//5. .//*[@id="wrapper"]
