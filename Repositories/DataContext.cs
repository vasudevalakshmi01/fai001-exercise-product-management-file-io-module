using Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Repositories
{
    // this class provides functionalities to read and write product collection a with file 

    public class DataContext
    {
        // declare field for filename with path
        string filepath = @"C:\Users\cvlakshmisaip\Documents\Assignment1\";
        string fileName = "lest.cs";
        

        // declare field for list of products
        List<string> item = new List<string>();

        // the constructor should accept filename and path strings
        public DataContext(string fileName, string filepath )
        {
            if (!File.Exists(fileName))
                File.Create(@"C:\Users\cvlakshmisaip\Documents\Assignment1\lest.cs");
            // the constructor code should open file if it exists else create new
            else {
                var fs = File.Open(fileName, FileMode.OpenOrCreate); }
            if (File.ReadAllText(@"C:\Users\cvlakshmisaip\Documents\Assignment1\lest.cs") == "")
            {
                File.WriteAllText(@"C:\Users\cvlakshmisaip\Documents\Assignment1\lest.cs", "List<string> item = new List<string>();");
            }
            // the code should read data from file if it contains any data

            // the data read should populate the list of products field


            // if no data is present an empty list should be created 


        }

        // this method should return the list of products read from file
         public static void ReadProducts()
        {
            // return data of the product list
            string d = Console.ReadLine();
            



        }

        // this method should add the product data passed as parameter to the list of products
        public void AddProduct(string de)
        {
            item.Add(de);
            
        }

        // this method should write the data from list of products to file and make data persistent
         public void SaveChanges()
        {
            // implement serialization
            XmlSerializer xml = new XmlSerializer(typeof(List<string>));
            Stream stream = new FileStream(@"D:\FATraining\Temp\Serialize\items.xml"
                                   , FileMode.OpenOrCreate);
            xml.Serialize(stream,item);

        }


        public void  CleanUp()
        { // this method should delete the file if exists
            if (!File.Exists(fileName))
                File.Delete(@"C:\Users\cvlakshmisaip\Documents\Assignment1\lest.cs");

        }
    }
}
