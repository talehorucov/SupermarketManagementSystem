using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.ORM.Entity
{
    public class Suppliers
    {
        public Suppliers()
        {
            Active = true;
        }
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string CompanyName { get; set; }
        public string PhoneNo { get; set; }
        public string Adress { get; set; }
        public string Mail { get; set; }
        public bool Active { get; set; }
    }
}
