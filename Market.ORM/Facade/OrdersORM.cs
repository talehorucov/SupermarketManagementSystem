using Market.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market.ORM.Facade
{
    public class OrdersORM : ORMBase<Orders>
    {
        public DataTable AddInCard(Products products, TextBox textBox)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("prc_Products_Order", Tools.Connection);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("@Id", products.Id);
            adapter.SelectCommand.Parameters.AddWithValue("@Quantity", textBox.Text);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
