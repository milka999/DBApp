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
    public partial class FrmEmployees : Form
    {
        public SqlConnection conn;
        public int selectedEmployeeID = -1;
        public DataTable employeeDT; 
        public FrmEmployees()
        {
            InitializeComponent();
            
            this.ConnectToDB();
            this.GetData();

            this.exitMenuItem.Click += ExitMenuItem_Click;
            this.menuItemAddEmployee.Click += MenuItemAddEmployee_Click;
            this.btnEditEmployee.Click += BtnEditEmployee_Click;
            this.dgvEmployees.CellClick += DgvEmployees_CellClick;
            this.btnDeleteEmployee.Click += BtnDeleteEmployee_Click;
            this.btnSearch.Click += BtnSearch_Click;
            this.btnAddToProject.Click += BtnAddToProject_Click;
        }

        private void BtnAddToProject_Click(object sender, EventArgs e)
        {
            FrmAddToProject frm = new FrmAddToProject(conn);
            frm.ShowDialog();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string searchText = this.rtxtSearchText.Text;
            decimal salaryFrom = -1;
            decimal salaryTo = -1; 
            try
            {
                salaryFrom = Convert.ToDecimal(this.rtxtSalaryFrom.Text);
            }
            catch
            {
                salaryFrom = -1;
            }

            try
            {
                salaryTo = Convert.ToDecimal(this.rtxtSalaryTo.Text);
            }
            catch
            {
                salaryTo = -1;
            }

            this.employeeDT = EmployeeRepository.SearchEmployees(searchText, 
                                                            salaryFrom, salaryTo, 
                                                            conn);
            this.dgvEmployees.DataSource = this.employeeDT;
        }

        private void BtnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (this.selectedEmployeeID == -1)
            {
                MessageBox.Show("Odaberi zaposlenog!"); 
            }
            else
            {
                //DialogResult dialogResult = 
                //    MessageBox.Show("Jeste li sigurni?", "Brisanje", MessageBoxButtons.YesNo); 

                CustomDialog customDialog = new CustomDialog("Brisanje",
                    "Jeste li sigurni da brisete zaposlenog?"); 
                DialogResult dialogResult = customDialog.ShowDialog();

                if (dialogResult == DialogResult.Yes)
                {
                    bool result = EmployeeRepository.DeleteEmployee(this.selectedEmployeeID,
                                                                this.conn);
                    if (result)
                    {
                        MessageBox.Show("Izbrisan zaposlen!");
                        this.GetData();
                    }
                    else
                    {
                        MessageBox.Show("Greska pri brisanju!");
                    }
                }  
            }
        }

        private void DgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(e.RowIndex.ToString());
            //MessageBox.Show(e.ColumnIndex.ToString());

            // Na osnovu RowIndex-a, uzimamo podatak iz DataTable
            int rowIndex = e.RowIndex;
            if (rowIndex < this.employeeDT.Rows.Count)
            {
                DataRow selectedRow = this.employeeDT.Rows[rowIndex];
                this.selectedEmployeeID = (int)selectedRow.ItemArray[0];
                //MessageBox.Show(this.selectedEmployeeID.ToString());
            }
        }

        private void BtnEditEmployee_Click(object sender, EventArgs e)
        {
            if (this.selectedEmployeeID == -1)
            {
                MessageBox.Show("Odaberi zaposlenog!"); 
            }
            else
            {
                FrmAddEditEmployee editEmployeeFrm = new FrmAddEditEmployee(this); 
                editEmployeeFrm.ShowDialog();
            }
        }

        private void MenuItemAddEmployee_Click(object sender, EventArgs e)
        {
            this.selectedEmployeeID = -1; 
            FrmAddEditEmployee newForm = new FrmAddEditEmployee(this); 
            newForm.ShowDialog();
        }

        private void ConnectToDB()
        {
            string connectionString = "Server=localhost;Database=ProjectsDB;Trusted_Connection=True;";
            this.conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska pri konekciji!");
            }
        }

        public void GetData()
        {
            try
            {
                this.employeeDT = EmployeeRepository.GetAllEmployees(conn);
                this.dgvEmployees.DataSource = this.employeeDT;  
                //while(reader.Read())
                //{
                //    // reader - trenutni red podataka koji se ucitao 
                //    int employeeID = reader.GetInt32(0); 
                //    string employeeName = reader.GetString(1);
                //    string employeeSurname = reader.GetString(2); 
                //    decimal employeeSalary = reader.GetDecimal(3);
                //    DateTime employeeBirthday = reader.GetDateTime(4);  
                //}
            }
            catch(Exception ex)
            {
                MessageBox.Show("Greska pri konekciji!"); 
            }
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
