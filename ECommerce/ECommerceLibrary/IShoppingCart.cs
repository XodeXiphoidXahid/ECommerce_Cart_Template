using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceLibrary
{
    public interface IShoppingCart<T> where  T : IProduct//public dewr reason hocche eta onk project e use kora hobe tai
    {
        ICartItem<T>[] Items { get; }//shopping cart er vitor cart item thakbe, tai ICartItem likha hoise, r cartItem gulor type holo IProduct
        //Iproduct e quantity nam e kono field nai, but IShoppingCart e product er nam er shathe quantity o lagbe
        void AddItem(T item, int quantity);
        double GetTotal();
    }
}
