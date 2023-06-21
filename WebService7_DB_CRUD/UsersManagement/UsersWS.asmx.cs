using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using UsersManagement.Models;
using System.Data;
using Newtonsoft.Json;

namespace UsersManagement
{
    /// <summary>
    /// Summary description for UsersWS
    /// </summary>
    [WebService(Name = "Users Management", Namespace = "http://tempuri.org/", Description = "Users Management Web Service")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class UsersWS : System.Web.Services.WebService
    {

        [WebMethod]
        public string Read()
        {
            Users U = new Users();
            DataTable dt = new DataTable();
            dt = U.Read();

            return JsonConvert.SerializeObject(dt);
        }

        [WebMethod]
        public string ReadItem(int Id)
        {
            Users U = new Users();
            DataTable dt = new DataTable();
            dt = U.Read(Id);

            return JsonConvert.SerializeObject(dt);
        }

        [WebMethod]
        public string Create(string Name, string Email, string Password, string Country )
        {
            DTOUsers User = new DTOUsers(Name, Email, Password, Country);

            return JsonConvert.SerializeObject(User);
        }
    }
}
