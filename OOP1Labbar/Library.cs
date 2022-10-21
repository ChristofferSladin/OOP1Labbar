﻿using System;
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
        public int countOfBooks;

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
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void BorrowBook(List<Book> books)
        {
            
        }

        public List<Book> ShowBooks()
        {
            foreach (var book in books)
            {

                Console.WriteLine($"Title: {book.GetTitel()}\nAuthor: {book.GetAuthor()}");
                Console.WriteLine("-------------------------------------------------------");
            }

            return books;
        }

        public void ReturnBook()
        {

        }
    }







}
