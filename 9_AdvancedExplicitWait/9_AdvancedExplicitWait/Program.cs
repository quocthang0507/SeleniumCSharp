using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_AdvancedExplicitWait
{
	class Program
	{
		static void Main(string[] args)
		{
			IWebDriver driver = new ChromeDriver(@"D:\OneDrive\Thang\HOCTAP\PUBLIC PROJECTS\SeleniumCSharp");
			driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-switch-windows");
			IWebElement element = driver.FindElement(By.Id("clock"));
			DefaultWait<IWebElement> wait = new DefaultWait<IWebElement>(element);
			wait.Timeout = TimeSpan.FromMinutes(2);
			wait.PollingInterval = TimeSpan.FromMilliseconds(250);
			Func<IWebElement, bool> waiter = new Func<IWebElement, bool>((IWebElement ele) =>
			   {
				   string style = element.Text;
				   if (style.Contains("Buzz"))
					   return true;
				   Console.WriteLine("Current time is " + style);
				   return false;
			   });
			wait.Until(waiter);
			Console.ReadKey();
			driver.Quit();
		}
	}
}
