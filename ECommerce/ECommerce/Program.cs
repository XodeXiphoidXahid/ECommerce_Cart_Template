using ECommerceLibrary;
using System;

namespace ECommerce
{
    class Program
    {
        static void Main(string[] args)
        {
            IShoppingCart<SuperSmartProduct> cart = new SmartCart();
            cart.AddItem(new SuperSmartProduct
            {
                Name = "Camera",
                Price = 300,
                Size = "M",
                Color = "Black",
                Description = "This is Cannon Camera",
                Weight = 99
            }, 3);

            cart.AddItem(new SuperSmartProduct
            {
                Name = "Laptop",
                Price = 5000,
                Size = "L",
                Color = "Silver",
                Description = "This is ASUS laptop",
                Weight = 300
            }, 2);

            var total = cart.GetTotal();

            Console.WriteLine("Total = " + total);
        }
    }
}
