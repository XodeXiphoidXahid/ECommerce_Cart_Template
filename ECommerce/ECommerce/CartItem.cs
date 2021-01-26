using ECommerceLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce
{
    class CartItem : ICartItem<SuperSmartProduct>//ekhane SuperSmartProduct use korar reason ki?
    {
        public IProduct Product { get; set; }
        public int Quantity { get; set; }


    }
}
