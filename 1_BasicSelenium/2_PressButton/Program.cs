using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PressButton
{
	class Program
	{
		static void Main(string[] args)
		{
			IWebDriver driver = new ChromeDriver(@"D:\OneDrive\Thang\HOCTAP\PUBLIC PROJECTS\SeleniumCSharp");
			driver.Url = "http://online.dlu.edu.vn/Login";
			driver.FindElement(By.XPath(".//*[@class='btn btn-primary btn-block']")).Click();
			Console.ReadKey();
			driver.Close();
		}
	}
}
