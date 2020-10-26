using GroceryGetter.BL;
using GroceryGetter.BL.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class Program
    {

        static void Main(string[] args)
        {
            UserProduct product = new UserProduct();
            //string json = @"[{""InCart"":false,""Amount"":4,""Notes"":""Get a fresh date"",""Id"":""00000000 - 0000 - 0000 - 0000 - 000000000000","Title":"Whole Wheat Bread","Store":2,"Aisle":0},{"InCart":false,"Amount":3,"Notes":"2 % fat","Id":"00000000 - 0000 - 0000 - 0000 - 000000000000","Title":"Milk","Store":0,"Aisle":1}]";

            //string test =;

            List<UserProduct> userProducts = new List<UserProduct>();

            product.Id = Guid.NewGuid();
            product.Aisle = AisleLocation.BREAD;
            product.Title = "Whole Wheat Bread";
            product.Store = StoreLocation.KROGGER;
            product.Notes = "Get a fresh date";
            product.InCart = false;
            //product.Amount = 4;
            userProducts.Add(product);

            product.Id = Guid.NewGuid();
            product.Aisle = AisleLocation.CLEANING;
            product.Title = "Should be last";
            product.Store = StoreLocation.KROGGER;
            product.Notes = "Get a fresh date";
            product.InCart = false;
            //product.Amount = 4;
            userProducts.Add(product);


            product = new UserProduct();

            product.Id = Guid.NewGuid();
            product.Aisle = AisleLocation.DAIRY;
            product.Title = "Milk";
            product.Store = StoreLocation.WALMART;
            product.Notes = "2% fat";
            product.InCart = false;
            //product.Amount = 3;
            userProducts.Add(product);

            product.Id = Guid.NewGuid();
            product.Aisle = AisleLocation.BREAD;
            product.Title = "Old Wheat Bread";
            product.Store = StoreLocation.KROGGER;
            product.Notes = "Get a fresh date";
            product.InCart = false;
            //product.Amount = 4;
            userProducts.Add(product);


            string output = ProductHelper.ObjectToJson(userProducts);

            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data\junk.txt");


            System.IO.File.WriteAllText(path, output);


            Console.WriteLine($" products as a string\n {output}");

            Console.WriteLine("-------");
            Console.WriteLine("products as POCO\n");


            userProducts = ProductHelper.JsonToOjects(output);

            var filteredList = userProducts.Where(p => p.Store == StoreLocation.WALMART).ToList();
            Console.WriteLine(filteredList.Count());

            var filteredList2 = userProducts.Where(p => p.Aisle == AisleLocation.PRODUCE).ToList();
            Console.WriteLine(filteredList.Count());

            




            foreach (UserProduct x in userProducts)
            {
                Console.WriteLine($"Title = {x.Title}");
                Console.WriteLine($"Notes = {x.Notes}");
                Console.WriteLine($"Store = {x.Amount}");
            }
             
            


            var orderedList = ProductHelper.OderByLayout(userProducts);

            foreach (UserProduct x in orderedList)
            {
                Console.WriteLine($"Title = {x.Title}");
            }

            Console.ReadLine();



        }
    }
}
