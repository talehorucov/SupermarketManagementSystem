using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.ORM.Entity
{
    public class ReturnedProducts
    {
        public ReturnedProducts()
        {
            ReturnDate = DateTime.Now;
        }
        public int Id { get; set; }
        public int EmployeeID { get; set; }
        public int SupplierID { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
