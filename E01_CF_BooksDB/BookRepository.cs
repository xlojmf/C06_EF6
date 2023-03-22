using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_CF_BooksDB
{
    public static class BookRepository
    {

        public static void CreateBook(BooksModel db) 
        {
            var books = new List<Book>
              {
            new Book { PublisherID = 1, Title = "Title 1", ISBN = 123456789, Date = DateTime.Now },
            new Book { PublisherID = 2, Title = "Title 2", ISBN = 987654321, Date = DateTime.Now },
            new Book { PublisherID = 1, Title = "Title 3", ISBN = 123456789, Date = DateTime.Now },
              };
            db.Book.AddRange(books);
            db.SaveChanges();
        }

        public static void ListBooks(BooksModel db) 
        {
            var queryBook= db.Book.Select(b => b).OrderBy(b => b.Title);
            // linq foreach
            queryBook.ToList().ForEach(item => Console.WriteLine($"{item.BookID} - {item.PublisherID} - {item.Title} - {item.ISBN} - {item.Date}"));
        }

        public static void UpdateBook(Book book, BooksModel db) 
        {
        }
        public static void DeleteBook(Book book, BooksModel db) 
        {
        }    
        
    }
}
