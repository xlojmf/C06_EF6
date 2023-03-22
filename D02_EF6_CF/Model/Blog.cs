using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02_EF6_CF.Model
{
    public class Blog
    {
        // Tabela 1

        #region Scalar properties  --  Propriedades escalaveis
        public int BlogId {get; set;} // sabe q é pk + identity
        public string Name { get; set;}
        #endregion


        #region Navigation properties -- Propriedades de Navegação
        //public virtual List<Post> Posts { get; set; }
        public virtual ICollection<Post> Posts { get; set;}
        #endregion




    }
}
