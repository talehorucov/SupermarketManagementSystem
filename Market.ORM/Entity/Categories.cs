using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.ORM.Entity
{
    public class Categories
    {
        public Categories()
        {
            Active = true;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
    }
}
