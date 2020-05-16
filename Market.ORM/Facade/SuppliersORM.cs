using Market.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.ORM.Facade
{
    public class SuppliersORM : ORMBase<Suppliers>
    {
        public DataTable Search(Suppliers suppliers)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("prc_Suppliers_Search", Tools.Connection);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("@Firstname", suppliers.Firstname);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

    }
}
