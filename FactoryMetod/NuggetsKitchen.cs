using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2.FactoryMetod
{
    class NuggetsKitchen : Kitchen
    {
        public NuggetsKitchen()
        {
        }

        public NuggetsKitchen(int cost, int time) : base(cost, time)
        {
        }

        public override IProduct CreateProduct()
        {
            NuggetsProduct nuggetsProduct = new NuggetsProduct();
            nuggetsProduct.SetInfo(cost, time);
            return nuggetsProduct;
        }
    }
}
