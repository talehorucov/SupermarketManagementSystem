using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market.ORM
{
    public class Tools
	{
		private static SqlConnection connection;

		public static SqlConnection Connection
		{
			get 
			{ 
				if(connection == null)
					connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString);
				return connection;
			}
		}

		public static void CreateParametrs<T>(SqlCommand command,EnumCommandType ect, T entity)
		{
			PropertyInfo[] properties = typeof(T).GetProperties();
			foreach (PropertyInfo item in properties)
			{
				string name = item.Name;
				if (name == "Id" && ect == EnumCommandType.Insert)
					continue;
				else if (name != "Id" && ect == EnumCommandType.Delete)
					continue;
				else if ((name == "EntryTime" || name== "Active" )&& ect == EnumCommandType.Update)
					continue;

				object value = item.GetValue(entity);
				command.Parameters.AddWithValue("@" + name, value);
			}
		}

		public static bool ExecuteNonQueryM(SqlCommand command)
		{
			try
			{
				if (command.Connection.State == ConnectionState.Closed)
					connection.Open();
				int effect = command.ExecuteNonQuery();
				return effect > 0 ? true : false;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return false;
			}
			finally
			{
				if (command.Connection.State == ConnectionState.Open)
					connection.Close();
			}
		}
		public static object ExecuteScalarM(SqlCommand command)
		{
			try
			{
				if (command.Connection.State == ConnectionState.Closed)
					command.Connection.Open();
				return command.ExecuteScalar();
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
				return 0;
			}
			finally
			{
				if (command.Connection.State == ConnectionState.Open)
					command.Connection.Close();
			}
		}

		public static string Statistics(SqlCommand command)
		{
			string result = "";
			command.CommandType = CommandType.StoredProcedure;

			if (command.Connection.State == ConnectionState.Closed)
				command.Connection.Open();

			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				result = reader[0].ToString();
			}

			if (command.Connection.State == ConnectionState.Open)
				command.Connection.Close();
			return result;
		}
	}
}
