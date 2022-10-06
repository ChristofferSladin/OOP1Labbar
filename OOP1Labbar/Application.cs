using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1Labbar
{
    internal class Application
    {
        public void GetMenuOfDishes(List<Dish> listOfDishes, string rubrik, DishType dishType)
        {
            foreach (Dish dish in listOfDishes)
            {
                if (dish.DishType == dishType)
                Console.WriteLine($"\nDish: {dish.Name}\nType of food: {dish.DishType}\nPrice: {dish.Price}\nCalories: {dish.Calories}");
            }
        }
        public void Lab1()
        {
            var lunchList = new List<Dish>();

            var dish1 = new Dish("Pannkakor med sylt", 50, 10, DishType.Vegetarian);
            var dish2 = new Dish("Falafel", 70, 30, DishType.Vegan);
            var dish3 = new Dish("Burgare", 90, 25, DishType.Meat);

            lunchList.Add(dish1);
            lunchList.Add(dish2);
            lunchList.Add(dish3);

            GetMenuOfDishes(lunchList, "Vegetariskt", DishType.Vegetarian);
            GetMenuOfDishes(lunchList, "Kött", DishType.Meat);
            GetMenuOfDishes(lunchList, "Veganskt", DishType.Vegan);
        }
        public void Run()
        {
            Lab1();
        }
    }
}
