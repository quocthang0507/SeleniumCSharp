using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _8_ImplicitWaitCommand
{
	class Program
	{
		static void Main(string[] args)
		{
			IWebDriver driver = new ChromeDriver(@"D:\OneDrive\Thang\HOCTAP\PUBLIC PROJECTS\SeleniumCSharp");
			driver.Navigate().GoToUrl("https://www.google.com.vn/?gws_rd=ssl");

			// Implicit wait
			// Implicit wait is used to inform webdriver that there could be cases when 
			// some elements on the webpage will not be present instantaneously
			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
			IWebElement element = driver.FindElement(By.Name("q"));
			element.SendKeys("github la quoc thang");
			element.SendKeys(Keys.Enter);

			// Page Load Timeout
			// Sets the amount of time to wait for a page load to complete before 
			// throwing an error. If the timeout is negative, page loads can be 
			// indefinite
			driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(500);
			driver.Navigate().GoToUrl("https://shopee.vn/");
			element = driver.FindElement(By.ClassName("shopee-popup__close-btn"));
			element.Click();

			Console.ReadKey();
			driver.Close();
		}
	}
}
