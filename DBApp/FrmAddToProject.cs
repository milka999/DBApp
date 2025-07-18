using DBApp.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBApp
{
    public partial class FrmAddToProject : Form
    {
        public SqlConnection conn; 
        public FrmAddToProject(SqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
            this.InitData();
            this.btnSave.Click += BtnSave_Click;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // selected value iz dropdown-a
            int projectID = 
                Convert.ToInt32(this.cbProjects.SelectedValue.ToString());
        }

        public void InitData()
        {
            DataTable projectsDT = ProjectRepository.GetAllProjects(this.conn); 
            this.cbProjects.DataSource = projectsDT;
            this.cbProjects.DisplayMember = "Name";
            this.cbProjects.ValueMember = "ProjectID"; 
        }
    }
}
