using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_WebElementCommands
{
	class Program
	{
		static void Main(string[] args)
		{
			IWebDriver driver = new ChromeDriver(@"D:\OneDrive\Thang\HOCTAP\PUBLIC PROJECTS\SeleniumCSharp");
			driver.Url = "http://online.dlu.edu.vn/Login";
			Console.Write("Ten dang nhap: ");
			string taiKhoan = Console.ReadLine();
			Console.Write("Mat khau: ");
			string matKhau = Console.ReadLine();

			var txtTaiKhoan = driver.FindElement(By.Id("txtTaiKhoan"));
			var txtMatKhau = driver.FindElement(By.Id("txtMatKhau"));
			txtTaiKhoan.SendKeys(taiKhoan);
			txtMatKhau.SendKeys(matKhau);
			// driver.FindElement(By.XPath("/html/body/form/div[1]/div/div[7]/input")).Click();
			driver.FindElement(By.XPath("/html/body/form/div[1]/div/div[7]/input")).Submit();

			// WaitForDocumentReady(driver, TimeSpan.FromSeconds(30));

			if (driver.Title.Equals("Trang quản lý đào tạo", StringComparison.InvariantCultureIgnoreCase))
				Console.WriteLine("Dang nhap thanh cong");
			else Console.WriteLine("Dang nhap that bai");
			Console.ReadKey();
			driver.Close();
		}

		private static void WaitForDocumentReady(IWebDriver driver, TimeSpan waitTime)
		{
			var wait = new WebDriverWait(driver, waitTime);
			var javascript = driver as IJavaScriptExecutor;
			if (javascript == null)
				throw new ArgumentException("driver", "Driver must support javascript execution");

			wait.Until((d) =>
			{
				try
				{
					string readyState = javascript.ExecuteScript(
						"if (document.readyState) return document.readyState;").ToString();
					return readyState.ToLower() == "complete";
				}
				catch (InvalidOperationException e)
				{
					return e.Message.ToLower().Contains("unable to get browser");
				}
				catch (WebDriverException e)
				{
					return e.Message.ToLower().Contains("unable to connect");
				}
				catch (Exception)
				{
					return false;
				}
			});
		}
	}
}
