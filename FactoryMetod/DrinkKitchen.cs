using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2.FactoryMetod
{
    class DrinkKitchen : Kitchen
    {
        public DrinkKitchen()
        {
        }

        public DrinkKitchen(int cost, int time) : base(cost, time)
        {
        }

        public override IProduct CreateProduct()
        {
            DrinkProduct drinkProduct = new DrinkProduct();
            drinkProduct.SetInfo(cost, time);

            return drinkProduct;
        }
    }
}
