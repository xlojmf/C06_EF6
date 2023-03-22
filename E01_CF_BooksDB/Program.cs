using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_CF_BooksDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            //Versão simples
            using (var db = new BooksModel())
            {
                BookRepository.CreateBook(db);
                PublisherRepository.CreatePublisher(db);
                BookRepository.ListBooks(db);
                PublisherRepository.ListPublisher(db);

            }

            Utility.TerminateConsole();
        }
    }
}
