using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Text;

namespace _1_SetupSelenium
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			IWebDriver driver = new ChromeDriver(@"D:\OneDrive\Thang\HOCTAP\PUBLIC PROJECTS\SeleniumCSharp\");
			driver.Url = "http://online.dlu.edu.vn"; //This method Load a new web page in the current browser window.
			string title = driver.Title;
			int titleLen = title.Length; // driver.Title.Length;
			Console.WriteLine($"Title of this page: {title}, length: {titleLen}");
			string pageUrl = driver.Url;
			int urlLen = driver.Url.Length;
			Console.WriteLine($"URL of this page: {pageUrl}, length: {urlLen}");
			string pageSource = driver.PageSource;
			int sourceLen = driver.PageSource.Length;
			Console.WriteLine($"Page length: {sourceLen}");
			Console.ReadKey();
			driver.Close();
		}
	}
}
