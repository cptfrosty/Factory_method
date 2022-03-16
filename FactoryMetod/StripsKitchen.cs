using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2.FactoryMetod
{
    class StripsKitchen : Kitchen
    {
        public StripsKitchen()
        {
        }

        public StripsKitchen(int cost, int time) : base(cost, time)
        {
        }

        public override IProduct CreateProduct()
        {
            StripsProduct stripsProduct = new StripsProduct();
            stripsProduct.SetInfo(cost, time);
            return stripsProduct;
        }
    }
}
