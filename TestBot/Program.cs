using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBot
{
    class Program
    {
        static void Main(string[] args)
        {

            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://fdc.nal.usda.gov/");

            IWebElement element = driver.FindElement(By.Name("query"));

            //Replaced by variable or product name from db eventually.
            element.SendKeys("Milk");

            element.SendKeys(Keys.Enter);

            var Click = driver.FindElement(By.Name("food-search-result-description"));
            Click.Click();

            //Need try catch and maybe wait time. It doesnt always find the value but it does exist.
            //This part could also be replaced with plain text.
            var servingSize = driver.FindElement(By.Name("basic nutrients, nutrient per 100g header"));

            if (servingSize.Text.Contains("100 ml")){

                Console.WriteLine("\n\n\nOne serving size is equal to 100ml");
            }
            else if (servingSize.Text.Contains("100 g"))
            {

                Console.WriteLine("\n\n\nOne serving size is equal to 100g");
            }
            else
            {

                Console.WriteLine("Could not find serving size data");
            }

            var locateNutritionVal = driver.FindElements(By.XPath("//*[@id='nutrients-table']/tbody/tr"));

            Console.WriteLine("\n\n\nNutrients per serving size:");

            foreach (var result in locateNutritionVal)
            {

                Console.WriteLine("\n" + result.Text);

            }

            //Using coordinates to find ingredients or figure out how to get it by class.
            //Might be able to use XPath



            //Close the browser window
            //driver.Close();

        }
    }
}
