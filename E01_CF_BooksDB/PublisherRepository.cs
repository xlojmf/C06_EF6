using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_CF_BooksDB
{
    public static class PublisherRepository
    {
        public static void CreatePublisher()
        {
            var publishers = new List<Publisher>
              {
            new Publisher { Name = "Ze Manel"},
            new Publisher { Name = "Ze Maria"},

              };
            using (BooksModel db = new BooksModel())
            {
                db.Publisher.AddRange(publishers);
            db.SaveChanges();
            }
        }

        public static void ListPublisher()
        {
            using (BooksModel db = new BooksModel())
            {
                var queryPublisher = db.Publisher.Select(b => b).OrderBy(b => b.Name);
            // linq foreach
            queryPublisher.ToList().ForEach(item => Console.WriteLine($"{item.PublisherID} - {item.Name}"));
        }
    }

        public static void UpdatePublisher(Publisher publisher, BooksModel db)
        {
        }
        public static void DeletePublisher(Publisher publisher, BooksModel db)
        {
        }
    }
}
