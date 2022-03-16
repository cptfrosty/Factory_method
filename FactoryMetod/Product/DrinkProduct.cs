using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2.FactoryMetod
{
    /// <summary>
    /// Напиток
    /// </summary>
    class DrinkProduct : IProduct
    {
        public int Time = 0;
        public int Cost = 0;

        public int GetCost()
        {
            return Cost;
        }

        public int GetTime()
        {
            return Time;
        }

        public void SubtractTime(int value)
        {
            Time -= value;
        }

        public void SetInfo(int cost, int time)
        {
            Time = time;
            Cost = cost;
        }

        public string GetName()
        {
            return "Вода";
        }
    }
}
