using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Wikipedia
{
    public class WkikipediaTests
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Test_SearchQA()
        {
            //Arrange
            driver.Navigate().GoToUrl("https://wikipedia.org");

            //Act
            driver.FindElement(By.CssSelector("#searchInput")).Click();
            driver.FindElement(By.CssSelector("#searchInput")).SendKeys("QA");
            driver.FindElement(By.CssSelector("#searchInput")).SendKeys(Keys.Enter);

            //Assert
            Assert.AreEqual("https://en.wikipedia.org/wiki/QA",  driver.Url);

        }

        [TearDown]
        public void TearDown()
        {
        driver.Quit();
        }

    }
}