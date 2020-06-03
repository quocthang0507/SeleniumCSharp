using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CheckBoxAndRadioButton
{
	class Program
	{
		static void Main(string[] args)
		{
			IWebDriver driver = new ChromeDriver(@"D:\OneDrive\Thang\HOCTAP\PUBLIC PROJECTS\SeleniumCSharp");
			driver.Url = "http://www.demoqa.com/automation-practice-form";
			var firstName = driver.FindElement(By.Id("firstName"));
			firstName.SendKeys("Thang");
			var lastName = driver.FindElement(By.Id("lastName"));
			lastName.SendKeys("La Quoc");
			var email = driver.FindElement(By.Id("userEmail"));
			email.SendKeys("quocthang_0507@yahoo.com.vn");
			var genders = driver.FindElements(By.Name("gender"));
			foreach (var g in genders)
			{
				if (g.GetAttribute("value") == "Male")
				{
					ClickOnButton(driver, g);
				}
			}
			var userNumber = driver.FindElement(By.Id("userNumber"));
			userNumber.SendKeys("0987654321");
			var birthday = driver.FindElement(By.Id("dateOfBirthInput"));
			SetValueInput(driver, birthday, "05 Jul 1998");
			var hobbies = driver.FindElements(By.TagName("input"));
			foreach (var h in hobbies)
			{
				if (h.GetAttribute("type") == "checkbox")
				{
					ClickOnButton(driver, h);
				}
			}

			Console.ReadKey();
			driver.Close();
		}

		private static void ClickOnButton(IWebDriver driver, IWebElement element)
		{
			IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
			executor.ExecuteScript("arguments[0].click();", element);
		}

		private static void SetValueInput(IWebDriver driver, IWebElement element, string content)
		{
			// IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
			// executor.ExecuteScript("arguments[0].setAttribute('value', arguments[1])", element, content); ;
			element.SendKeys(Keys.Control + "a");
			element.SendKeys(content);
		}
	}
}
