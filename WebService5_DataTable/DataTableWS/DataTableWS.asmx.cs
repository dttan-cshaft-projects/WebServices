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
        private bool check = false;

        [WebMethod]
        public void DataStruct()
        {
            dtStudents.Columns.Add("ID");
            dtStudents.Columns.Add("FirstName");
            dtStudents.Columns.Add("LastName");
            dtStudents.Columns.Add("Age");
            dtStudents.Columns.Add("Class");
            dtStudents.Columns.Add("Course");
        }

        [WebMethod]
        public void DataDefault()
        {
            dtStudents.Rows.Add("1", "Tan", "Doan Thanh", "20", "D2201M1", "2021");
            dtStudents.Rows.Add("2", "Truong", "Hoang Le Quoc", "19", "D2201M1", "2021");
            dtStudents.Rows.Add("3", "Quoc", "Nguyen Van", "19", "D2202F2", "2022");
            dtStudents.Rows.Add("4", "Anh", "Vu Quoc", "18", "D2202E6", "2023");
            dtStudents.Rows.Add("5", "Binh", "Nguyen Thai", "18", "D2202E6", "2023");
            dtStudents.Rows.Add("6", "Thao", "Le Da", "18", "D2202U1", "2023");
        }

        [WebMethod]
        public string Students()
        {
            if (!check)
            {
                DataStruct();
                DataDefault();
            } else
            {

            }
            
            return JsonConvert.SerializeObject(dtStudents);

        }

        [WebMethod]
        public string AddNewRow(string dataString)
        {
            
            //tach tach tu dau :
            string[] dataArray = dataString.Split(':');

            //create 1 row
            DataRow row = dtStudents.NewRow();
            row["ID"] = dataArray[0];
            row["FirstName"] = dataArray[1];
            row["LastName"] = dataArray[2];
            row["Age"] = dataArray[3];
            row["Class"] = dataArray[4];
            row["Course"] = dataArray[5];

            //add to datatable
            dtStudents.Rows.Add(row);
            check = true;

            return JsonConvert.SerializeObject(dtStudents);

        }
    }
}
