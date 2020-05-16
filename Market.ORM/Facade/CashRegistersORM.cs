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
    public class CashRegistersORM : ORMBase<CashRegisters>
    {
        public bool status;
        public void SameAdd(CashRegisters cashRegisters)
        {
            SqlCommand command = new SqlCommand("prc_CashRegisters_Same_Add", Tools.Connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Name", cashRegisters.Name);
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
        public void SameUpdate(CashRegisters cashRegisters)
        {
            SqlCommand command = new SqlCommand("prc_CashRegisters_Same_Add_Update", Tools.Connection);
            command.CommandType = CommandType.StoredProcedure; 
            command.Parameters.AddWithValue("@Id", cashRegisters.Id);
            command.Parameters.AddWithValue("@Name", cashRegisters.Name);
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
