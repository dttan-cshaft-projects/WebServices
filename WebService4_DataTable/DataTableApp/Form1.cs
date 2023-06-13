
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace DataTableApp
{
    public partial class Form1 : Form
    {
        localhost.StudentsManagement ws = new localhost.StudentsManagement();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string studentsJson = ws.Students();
            DataTable dtStudents = JsonConvert.DeserializeObject<DataTable>(studentsJson);
            dgvStudents.DataSource = dtStudents;
        }


    }
}
