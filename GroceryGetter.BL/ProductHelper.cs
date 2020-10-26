using GroceryGetter.BL.Models;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;

namespace GroceryGetter.BL
{
    public static class ProductHelper
    {

        static List<UserProduct> products = new List<UserProduct>();
        static string json;

        /// <summary>
        /// Creates a list of defalut User Products.
        /// </summary>
        /// <returns></returns>
        public static List<UserProduct> GetSomeDummyData()
        {
            UserProduct product = new UserProduct();
            List<UserProduct> userProducts = new List<UserProduct>();

            product.Id = Guid.NewGuid();
            product.Aisle = AisleLocation.BREAD;
            product.Title = "Whole Wheat Bread";
            product.Store = StoreLocation.KROGGER;
            product.Notes = "Get a fresh date";
            product.InCart = false;
            userProducts.Add(product);

            product = new UserProduct();

            product.Id = Guid.NewGuid();
            product.Aisle = AisleLocation.DAIRY;
            product.Title = "Milk";
            product.Store = StoreLocation.WALMART;
            product.Notes = "2% fat";
            product.InCart = false;
            userProducts.Add(product);

            product = new UserProduct();

            product.Id = Guid.NewGuid();
            product.Aisle = AisleLocation.DAIRY;
            product.Title = "Cheese";
            product.Store = StoreLocation.WALMART;
            product.InCart = false;
            userProducts.Add(product);

            product = new UserProduct();

            product.Id = Guid.NewGuid();
            product.Aisle = AisleLocation.CEREAL;
            product.Title = "Cork Flakes";
            product.Store = StoreLocation.ALDI;
            product.InCart = true;
            userProducts.Add(product);


            return userProducts;
        }

        /// <summary>
        /// Takes in a JSON string and returns a list of User Products
        /// </summary>
        /// <param name="input">A string of JSON </param>
        /// <returns></returns>
        public static List<UserProduct> JsonToOjects(string input)
        {
            products = JsonConvert.DeserializeObject<List<UserProduct>>(input);
            return products;
        }

        /// <summary>
        /// Takes in a list of User Products and returns a string (for database) 
        /// </summary>
        /// <param name="input">A list of User Products</param>
        /// <returns></returns>
        public static string ObjectToJson(List<UserProduct> input)
        {
            json = JsonConvert.SerializeObject(input, Formatting.Indented);
            return json;
        }

        /// <summary>
        /// Takes in a list of UserProducts, add an item, then returns the new list
        /// </summary>
        /// <param name="p">The product you want to remove</param>
        /// <param name="list">The list you want to change</param>
        /// <returns></returns>
        public static List<UserProduct> AddItemToList(UserProduct p, List<UserProduct> list)
        {
            List<UserProduct> tempList = list;
            tempList.Add(p);
            return tempList;
        }

        public static void AddFromMaster(Product p, List<UserProduct> list, User user)
        {
            UserProduct up = (UserProduct)p;
            List<UserProduct> tempList = list;
            user.GroceryListObj.Add(up);
            //tempList.Add(up);
            //return tempList;
        }

        /// <summary>
        /// Takes in a list of UserProducts, removes an item, then returns the new list
        /// </summary>
        /// <param name="p">The product you want to remove</param>
        /// <param name="list">The list you want to change</param>
        /// <returns></returns>
        public static List<UserProduct> RemoveItemToList(UserProduct p, List<UserProduct> list)
        {
            List<UserProduct> tempList = list;
            tempList.RemoveAll(x => x.Id == p.Id); // Removes the product from the list that
                                                   // matches the product that was passed in
            return tempList;
        }


        /// <summary>
        /// Takes in a list then orders it by store layout. 
        /// </summary>
        /// <param name="input">The list of user products that need ordering</param>
        /// <param name="store">The name of the store</param>
        /// <returns></returns>
        public static List<UserProduct> OderByLayout(List<UserProduct> input /*,Dictionary<AisleLocation, int> store*/) // might replace 2nd param with emun or string -devonte
        {

            // Will use switch case to figure out with dictionary to load up - devonte


            // Once all the dictionaries are fillout, this one will be removed. -devonte
            var walmartLayout = new Dictionary<AisleLocation, int>() {
                { AisleLocation.BREAD, 0 },
                { AisleLocation.CEREAL, 1 },
                { AisleLocation.PRODUCE, 2 },
                { AisleLocation.CLEANING, 3 }
            };

            var orderedList = input.OrderBy(m => walmartLayout[m.Aisle]).ToList();

            return orderedList;

            /* old way. will need to remove once completely done with new way -devonte
            var sortedResult = input
           .OrderBy(z => z.Aisle == AisleLocation.BREAD ? 1 : 2)
           .ThenBy(z => z.Aisle == AisleLocation.CEREAL ? 1 : 2)
           .ThenBy(z => z.Aisle == AisleLocation.PRODUCE ? 1 : 2)
           .ToList();

            return sortedResult;
            */

        }



    }
}
