using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1Labbar
{
    public enum DishType
    {
        Vegetarian,
        Vegan,
        Meat
    }

    public class Dish
    {
        private string name;
        private int price;
        private DishType dishType;
        private int calories;

        public Dish(string name, int price, int calories, DishType dishType)
        {
            this.name = name;
            this.price = price;
            this.calories = calories;
            this.dishType = dishType;

        }

        public string Name { get { return name; } }

        public DishType DishType { get { return dishType; } }

        public int Price { get { return price; } }

        public int Calories { get { return calories} }
    }
}
