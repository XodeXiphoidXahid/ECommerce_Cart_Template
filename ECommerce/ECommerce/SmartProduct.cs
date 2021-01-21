using ECommerceLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce
{
    public class SmartProduct : IProduct
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }

        public string Description { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
    }

}
