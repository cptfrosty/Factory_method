using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2.FactoryMetod
{
    abstract class Kitchen
    {
        protected int cost;
        protected int time;

        public Kitchen() { }

        public Kitchen(int cost, int time)
        {
            this.cost = cost;
            this.time = time;
        }

        public abstract IProduct CreateProduct();
    }
}
