using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace Selenium_Basics
{
    [TestFixture]
    public class EpamSiteNavigateTests
    {
        private IWebDriver _driver;

        [SetUp]
        public void InicializeBrowser()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
        }

        [Test]
        public void CheckNavigationToMainEpamPage()
        {
            var link = "https://www.epam.com/";

            _driver.Navigate().GoToUrl(link);

            Assert.That(_driver.Url, Is.EqualTo(link), "Incorrect url is present!");           
        }

        [Test]
        public void CheckWeDoItPageIsOpenedAfterMoveAndReload()
        {
            var linkHoWeDoIt = "https://www.epam.com/how-we-do-it";
            var linkOurWork = "https://www.epam.com/our-work";

            _driver.Navigate().GoToUrl(linkHoWeDoIt);
            _driver.Navigate().GoToUrl(linkOurWork);
            _driver.Navigate().Refresh();
            _driver.Navigate().Back();
   
            Assert.That(_driver.Url, Is.EqualTo(linkHoWeDoIt), "Incorrect url is present!");
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}