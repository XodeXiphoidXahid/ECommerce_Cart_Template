using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceLibrary
{
    public interface ICartItem<T> where T: IProduct//like football, camera, Soap
    {
        IProduct Product { get; set; }
        int Quantity { get; set; }
    }
}
