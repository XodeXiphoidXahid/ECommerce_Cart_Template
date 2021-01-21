using ECommerceLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce
{
    public class SmartCart : IShoppingCart<SmartProduct>
    {
        public ICartItem<SmartProduct>[] Items { get; private set; }
        public static int itemCount;
        public SmartCart()
        {
            Items = new ICartItem<SmartProduct>[100];
            itemCount = 0;
        }

        public void AddItem(SmartProduct item, int quantity)
        {
            Items[itemCount++] = new CartItem()
            {
                Product = item,
                Quantity = quantity
            };
        }

        public double GetTotal()
        {
            var total = 0.0;
            foreach(var item in Items)
            {
                total += item.Product.Price;
            }
            return total;
        }
    }
}
