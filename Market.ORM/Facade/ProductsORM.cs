using Market.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market.ORM.Facade
{
    public class ProductsORM : ORMBase<Products>
    {
        private static int count = 0;
        public DataTable AddInCard(Products products, TextBox textBox)
        {
            count++;
            SqlDataAdapter adapter = new SqlDataAdapter("prc_Products_AddInCard", Tools.Connection);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("@BarcodeNo", products.BarcodeNo);
            adapter.SelectCommand.Parameters.AddWithValue("@Quantity", textBox.Text);
            for (int i= 0; i < count;i++)
            {
                Tools.Connection.InfoMessage -= Connection_InfoMessage;
            }
            Tools.Connection.InfoMessage += Connection_InfoMessage;
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

       
        private void Connection_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            MessageBox.Show(e.Message);
        }

        public DataTable Search(Products products)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("prc_Products_Search", Tools.Connection);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("@ProductName", products.ProductName);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool status;
        public void SameAdd(Products products)
        {
            SqlCommand command = new SqlCommand("prc_Products_Same_Add", Tools.Connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@BarcodeNo", products.BarcodeNo);
            if (command.Connection.State == ConnectionState.Closed)
                command.Connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
                status = false;
            else
                status = true;
            if (command.Connection.State == ConnectionState.Open)
                command.Connection.Close();
        }
        public void SameUpdate(Products products)
        {
            SqlCommand command = new SqlCommand("prc_Products_Same_Update", Tools.Connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Id", products.Id);
            command.Parameters.AddWithValue("@BarcodeNo", products.BarcodeNo);
            if (command.Connection.State == ConnectionState.Closed)
                command.Connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
                status = false;
            else
                status = true;
            if (command.Connection.State == ConnectionState.Open)
                command.Connection.Close();
        }
        #region Statistics
        public string ProductNumber()
        {
            SqlCommand command = new SqlCommand("prc_Statistics_ProductsNumber", Tools.Connection);
            return Tools.Statistics(command);
        }

        public string TotalStockNumber()
        {
            SqlCommand command = new SqlCommand("prc_Statistics_TotalStockNumber", Tools.Connection);
            return Tools.Statistics(command);
        }

        public string ExpensiveProduct()
        {
            SqlCommand command = new SqlCommand("prc_Statistics_ExpensiveProduct", Tools.Connection);
            return Tools.Statistics(command);
        }

        public string CheapProduct()
        {
            SqlCommand command = new SqlCommand("prc_Statistics_CheapProduct", Tools.Connection);
            return Tools.Statistics(command);
        }

        public string BestSeller()
        {
            SqlCommand command = new SqlCommand("prc_Statistics_BestSeller", Tools.Connection);
            return Tools.Statistics(command);
        }

        public string LowOnStock()
        {
            SqlCommand command = new SqlCommand("prc_Statistics_LowOnStock", Tools.Connection);
            return Tools.Statistics(command);
        }
        #endregion
    }
}
