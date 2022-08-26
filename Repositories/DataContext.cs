using Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Repositories
{
    // this class provides functionalities to read and write product collection data with file

    public class DataContext
    { 
        // declare field for filename with path
        // declare field for list of products
        


        // the constructor should accept filename and path strings
        public DataContext(<parameter1>,<parameter2>)
        {
            // the constructor code should open file if it exists else create new

            // the code should read data from file if it contains any data

            // the data read should populate the list of products field

            // if no data is present an empty list should be created 
            
        }

        // this method should return the list of products read from file
        public <return-type> ReadProducts()
        {
            // return data of the product list
        }

        // this method should add the product data passed as parameter to the list of products
        public <return-type> AddProduct(<parameter1>)
        {
            
        }

        // this method should write the data from list of products to file and make data persistent
        public <return-type> SaveChanges()
        {
            // implement serialization
        }

        // this method should delete the file if exists
        public <return-type> CleanUp()
        {

        }
    }
}
