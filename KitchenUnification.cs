using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laba2.FactoryMetod;

namespace Laba2
{
    //Объединение кухней
    class KitchenUnification
    {
        private List<IProduct> Products = new List<IProduct>();
        /// <summary>
        /// Кол-во сотруднико на кухне
        /// </summary>
        public int CountEmployees = 0;
        /// <summary>
        /// Кухни
        /// </summary>
        public Kitchen[] Kitchens { get; private set; }
        public KitchenUnification(Kitchen[] kitchens)
        {
            Kitchens = kitchens;
        }

        /// <summary>
        /// Добавить продукт
        /// </summary>
        /// <param name="product"></param>
        public void AddProduct(IProduct product)
        {
            Products.Add(product);
        }

        public List<IProduct> GetProducts()
        {
            return Products;
        }

        /// <summary>
        /// Обновить информацию о готовке
        /// </summary>
        public void UpdateCooking()
        {
            if (Products.Count == 0) return;

            for(int i = 0; i < CountEmployees; i++)
            {
                //Если сотрудников больше, чем продуктов, то прервать выполнение
                if (i > Products.Count-1) break;

                //Отнять 1 минуту готовки
                Products[i].SubtractTime(1);

                //Если время готовки закончилось
                if (Products[i].GetTime() <= 0)
                {
                    Income.Value += Products[i].GetCost();
                    Products.RemoveAt(i);
                    i--;
                }
            }
        }

        /// <summary>
        /// Загруженность кухни
        /// </summary>
        /// <param name="maxTime"></param>
        /// <returns>Загруженность кухни в процентах</returns>
        public float GetWorkload(int maxTime)
        {
            if (Products.Count == 0) return 0.0f;

            float result = 0;

            //Суммарное время готовки
            int sumTime = 0;
            for(int i = 0; i < Products.Count; i++)
            {
                sumTime += Products[i].GetTime();
            }

            if (CountEmployees > 0)
            {
                //Среднее время готовки
                float averageCookingTime = sumTime / CountEmployees;
                result = (100 / maxTime) * averageCookingTime;
            }
            else
            {
                //Нагрузка 100%
                result = 100.0f;
            }

            return result;
        }
    }
}
