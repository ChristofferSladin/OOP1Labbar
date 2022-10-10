using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1Labbar
{
    internal class Application
    {

        public void Lab3()
        {

        }



        public void Lab2()
        {

            bool run = true;
            while (run)
            {
                Person person1 = new Person("Christoffer", "1999-02-21");
                Person person2 = new Person("Linnea", "2001-12-10");
                // Person person3 = new Person("Filippa", "2007-08-01");

                if (person1.Adress.ToLower() == person2.Adress.ToLower() && person1.PostalCode == person2.PostalCode && person1.County.ToLower() == person2.County.ToLower())
                {
                    Console.WriteLine($"{person1.Name} and {person2.Name} have moved in together on {person1.adress} | {person1.PostalCode} | {person1.County}");
                    run = false;    
                }
                else
                {
                    Console.WriteLine($"{person1.Name} lives seperate from {person2.Name}");
                    Console.ReadKey();
                }
            }
        }


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
            //Lab1();
            Lab2();
        }
    }
}
