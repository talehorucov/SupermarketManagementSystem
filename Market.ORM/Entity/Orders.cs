using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.ORM.Entity
{
    public class Orders
    {
        public int Id { get; set; }
        public int SupplierID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime Date { get; set; }
    }
}
