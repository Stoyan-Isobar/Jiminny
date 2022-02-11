using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace jmny;
    [TestFixture]
public class Tests
{
    IWebDriver driver = new ChromeDriver();

    [OneTimeSetUp]
//    public void OpenBrowser()
//   {
//       driver = new ChromeDriver();
//    }

    [Test]
    public void jmnytest2()
    {
        driver.Url = "https://todomvc.com/examples/vue/";
        IWebElement inputTodos = driver.FindElement(By.ClassName("new-todo"));
        var actualInputPlaceholder = inputTodos.GetAttribute("placeholder");
        var expectedInputPlaceholder = new string("What needs to be done?");
        Assert.AreEqual(expectedInputPlaceholder, actualInputPlaceholder, $"Actual Placeholder is different than the expected. Expected {expectedInputPlaceholder} but actual was {actualInputPlaceholder}.");
    }

    [OneTimeTearDown]
    public void CloseBrowser()
    {
        //driver.Close();
    }
}