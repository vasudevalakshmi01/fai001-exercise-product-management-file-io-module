﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    /*
     * this serializable class models product data that includes product id, product name, price and in-stock status
     */

    public class Product
    {
        /*
         * define properties for Product model attributes 
         */
        public int Price { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public bool InStock { get; set; }


        /*
         * Override ToString() method to return string equivalent of product object containing product details
         */
        public override string ToString()
        {
            return $"Price: {Price},ProductId: {ProductId},ProductName: {ProductName},InStock: {InStock}";
        }
    }
}
