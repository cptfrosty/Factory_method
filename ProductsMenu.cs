using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laba2.FactoryMetod;

namespace Laba2
{
    class ProductsMenu
    {
        static Kitchen[] kitchens =
        {
            //new DrinkKitchen(),
            new FrenchFriesKitchen(70,4),
            new FrenchFriesKitchen(100,6),
            new HamburgerKitchen(100,2),
            new HamburgerKitchen(77,3),
            new NuggetsKitchen(149,2),
            new SaladsKitchen(150,2),
            new SaladsKitchen(200,5),
            new StripsKitchen(160,3)
        };

        public static int GetCount {
            get 
            {
                return kitchens.Length;
            }
        }
        public static IProduct GetProduct(int id) => kitchens[id].CreateProduct();
    }
}
