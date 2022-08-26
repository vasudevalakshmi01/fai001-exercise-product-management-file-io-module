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

        public ProductRepository(<parameter>)
        {
            //initialize the DataContext field with parameter passed    
        }

        /*
         * this method should accept product data and add it to the product collection
         * 
         */
        public <return_type> AddProduct(<parameter>)
        {
            // code to add product to file, ensuring that product is not null
        }


        /*
         * this method should search for the product by the provided product id 
         * and if found should remove it from the collection
         * 
         * the method should return true for success and false for invalid id 
         */
        public <return_type> RemoveProduct(<parameter>)
        {
            // code to remove product by the id provided from file as parameter    
        }

        /*
         * this method should search and return product by product name from the file 
         * 
         * the search value should be passed as parameter
         * 
         * the method should return null for non-matching product name
         */
        public <return_type> GetProduct(<parameter>)
        {

        }

        /*
         * this method should search and return product by product id from the collection 
         * 
         * the search value should be passed as parameter
         * 
         * the method should return null for non-matching product id
         */
        public <return_type> GetProduct(<parameter>)
        {

        }

        
        /*
         * this method should return all items from the product collection
         */
        public <return_type> GetAllProducts()
        {

        }
    }
}
