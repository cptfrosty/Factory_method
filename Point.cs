using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laba2.FactoryMetod;

namespace Laba2
{
    /// <summary>
    /// Точка продажи
    /// </summary>
    abstract class Point
    {
        KitchenUnification[] _kitchenUnifications;
        //Первая кухня
        public KitchenUnification OneKitchen;
        //Вторая кухня
        public KitchenUnification TwoKitchen;
        //Третья кухня
        public KitchenUnification ThreeKitchen;
        //Четвертая кухня
        public KitchenUnification FourKitchen;
        public Point()
        {
            OneKitchen = new KitchenUnification(
            new Kitchen[] { new HamburgerKitchen() }
            );

            TwoKitchen = new KitchenUnification(
           new Kitchen[] { new FrenchFriesKitchen() }
           );

            ThreeKitchen = new KitchenUnification(
           new Kitchen[] { new SaladsKitchen(), new DrinkKitchen() }
           );

            FourKitchen = new KitchenUnification(
           new Kitchen[] { new StripsKitchen(), new NuggetsKitchen() }
           );

            _kitchenUnifications = new KitchenUnification[]{
                OneKitchen, TwoKitchen, ThreeKitchen, FourKitchen
            };
        }

        /// <summary>
        /// Добавить продукт
        /// </summary>
        /// <param name="product">Продукт</param>
        public void AddProduct(IProduct product)
        {
            bool isAdded = false; //Был добавлен
            for(int i = 0; i < _kitchenUnifications.Length; i++)
            {
                for (int j = 0; j < _kitchenUnifications[i].Kitchens.Length; j++)
                {
                    Kitchen kitchen = _kitchenUnifications[i].Kitchens[j];
                    if (kitchen.CreateProduct().GetType() == product.GetType())
                    {
                        _kitchenUnifications[i].AddProduct(product);
                        isAdded = true;
                    }
                }

                //Если продукт был добавлен, то прервать цикл
                if (isAdded)
                    break;
            }
        }

        /// <summary>
        /// Обновление готовки
        /// </summary>
        public void UpdateCooking()
        {
            for(int i = 0; i < _kitchenUnifications.Length; i++)
            {
                _kitchenUnifications[i].UpdateCooking();
            }
        }

        public string GetAllProducts()
        {
            string listing = "";

            for(int i = 0; i < _kitchenUnifications.Length; i++)
            {
                List<IProduct> products = _kitchenUnifications[i].GetProducts();
                for (int j = 0; j < products.Count; j++)
                {
                    listing += products[j].GetName() + "\t" + 
                        products[j].GetTime() + " мин.\t" + 
                        products[j].GetCost() + " руб.\n";
                }
            }

            return listing;
        }
    }
}
