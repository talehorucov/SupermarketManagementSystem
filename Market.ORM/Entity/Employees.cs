using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.ORM.Entity
{
    public class Employees
    {
        public Employees()
        {
            Active = true;
            EntryTime = DateTime.Now;
        }
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string IdentityNo { get; set; }
        public string PhoneNo { get; set; }
        public string Adress { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Salary { get; set; }
        public DateTime EntryTime { get; set; }
        public int AuthorityID { get; set; }
        public string Username { get; set; }
        public string Pass { get; set; }
        public bool Active { get; set; }
    }
}
