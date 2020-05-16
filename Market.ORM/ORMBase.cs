using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market.ORM
{
    public class ORMBase<T> : IORM<T> where T : class
    {
        private string ClassName
        {
            get
            {
                return typeof(T).Name;
            }
        }
        public DataTable Select()
        {
            SqlDataAdapter adapter = new SqlDataAdapter(string.Format("prc_{0}_Select", ClassName), Tools.Connection);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool Insert(T entity)
        {
            SqlCommand command = new SqlCommand(string.Format("prc_{0}_Insert", ClassName), Tools.Connection);
            command.CommandType = CommandType.StoredProcedure;
            Tools.CreateParametrs<T>(command, EnumCommandType.Insert, entity);
            return Tools.ExecuteNonQueryM(command);
        }
        public object InsertScalar(T entity)
        {
            SqlCommand command = new SqlCommand(string.Format("prc_{0}_Insert", ClassName), Tools.Connection);
            command.CommandType = CommandType.StoredProcedure;
            Tools.CreateParametrs<T>(command, EnumCommandType.Insert, entity);

            return Tools.ExecuteScalarM(command);
        }

        public bool Update(T entity)
        {
            SqlCommand command = new SqlCommand(string.Format("prc_{0}_Update", ClassName), Tools.Connection);
            command.CommandType = CommandType.StoredProcedure;
            Tools.CreateParametrs<T>(command, EnumCommandType.Update, entity);
            return Tools.ExecuteNonQueryM(command);
        }

        public bool Delete(T entity)
        {
            SqlCommand command = new SqlCommand(string.Format("prc_{0}_Delete", ClassName), Tools.Connection);
            command.CommandType = CommandType.StoredProcedure;
            Tools.CreateParametrs<T>(command, EnumCommandType.Delete, entity);
            return Tools.ExecuteNonQueryM(command);
        }
    }
}
