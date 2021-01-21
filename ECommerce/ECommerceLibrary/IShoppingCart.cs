using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceLibrary
{
    public interface IShoppingCart<T> where  T : IProduct//public dewr reason hocche eta onk project e use kora hobe tai
    {
        ICartItem<T>[] Items { get; }//shopping cart er vitor cart item thakbe, tai ICartItem likha hoise, r cartItem gulor type holo IProduct

        void AddItem(T item, int quantity);
        double GetTotal();
    }
}
