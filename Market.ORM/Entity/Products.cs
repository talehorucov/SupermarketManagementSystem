using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.ORM.Entity
{
    public class Products
    {
        public Products()
        {
            Active = true;
        }
        public int Id { get; set; }
        public string BarcodeNo { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public double Stock { get; set; }
        public int CategoryID { get; set; }
        public int UnitTypeID { get; set; }
        public bool Active { get; set; }
    }
}
