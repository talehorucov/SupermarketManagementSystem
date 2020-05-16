using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.ORM.Entity
{
    public class Sales
    {
        public int Id { get; set; }
        public int CashRegisterID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime SaleDate { get; set; }
    }
}
