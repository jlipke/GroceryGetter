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
            product.Amount = 4;
            userProducts.Add(product);

            product = new UserProduct();

            product.Id = Guid.NewGuid();
            product.Aisle = Product.AisleLoction.DAIRY;
            product.Title = "Milk";
            product.Store = Product.StoreLoction.WALMART;
            product.Notes = "2% fat";
            product.InCart = false;
            product.Amount = 3;
            userProducts.Add(product);

            product = new UserProduct();

            product.Id = Guid.NewGuid();
            product.Aisle = Product.AisleLoction.DAIRY;
            product.Title = "Cheese";
            product.Store = Product.StoreLoction.WALMART;
            product.InCart = false;
            product.Amount = 2;
            userProducts.Add(product);

            product = new UserProduct();

            product.Id = Guid.NewGuid();
            product.Aisle = Product.AisleLoction.CEREAL;
            product.Title = "Cork Flakes";
            product.Store = Product.StoreLoction.ALDI;
            product.InCart = true;
            product.Amount = 2;
            userProducts.Add(product);


            return userProducts; 
        }

        public static List<UserProduct> JsonToOjects(string input)
        {
            products = JsonConvert.DeserializeObject<List<UserProduct>>(input);
            return products;
        } 

        public static string ObjectToJson(List<UserProduct> input)
        {
            json = JsonConvert.SerializeObject(input, Formatting.Indented);
            return json;
        }



    }
}
