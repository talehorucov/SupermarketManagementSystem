using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.ORM.Entity
{
    public class Authority
    {
        public Authority()
        {
            Active = true;
        }
        public int Id { get; set; }
        public string Job { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
    }
}
