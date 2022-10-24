using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1Labbar
{
    class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(string title, int count)
        {
            var book = FindBook(title);
            if (book == null)
            {
                books.Add(book);
            }
            book.AddCountOfEx(count);
        }

        public Book FindBook(string title)
        {
            foreach (var book in books)
            {
                if (book.Title == title)
                    return book;
            }
            return null;
        }

        
    }







}
