using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceLibrary
{
    public interface IProduct//shopping cart e product er jonno ja ja lagbe segulo thakbe edik
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        //shopping cart e product er description dorkar hoe na, tai description dewa holo na
    }
}
