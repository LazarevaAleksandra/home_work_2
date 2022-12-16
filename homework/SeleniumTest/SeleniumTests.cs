using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using static System.Net.WebRequestMethods;

namespace SeleniumTest
{
    public class SeleniumTests
    {
        private IWebDriver _driver;
        private const string link = "https://www.epam.com/";

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(link);
        }

        [Test]
        public void CheckHeaderOnThePage()
        {
            var header = _driver.FindElement(By.XPath("//*[@class = 'header__content']"));

            Assert.True(header.Displayed);
        }

        [Test]
        public void CheckPageOpening()
        {
            var newLink = "https://www.epam.com/careers/locations";

            _driver.FindElement(By.XPath("//*[@class = 'hamburger-menu__button']")).Click();
            _driver.FindElement(By.XPath("//*[href = 'https://www.epam.com/careers']")).Click();

            Assert.AreEqual(_driver.Url, newLink, "Incorrect url is present!");

            var apply = _driver.FindElement(By.XPath("//*[href = 'https://www.epam.com/careers/apply-now']"));
            var action = new Actions(_driver);
            action.ScrollToElement(apply);

            Assert.True(apply.Displayed);

        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}