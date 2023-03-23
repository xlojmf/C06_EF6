using System;
using System.Data.Entity;
using System.Linq;

namespace E02_BOOK_DAL
{
    public class Book : DbContext
    {
        // Your context has been configured to use a 'Book' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'E02_BOOK_DAL.Book' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Book' 
        // connection string in the application configuration file.
        public Book()
            : base("name=Book")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}