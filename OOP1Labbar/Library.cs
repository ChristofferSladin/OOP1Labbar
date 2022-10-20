using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1Labbar
{
    class Book
    {
        private string titel;
        private string author;

        public Book(string titel, string author)
        {
            this.titel = titel;
            this.author = author;
        }
        public string GetTitel()
        {
            return titel;
        }
        public string GetAuthor()
        {
            return author;
        }
    }


    class Library
    {

        public int countOfBooks;


        public List<Book> books;

        public void AddBookToLibrary()
        {
            var library = new Library();
            var books = library.ReadBooksFromList();

            Console.WriteLine("Add book to library");

            Console.WriteLine("Titel");
            var bookTitel = Console.ReadLine();
            Console.WriteLine("Author");
            var bookAuthor = Console.ReadLine();

            var book = new Book(bookTitel, bookAuthor);
           
            books.Add(book);
            library.countOfBooks = books.Count;

            
        }

        public List<Book> ReadBooksFromList()
        {
            return books;
        }

        public void BorrowBook()
        {
            var library = new Library();
            var listFromLibrary = library.ReadBooksFromList();

            Console.WriteLine("Wich book do you want to borrow?");
            Console.ReadLine();

            //listFromLibrary.Remove(str);

            Console.WriteLine("Wich book do you want to borrow?");

            Console.WriteLine(books);

        }

        public void ReturnBook()
        {

        }
    }

    

    



}
