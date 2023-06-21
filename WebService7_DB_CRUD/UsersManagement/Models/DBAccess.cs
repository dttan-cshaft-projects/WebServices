using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;

namespace UsersManagement.Models
{
    public class DBAccess
    {
        protected static SqlConnection _connection = new SqlConnection();
        private static string strConnString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SocialNetWork;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public void _OpenConn()
        {
            try
            {
                if (_connection.State != ConnectionState.Open)
                {
                    _connection.ConnectionString = strConnString;
                    _connection.Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void _CloseConn()
        {
            _connection.Close();
            _connection.Dispose();
        }

    }
}