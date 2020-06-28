using OpenQA.Selenium;
using OpenQA.Selenium.Opera;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_LocatorStrategies
{
	class Program
	{
		static void Main(string[] args)
		{
			IWebDriver driver = new OperaDriver(@"D:\OneDrive\Thang\HOCTAP\PUBLIC PROJECTS\SeleniumCSharp");
			driver.Navigate().GoToUrl("http://www.demoqa.com/automation-practice-form");

			// Locate by ID attribute
			var firstName = driver.FindElement(By.Id("firstName"));
			firstName.SendKeys("Thang");

			// Locate by Name attribute
			var genders = driver.FindElements(By.Name("gender"));
			foreach (var gender in genders)
			{
				if (gender.GetAttribute("value") == "Male")
					ClickOnButton(driver, gender);
			}

			//// Locate by Class name attribute
			//var form = driver.FindElement(By.ClassName("practice-form-wrapper"));

			////linkText
			//driver.FindElement(By.LinkText("Home"));
			////partialLinkText
			//driver.FindElement(By.PartialLinkText("Ho"));

			//var list = driver.FindElements(By.TagName("a"));

			//driver.FindElement(By.CssSelector("input[id= ‘userName’]"));

			//driver.FindElement(By.XPath("//input[@id='userName']"));

			Console.ReadKey();
			driver.Quit();
		}

		private static void ClickOnButton(IWebDriver driver, IWebElement element)
		{
			IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
			executor.ExecuteScript("arguments[0].click();", element);
		}

	}
}
