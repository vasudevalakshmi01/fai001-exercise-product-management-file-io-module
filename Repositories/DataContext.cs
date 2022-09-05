using Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Serialization;

namespace Repositories
{
    // this class provides functionalities to read and write product collection data with filed


    public class DataContext
    {
        public string v;
        public string rootFolder;
        public DataContext(string v, string rootFolder)
        {
            this.v = v;
            this.rootFolder = rootFolder;
        }

        // declare field for filename with path
        // declare field for list of products



        // the constructor should accept filename and path strings
        public DataContext(string v, string rootFolder)
        {
            if (!File.Exists(v))
                File.Create(@"C:\Users\cvlakshmisaip\Documents\Assignment1\lest.cs");
            else
            {
                var fs = File.Open(v, FileMode.OpenOrCreate);
            }
            if (File.ReadAllText(@"C:\Users\cvlakshmisaip\Documents\Assignment1\lest.cs") == "")
            {
                File.WriteAllText(@"C:\Users\cvlakshmisaip\Documents\Assignment1\lest.cs", "List<string> item = new List<string>();");
            }
            // the constructor code should open file if it exists else create new

            // the code should read data from file if it contains any data

            // the data read should populate the list of products field

            // if no data is present an empty list should be created 

        }

        public DataContext()
        {
        }

        // this method should return the list of products read from file
        public void ReadProducts()
        {
            // return data of the product list
            string d = Console.ReadLine();
        }

        // this method should add the product data passed as parameter to the list of products
        public void AddProduct(Product product)
        {
            product.Add(products);
            
        }

        // this method should write the data from list of products to file and make data persistent
        public void SaveChanges()
        {
            // implement serialization
            List<Product> products= new List<Product>();
            products.Add(new Product { Price= 2500, ProductId =1001, ProductName = "Titan white square dial watch for men", InStock=true });



            XmlSerializer xml = new XmlSerializer(typeof(List<Product>));
            Stream stream = new FileStream(@"D:\FATraining\Temp\Serialize\Employees.xml"
                                  , FileMode.OpenOrCreate);

            xml.Serialize(stream, products);
        }

        // this method should delete the file if exists
        public void CleanUp()
        {
            if (!File.Exists(v))
                File.Delete(@"C:\Users\cvlakshmisaip\Documents\Assignment1\lest.cs");
        }

     
    }
}
