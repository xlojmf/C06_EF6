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

            //using db usar em cada metodo , dentro do methjod para garantir segurança

            //Versão simples
            using (var db = new BooksModel())
            {
                BookRepository.CreateBook();
                //BookRepository.CreateBook(db,1); por exemplo passar dados e fazer verificacoes, passar todo o trabalho para os repositorios
                PublisherRepository.CreatePublisher();
                BookRepository.ListBooks();
                PublisherRepository.ListPublisher();

            }

            Utility.TerminateConsole();
        }
    }
}
