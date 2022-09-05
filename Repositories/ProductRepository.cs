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
        DataContext context;
        public object products;

        public ProductRepository(DataContext context)
        {
            //initialize the DataContext field with parameter passed
            this.context = this.context;
        }

        /*
         * this method should accept product data and add it to the product collection
         * 
         */
        public void AddProduct(Product product)
        {
            // code to add product to file, ensuring that product is not null
            product.Add(products);
        }

       


        /*
         * this method should search for the product by the provided product id 
         * and if found should remove it from the collection
         * 
         * the method should return true for success and false for invalid id 
         */
        public bool RemoveProduct(string name)
        {
            // code to remove product by the id provided from file as parameter
            if (product.Contains(name))
            {
                product.Remove(name);
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
         * 
         * the method should return null for non-matching product name
         */
        public object GetProduct(string v)
        {
            if (product.Contains(v))
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
       /* public object GetProduct(int w)
        {

        }
       */
        
        /*
         * this method should return all items from the product collection
         */
        public void GetAllProducts()
        {
            foreach (var i in product)
            {
                Console.WriteLine($"Remaining items are:{i}");
            }
        }
    }
}
