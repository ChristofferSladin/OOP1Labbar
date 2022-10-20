using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1Labbar
{
    internal class Menu
    {
        public void ShowMenu()
        {
            

            var library = new Library();
            var listOfBooks = new List<Book>();
            
            while (true)
            {
                Console.WriteLine("a. Skapa ny bok\nb. Låna bok\nc. Lämna tillbaka bok\nq. Quit");
                Console.Write("Ange val: ");

                var input = Console.ReadLine();
                if (input == "a")
                {
                    library.AddBookToLibrary();
                    continue;
                }

                if (input == "b")
                {
                    library.BorrowBook();
                    continue;
                }

                if (input == "c")
                {
                    library.ReturnBook();
                    continue;
                }

                if (input == "q") break;
            }



            //"invalid input, please press a, b or c";

        }
    }
}
