using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;

namespace UsersManagement.Models
{
    public class DTOUsers
    {
        // Fiels
        private int id;
        private string name;
        private string email;
        private string password;
        private string country;

        //Properties - Validations
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Country { get => country; set => country = value; }

        public DTOUsers()
        {
        }

        public DTOUsers(string name, string email, string password, string country)
        {
            this.name = name;
            this.email = email;
            this.password = password;
            this.country = country;
        }
    }
}