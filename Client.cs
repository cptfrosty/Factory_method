using System;
using System.Collections.Generic;
using Laba2.FactoryMetod;

namespace Laba2
{
    class Client
    {
        public List<IProduct> MakeAnOrder()
        {
            List<IProduct> products = new List<IProduct>();
            Random rnd = new Random();
            int countPos = rnd.Next(1, 5);
            
            for(int i = 0; i < countPos; i++)
            {
                int pos = rnd.Next(0, ProductsMenu.GetCount);
                products.Add(ProductsMenu.GetProduct(pos));
            }

            return products;
        }
    }
}
