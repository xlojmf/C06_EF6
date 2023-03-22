using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_CF_BooksDB
{
    public class Book
    {
        // Tabela N

        #region Scalar properties  --  Propriedades escalaveis
        public int BookID { get; set; }  // PK
        public int PublisherID { get; set; }  //FK
        public string Title { get; set; }
        public int ISBN { get; set; }
        public DateTime Date { get; set; }
        #endregion

        #region Navigation properties -- Propriedades de Navegação
        public virtual ICollection<Publisher> Publisher { get; set; }
        #endregion
    }
}
