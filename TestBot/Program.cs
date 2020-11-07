using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

            //Replaced by variable or product name from db eventually. Do not include special characters
            string productName = "Coconut";

            element.SendKeys(productName);

            element.SendKeys(Keys.Enter);

            Console.WriteLine("\n\n\nThe product you searched for is: " + productName);

            try
            {

                Thread.Sleep(2000);

                var productResult = driver.FindElement(By.Name("food-search-result-description"));

                Console.WriteLine("\nThe closest product match found is: " + productResult.Text);

                var click = driver.FindElement(By.Name("food-search-result-description"));
                click.Click();

                try
                {

                    Thread.Sleep(2000);

                    var servingSize = driver.FindElement(By.Name("basic nutrients, nutrient per 100g header"));

                    if (servingSize.Text.Contains("100 ml"))
                    {

                        Console.WriteLine("\nOne serving size is equal to 100ml.");
                    }
                    else if (servingSize.Text.Contains("100 g"))
                    {

                        Console.WriteLine("\nOne serving size is equal to 100g.");
                    }
                    else
                    {

                        Console.WriteLine("\nCould not find serving size data");
                    }

                }
                catch (NoSuchElementException)
                {

                    Console.WriteLine("\nA Serving size is equal to 100ml for liquid products.");
                    Console.WriteLine("\nA Serving size is equal to 100g for solid products.");
                }

                try
                {

                    Thread.Sleep(2000);

                    var locateNutritionVal = driver.FindElements(By.XPath("//*[@id='nutrients-table']/tbody/tr"));

                    Console.WriteLine("\n\n\n\nNutrients per serving size:");

                    foreach (var NutritionVal in locateNutritionVal)
                    {

                        Console.WriteLine("\n\n" + NutritionVal.Text);
                    }
                }
                catch (NoSuchElementException)
                {

                    Console.WriteLine("\n\n\n\nSorry, Could not find information on nutritional value.");
                }

                try
                {

                    Thread.Sleep(1000);

                    var ingredients = driver.FindElement(By.XPath("//*[@id='nutrients']/app-food-nutrients/div/div[2]/div"));

                    Console.WriteLine("\n\n\n\n" + ingredients.Text);
                }
                catch (NoSuchElementException)
                {

                    Console.WriteLine("\n\n\n\nSorry, ingredients are not available for this product.");
                }

                //Close the browser window
                //driver.Close();
            }
            catch (NoSuchElementException)
            {

                Console.WriteLine("\nSorry, The product information you are looking for does not exist.");

                //Close the browser window
                //driver.Close();

            }
        }
    }
}
