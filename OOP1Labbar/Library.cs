using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1Labbar
{
    class Library
    {
        public List<Library> books = new List<Library>();

        private string bookName;


        // HUR SKA JAG SPARA LISTAN TILL KLASSEN, GÅR DET ENS?
        public List<Library> AddBookToLibrary(List <Library> books)
        {
            var books = new List<Library>();

            Console.Write("Bok namn: ");
            var bookName = Console.ReadLine();

            books.Add(bookName);

            return books;
        }

        public void BorrowBook(List<Library> books)
        {
            foreach (var book in books)
            {
                Console.Write(book.bookName);
            }

            Console.WriteLine("Wich book do you want to borrow?");


        }
    }

    

    



}
