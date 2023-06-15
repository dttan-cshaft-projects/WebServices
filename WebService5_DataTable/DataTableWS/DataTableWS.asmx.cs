using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using Newtonsoft.Json;

namespace DataTableWS
{
    /// <summary>
    /// Summary description for DataTableWS
    /// </summary>
    [WebService(Name = "Students Management", Namespace = "https://localhost:44366", Description = "This is The Students Management Web Service")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class DataTableWS : System.Web.Services.WebService
    {
        
        DataTable dtStudents = new DataTable();

        [WebMethod]
        public string Students()
        {
            dtStudents.Columns.Add("ID");
            dtStudents.Columns.Add("FirstName");
            dtStudents.Columns.Add("LastName");
            dtStudents.Columns.Add("Age");
            dtStudents.Columns.Add("Class");
            dtStudents.Columns.Add("Course");

            dtStudents.Rows.Add("ST00001", "Tan", "Doan Thanh", "20", "D2201M1", "2021");
            dtStudents.Rows.Add("ST00002", "Truong", "Hoang Le Quoc", "19", "D2201M1", "2021");
            dtStudents.Rows.Add("ST00005", "Quoc", "Nguyen Van", "19", "D2202F2", "2022");
            dtStudents.Rows.Add("ST00006", "Anh", "Vu Quoc", "18", "D2202E6", "2023");
            dtStudents.Rows.Add("ST00007", "Binh", "Nguyen Thai", "18", "D2202E6", "2023");
            dtStudents.Rows.Add("ST00008", "Thao", "Le Da", "18", "D2202U1", "2023");
            

            return JsonConvert.SerializeObject(dtStudents);

        }
    }
}
