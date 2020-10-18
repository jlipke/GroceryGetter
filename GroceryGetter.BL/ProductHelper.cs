using GroceryGetter.BL.Models;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

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
            product.Aisle = Product.AisleLoction.BREAD;
            product.Title = "Whole Wheat Bread";
            product.Store = Product.StoreLoction.KROGGER;
            product.Notes = "Get a fresh date";
            product.InCart = false;
            userProducts.Add(product);

            product = new UserProduct();

            product.Id = Guid.NewGuid();
            product.Aisle = Product.AisleLoction.DAIRY;
            product.Title = "Milk";
            product.Store = Product.StoreLoction.WALMART;
            product.Notes = "2% fat";
            product.InCart = false;
            userProducts.Add(product);

            product = new UserProduct();

            product.Id = Guid.NewGuid();
            product.Aisle = Product.AisleLoction.DAIRY;
            product.Title = "Cheese";
            product.Store = Product.StoreLoction.WALMART;
            product.InCart = false;
            userProducts.Add(product);

            product = new UserProduct();

            product.Id = Guid.NewGuid();
            product.Aisle = Product.AisleLoction.CEREAL;
            product.Title = "Cork Flakes";
            product.Store = Product.StoreLoction.ALDI;
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


       

    }
}
