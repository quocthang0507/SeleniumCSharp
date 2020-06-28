using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_WebTables
{
	class Program
	{
		static void Main(string[] args)
		{
			// Open browser and maximize window size
			IWebDriver driver = new ChromeDriver(@"D:\OneDrive\Thang\HOCTAP\PUBLIC PROJECTS\SeleniumCSharp");
			driver.Manage().Window.Maximize();
			// Navigate to specific URL
			driver.Navigate().GoToUrl("https://en.wikipedia.org/wiki/Programming_languages_used_in_most_popular_websites");
			// Xpath of html table
			IWebElement table = driver.FindElement(By.XPath("//div[@id='mw-content-text']//table[1]"));
			// Fetch all row of the table
			List<IWebElement> rows = new List<IWebElement>(table.FindElements(By.TagName("tr")));
			if (rows.Count > 0)
				foreach (var row in rows)
				{
					string rowData = "";
					List<IWebElement> cols = new List<IWebElement>(row.FindElements(By.TagName("td")));
					if (cols.Count > 0)
						foreach (var col in cols)
						{
							rowData = rowData + col.Text + "\t\t";
						}
					Console.WriteLine(rowData);
				}
			Console.ReadKey();
			driver.Quit();
		}
	}
}
