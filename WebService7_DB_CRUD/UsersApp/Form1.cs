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


namespace UsersApp
{
    public partial class FrmUsers : Form
    {
        localhost.UsersManagement ws = new localhost.UsersManagement();
        public FrmUsers()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Load all Users data to data grid view 
            string usersJson = ws.Read();
            DataTable dtUsers = JsonConvert.DeserializeObject<DataTable>(usersJson);
            userDataGridView.DataSource = dtUsers;

        }

        private void userDataGridView_MouseEnter(object sender, EventArgs e)
        {
            DataTable row = userDataGridView.DataSource;
            MessageBox.Show(JsonConvert.DeserializeObject(row));
        }
    }
}
