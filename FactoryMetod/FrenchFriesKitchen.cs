using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2.FactoryMetod
{
    class FrenchFriesKitchen : Kitchen
    {
        public FrenchFriesKitchen()
        {
        }

        public FrenchFriesKitchen(int cost, int time) : base(cost, time)
        {
        }

        public override IProduct CreateProduct()
        {
            FrenchFriesProduct frenchFries = new FrenchFriesProduct();
            frenchFries.SetInfo(cost, time);
            return frenchFries;
        }
    }
}
