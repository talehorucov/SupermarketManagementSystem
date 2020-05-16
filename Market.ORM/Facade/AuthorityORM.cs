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
    public class AuthorityORM : ORMBase<Authority>
    {
        public DataTable Search(Authority authority)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("prc_Authority_Search", Tools.Connection);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("@Job", authority.Job);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool status;
        public void SameAdd(Authority authority)
        {
            SqlCommand command = new SqlCommand("prc_Authority_Same_Add", Tools.Connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Job", authority.Job);
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
        public void SameUpdate(Authority authority)
        {
            SqlCommand command = new SqlCommand("prc_Authority_Same_Update", Tools.Connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Id", authority.Id);
            command.Parameters.AddWithValue("@Job", authority.Job);
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
    }
}
