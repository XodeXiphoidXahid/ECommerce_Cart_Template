using ECommerceLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce
{
    class CartItem : ICartItem<SmartProduct>
    {
        public IProduct Product { get; set; }
        public int Quantity { get; set; }


    }
}
