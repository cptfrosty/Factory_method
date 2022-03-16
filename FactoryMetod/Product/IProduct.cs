using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2.FactoryMetod
{
    public interface IProduct
    {
        void SetInfo(int cost, int time);
        void SubtractTime(int value);

        int GetTime();

        int GetCost();

        string GetName();
    }
}
