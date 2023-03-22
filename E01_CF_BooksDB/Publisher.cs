using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_CF_BooksDB
{
    public class Publisher
    {
        // Tabela 1

        #region Scalar properties  --  Propriedades escalaveis
        public int PublisherID { get; set; } 
        public string Name { get; set; }
        #endregion


        #region Navigation properties -- Propriedades de Navegação
        public virtual ICollection<Book> Book { get; set; }
        #endregion
    }
}
