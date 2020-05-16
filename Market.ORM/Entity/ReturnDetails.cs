using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.ORM.Entity
{
    public class ReturnDetails
    {
        public int ReturnID { get; set; }
        public int ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public double Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
