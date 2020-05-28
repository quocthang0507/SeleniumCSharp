using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_NavigationCommands
{
	class Program
	{
		static void Main(string[] args)
		{
			IWebDriver driver = new ChromeDriver(@"D:\OneDrive\Thang\HOCTAP\PUBLIC PROJECTS\SeleniumCSharp");
			driver.Url = "http://online.dlu.edu.vn"; // Waiting for completely loading this page
			driver.Navigate().GoToUrl("https://toolsqa.com"); // Then, load this page
			driver.Navigate().Back(); // Back to the previous page (url)
			driver.Navigate().Forward(); // Finally, go to the next historic page (url)
			driver.Navigate().Refresh();
		}
	}
}
