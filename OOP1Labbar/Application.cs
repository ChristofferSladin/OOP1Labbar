using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1Labbar
{
    internal class Application
    {
        public void Run()
        {
            var lunchList = new List<Dish>();

            var dish1 = new Dish("Pannkakor med sylt",50,10,DishType.Vegetarian);
            var dish2 = new Dish("Köttbullar", 70, 30, DishType.Vegetarian);
            var dish3 = new Dish("Burgare", 90, 25, DishType.Vegetarian);

            lunchList.Add(dish1);
            lunchList.Add(dish2);
            lunchList.Add(dish3);

            Console.WriteLine("VEGETARISKT");
            foreach (var dish in lunchList)
            {
                if (dish.DishType == DishType.Vegetarian)
                {
                    Console.WriteLine($"{dish.Name} {dish.Calories} {dish.DishType}");
                }
            }
        }
    }
}
