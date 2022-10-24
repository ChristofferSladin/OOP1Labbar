using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP1Labbar
{
    internal class Application
    {
        public void Lab4()
        {
            var library = new Library();


            //PRE EXISTING BOOKS IN LIBRARY

            //var book1 = new Book("Harry Potter 1", "JK Rowling");
            //var book2 = new Book("Lord Of The Rings 1", "Nameless");
            //var book3 = new Book("The Alchemist", "Paulo Cohelo");

           
            

            while (true)
            {
                Console.WriteLine("a. Add book to library\nb. Borrow book\nc. Return book\nq. Quit");
                Console.Write("Ange val: ");

                var input = Console.ReadLine();
                if (input == "a")
                {
                    Console.Write("Book Title: "); var title = Console.ReadLine();
                    Console.Write("Amount: "); var count = int.Parse(Console.ReadLine());
                    library.AddBook(title, count);

                    continue;
                }

                if (input == "b")
                {
                    
                    continue;
                }

                if (input == "c")
                {
                    
                    continue;
                }

                if (input == "q")
                {
                    Console.Clear();
                    Console.WriteLine("\n\n\nThank You Come Again\n\n\n");
                    Console.ReadKey();
                    break;
                }
                
            }


        }
        public void Lab3()
        {
            var datetime = DateTime.Parse("1999-02-21");

            Console.Write("Name:");
            string name = Console.ReadLine();

            var person = new Person(datetime, name);

            person.adress = person.ChangeAdress();

            person.postalCode = person.ChangePostalCode();

            person.county = person.ChangeCounty();

            Console.WriteLine(person.AgeInYears);

            Console.WriteLine(person.Name);

            Console.WriteLine(person.Adress);

            Console.WriteLine(person.PostalCode);

            Console.WriteLine(person.County);
        }

        public void Lab2()
        {

            bool run = true;
            while (run)
            {
                //Person person1 = new Person("Christoffer", "1999-02-21");
                //Person person2 = new Person("Linnea", "2001-12-10");
                //// Person person3 = new Person("Filippa", "2007-08-01");

                //if (person1.Adress.ToLower() == person2.Adress.ToLower() && person1.PostalCode == person2.PostalCode && person1.County.ToLower() == person2.County.ToLower())
                //{
                //    Console.WriteLine($"{person1.Name} and {person2.Name} have moved in together on {person1.adress} | {person1.PostalCode} | {person1.County}");
                //    run = false;
                //}
                //else
                //{
                //    Console.WriteLine($"{person1.Name} lives seperate from {person2.Name}");
                //    Console.ReadKey();
                //}
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
            //Lab2();
            //Lab3();
            Lab4();
        }
    }
}


