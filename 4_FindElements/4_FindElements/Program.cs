using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_FindElements
{
	class Program
	{
		static void Main(string[] args)
		{
			IWebDriver driver = new ChromeDriver(@"D:\OneDrive\Thang\HOCTAP\PUBLIC PROJECTS\SeleniumCSharp");
			driver.Url = "https://shopee.vn/";
			var btnClosePopup = driver.FindElement(By.ClassName("shopee-popup__close-btn"));
			btnClosePopup.Click();
			var tbxSearch = driver.FindElement(By.ClassName("shopee-searchbar-input__input"));
			tbxSearch.SendKeys("luong kho");
			tbxSearch.SendKeys(Keys.Enter);
			Console.ReadKey();
			driver.Close();

		}
	}
}
