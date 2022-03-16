using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2.FactoryMetod
{
    class HamburgerKitchen : Kitchen
    {
        public HamburgerKitchen()
        {
        }

        public HamburgerKitchen(int cost, int time) : base(cost, time)
        {
        }

        public override IProduct CreateProduct()
        {
            HamburgerProduct hamburgerProduct = new HamburgerProduct();
            hamburgerProduct.SetInfo(cost, time);
            return hamburgerProduct;
        }
    }
}
