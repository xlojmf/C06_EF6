using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace D02_EF6_CF.Model
{
    public class BlogContext : DbContext
    {

        #region Construtor (Connectionstring do app.config)
        public BlogContext()
         : base("name=BlogEntities")
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

        #region Criação das tabelas
        public DbSet<Blog> Blog { get; set; }
        public DbSet<Post> Post { get; set; }

        #endregion

    }
}
