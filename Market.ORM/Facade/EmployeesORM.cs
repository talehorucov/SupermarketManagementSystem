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
    public class EmployeesORM : ORMBase<Employees>
    {
        public static Employees onlineUser;
        public Employees Login(Employees employees)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("prc_Employees_Login", Tools.Connection);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("@Username", employees.Username);
            adapter.SelectCommand.Parameters.AddWithValue("@Pass", employees.Pass);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count == 0)
                return null;

            Employees online = new Employees();
            foreach (DataRow item in table.Rows)
            {
                online.Id = (int)item["Id"];
                online.Firstname = item["Firstname"].ToString();
                online.Lastname = item["Lastname"].ToString();
                online.Username = item["Username"].ToString();
                online.AuthorityID = (int)item["AuthorityID"];
                online.Pass = item["Pass"].ToString();
                online.PhoneNo = item["PhoneNo"].ToString();
            }
            return online;
        }

        public DataTable Search(Employees employees)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("prc_Employees_Search", Tools.Connection);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("@Firstname", employees.Firstname);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool status;
        public void SameAdd(Employees employees)
        {
            try
            {
                SqlCommand command = new SqlCommand("prc_Employees_Same_Add", Tools.Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Username", employees.Username);
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
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void SameUpdate(Employees employees)
        {
            try
            {
                SqlCommand command = new SqlCommand("prc_Employees_Same_Update", Tools.Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id", employees.Id);
                command.Parameters.AddWithValue("@Username", employees.Username);
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
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public string EmployeesNumber()
        {
            SqlCommand command = new SqlCommand("prc_Statistics_EmployeesNumber", Tools.Connection);
            return Tools.Statistics(command);
        }
    }
}
