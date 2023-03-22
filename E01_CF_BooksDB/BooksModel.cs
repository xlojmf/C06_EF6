using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace E01_CF_BooksDB
{
    public class BooksModel : DbContext
    {
        // Your context has been configured to use a 'BooksModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'E01_CF_BooksDB.BooksModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'BooksModel' 
        // connection string in the application configuration file.
        #region Construtor (Connectionstring do app.config)
        public BooksModel()
            : base("name=BooksEntities")
        {
        }
        #endregion

        #region Comportamento da criação da base dados
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // desativar a plurizacao das tabelas
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        #endregion

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        #region Criação das tabelas
        public DbSet<Book> Book { get; set; }
        public DbSet<Publisher> Publisher { get; set; }

        #endregion

    }


}