using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;

namespace UsersManagement.Models
{
    public class Users : DBAccess
    {
        private static string _table = "Users";

        public int CountAll()
        {

            int count;
            //Open connect
            _OpenConn();


            try
            {
                string query = "SELECT count(*) FROM " + _table + " ORDER BY ID DESC;";
                SqlCommand cmd = new SqlCommand(query, _connection);
                //dt.Load(Sqlcmd.ExecuteReader());
                count = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                count = -1;
            }

            _CloseConn();

            return count;
        }

        public DataTable Read(int Id = 0)
        {

            //open connect
            _OpenConn();

            //to result
            DataTable dt = new DataTable();

            string query = "SELECT * FROM " + _table + " ORDER BY Id ASC;";
            if (Id > 0)
            {
                query = "SELECT * FROM " + _table + " WHERE Id=" + Id + ";";
            }

            SqlCommand Sqlcmd = new SqlCommand(query, _connection);
            dt.Load(Sqlcmd.ExecuteReader());

            //close connect
            _CloseConn();


            return dt;
        }

        //insert 1 item
        public bool Create(DTOUsers User)
        {
            //to return result
            bool result = false;

            //open connect and begin transaction
            _OpenConn();
            SqlTransaction _trans = _connection.BeginTransaction();

            try
            {
                // Query string 
                string query = "INSERT INTO " + _table + "(Name, Email, Password, Country) VALUES ('{0}', '{1}', '{2}', '{3}')";
                string queryFormat = string.Format(query, User.Name, User.Email, User.Password, User.Country);
                SqlCommand cmd = new SqlCommand(queryFormat, _connection);

                // Query and check
                if (cmd.ExecuteNonQuery() > 0)
                {
                    result = true;
                    //commit transaction
                    _trans.Commit();
                }
                    


            } catch
            {
                _trans.Rollback();
            }

            _CloseConn();

            return result;
        }

        //update
        public bool Edit(DTOUsers User)
        {
            //to return result
            bool result = false;

            //open connect and begin transaction
            _OpenConn();
            SqlTransaction _trans = _connection.BeginTransaction();

            try
            {
                // Query string 
                string query = "UPDATE " + _table + " SET Name={1}, Email={2}, Password={3}, Country={4} WHERE Id={0}";
                string queryFormat = string.Format(query, User.Id, User.Name, User.Email, User.Password, User.Country);
                SqlCommand cmd = new SqlCommand(queryFormat, _connection);

                // Query and check
                if (cmd.ExecuteNonQuery() > 0)
                {
                    result = true;
                    //commit transaction
                    _trans.Commit();
                }



            }
            catch
            {
                _trans.Rollback();
            }

            _CloseConn();

            return result;
        }

        //update
        public bool Delete(int Id)
        {
            //to return result
            bool result = false;

            //open connect and begin transaction
            _OpenConn();
            SqlTransaction _trans = _connection.BeginTransaction();

            try
            {
                // Query string 
                string query = "DELETE FROM " + _table + " WHERE Id=" + Id;
                SqlCommand cmd = new SqlCommand(query, _connection);

                // Query and check
                if (cmd.ExecuteNonQuery() > 0)
                {
                    result = true;
                    //commit transaction
                    _trans.Commit();
                }

            }
            catch
            {
                _trans.Rollback();
            }

            _CloseConn();

            return result;
        }

    }
}