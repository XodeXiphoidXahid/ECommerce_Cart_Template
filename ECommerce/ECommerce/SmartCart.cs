using ECommerceLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce
{
    public class SmartCart : IShoppingCart<SuperSmartProduct>
    {
        public ICartItem<SuperSmartProduct>[] Items { get; private set; }
        public static int itemCount;
        public SmartCart()
        {
            Items = new ICartItem<SuperSmartProduct>[100];
            itemCount = 0;
        }

        public void AddItem(SuperSmartProduct item, int quantity)
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
                if(item!=null)
                    total += (item.Product.Price * item.Quantity);
            }
            return total;
        }
    }
}
