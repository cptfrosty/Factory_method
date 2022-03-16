using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2.FactoryMetod
{
    class SaladsKitchen : Kitchen
    {
        public SaladsKitchen()
        {
        }

        public SaladsKitchen(int cost, int time) : base(cost, time)
        {
        }

        public override IProduct CreateProduct()
        {
            SaladProduct saladProduct = new SaladProduct();
            saladProduct.SetInfo(cost, time);
            return saladProduct;
        }
    }
}
