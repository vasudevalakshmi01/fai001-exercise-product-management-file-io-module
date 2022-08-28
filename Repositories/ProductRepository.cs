using Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
    public class ProductRepository
    {
        // declare field of type DataContext
        public string name { get; set; }
        List<string> item = new List<string>();

        public ProductRepository(string name)
        {
            //initialize the DataContext field with parameter passed
            this.name=name;
        }

        /*
         * this method should accept product data and add it to the product collection
         * 
         */
        public void AddProduct(string name)
        {
            // code to add product to file, ensuring that product is not null
            item.Add(name);
        }


        /*
         * this method should search for the product by the provided product id 
         * and if found should remove it from the collection
         * 
         * the method should return true for success and false for invalid id 
         */
        public  bool RemoveProduct(string name)
        {
            // code to remove product by the id provided from file as parameter
            if (item.Contains(name))
            {
                item.Remove(name);
                return true;
            }
            else
            {
                return false;
            }
        }

     

       

        /*
         * this method should search and return product by product name from the file 
         * 
         * the search value should be passed as parameter
         * asd
         * the method should return null for non-matching product name
         */
        public bool GetProduct(string name)
        {
            if (item.Contains(name))
            {
               return true;
            }
            else
            {
                return false;
            }

        }

        /*
         * this method should search and return product by product id from the collection 
         * 
         * the search value should be passed as parameter
         * 
         * the method should return null for non-matching product id
         */
        /*public  bool GetProduct(string name)
        {
            if (item.Contains(name))
            {
                item.Remove(name);
                return true;
            }
            else
            {
                return false;
            }
        }
        */
     


        /*
         * this method should return all items from the product collection
         */
        public  void GetAllProducts(DataContext context)
        {
            foreach(var i in item)
            {
                Console.WriteLine($"Remaining items are:{i}");
            }
        }

        
    }
}
