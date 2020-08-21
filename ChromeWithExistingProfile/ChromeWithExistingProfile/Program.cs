using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChromeWithExistingProfile
{
	class Program
	{
		static void Main(string[] args)
		{
			ChromeOptions options = new ChromeOptions();
			options.AddArguments(@"user-data-dir=C:\Users\quoct\AppData\Local\Google\Chrome\User Data\");
			IWebDriver driver = new ChromeDriver(@"D:\OneDrive\Thang\HOCTAP\PUBLIC PROJECTS\SeleniumCSharp", options);
			driver.Navigate().GoToUrl("https://www.google.com.vn/?gws_rd=ssl");
			Console.ReadKey();
			driver.Close();
		}
	}
}
