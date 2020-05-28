using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
	class Program
	{
		static void Main(string[] args)
		{
			IWebDriver driver = new ChromeDriver(@"D:\OneDrive\Thang\HOCTAP\PUBLIC PROJECTS\SeleniumCSharp");
			driver.Url = "http://demoqa.com/";
			driver.FindElement(By.XPath("//*[@id='app']/div/div/div[2]/div/div[1]")).Click();
			driver.Navigate().Back();
			driver.Navigate().Forward();
			driver.Navigate().GoToUrl("http://demoqa.com/");
			driver.Navigate().Refresh();
			Console.ReadKey();
			driver.Close();
		}
	}
}
