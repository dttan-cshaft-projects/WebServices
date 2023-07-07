
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
    public partial class FrmStudents : Form
    {
        localhost.StudentsManagement ws = new localhost.StudentsManagement();
        

        public FrmStudents()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string studentsJson = ws.Students();
            DataTable dtStudents = JsonConvert.DeserializeObject<DataTable>(studentsJson);
            DgvStudents.DataSource = dtStudents;

            LoadDataToForm();
        }

        private void LoadDataToForm( )
        {
            //int rowIndex = DgvStudents.CurrentCell.RowIndex;

            TxtId.Text = DgvStudents.CurrentRow.Cells[0].Value.ToString();
            TxtFirstName.Text = DgvStudents.CurrentRow.Cells[1].Value.ToString();
            TxtLastName.Text = DgvStudents.CurrentRow.Cells[2].Value.ToString();
            TxtAge.Text = DgvStudents.CurrentRow.Cells[3].Value.ToString();
            TxtClass.Text = DgvStudents.CurrentRow.Cells[4].Value.ToString();
            TxtCourse.Text = DgvStudents.CurrentRow.Cells[5].Value.ToString();
        }

        private void DgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDataToForm();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtId.Text = "";
            TxtFirstName.Text = "";
            TxtLastName.Text = "";
            TxtAge.Text = "";
            TxtClass.Text = "";
            TxtCourse.Text = "";
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            //string studentsJson = ws.Students();
            //DataTable dtStudents = JsonConvert.DeserializeObject<DataTable>(studentsJson);

            string Id = TxtId.Text.ToString();
            string FirstName = TxtFirstName.Text.ToString();
            string LastName = TxtLastName.Text.ToString();
            string Age = TxtAge.Text.ToString();
            string Class = TxtClass.Text.ToString();
            string Course = TxtCourse.Text.ToString();
            string dataString = Id + ":" + FirstName + ":" + LastName + ":" + Age + ":" + Class + ":" + Course;

            string studentsJson = ws.AddNewRow(dataString);
            DataTable dtStudents = JsonConvert.DeserializeObject<DataTable>(studentsJson);
            DgvStudents.DataSource = dtStudents;
        }
    }
}
