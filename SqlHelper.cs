using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiTaksit.DAL
{
    public class SqlHelper
    {
        private static string _connectionString = ConfigurationManager.ConnectionStrings["MenaxhimiTaksit"].ConnectionString;


        public static SqlConnection GetConnection()
        {
           
            
                SqlConnection connection = new SqlConnection(_connectionString);
                connection.Open();
                return connection;

            
        }

        public static SqlCommand Command(SqlConnection connection, string cmdText, CommandType commandType = CommandType.StoredProcedure)
        {
            SqlCommand command = new SqlCommand(cmdText, connection);
            command.CommandType = CommandType.StoredProcedure;
            return command;
        }


    }
}
