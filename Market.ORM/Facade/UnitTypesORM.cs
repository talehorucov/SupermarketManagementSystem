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
    public class UnitTypesORM : ORMBase<UnitTypes>
    {
        public bool status;
        public void SameAdd(UnitTypes unitTypes)
        {
            SqlCommand command = new SqlCommand("prc_UnitTypes_Same_Add", Tools.Connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Name", unitTypes.Name);
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
        public void SameUpdate(UnitTypes unitTypes)
        {
            SqlCommand command = new SqlCommand("prc_UnitTypes_Same_Update", Tools.Connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Id", unitTypes.Id);
            command.Parameters.AddWithValue("@Name", unitTypes.Name);
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
