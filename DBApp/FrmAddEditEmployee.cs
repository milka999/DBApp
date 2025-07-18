using DBApp.Models;
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
    public partial class FrmAddEditEmployee : Form
    {
        SqlConnection conn;
        FrmEmployees parentForm; 
        public FrmAddEditEmployee(FrmEmployees parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.conn = parentForm.conn; 
            this.btnSave.Click += BtnSave_Click;

            // da li se radi update ili insert
            // ako se radi update - treba da povucemo podatke 
            if (this.parentForm.selectedEmployeeID != -1)
            {
                Employee emp = EmployeeRepository.GetEmployeeByID(this.conn,
                                                                this.parentForm.selectedEmployeeID);
                if (emp != null)
                {
                    this.txtName.Text = emp.Name;   
                    this.txtSurname.Text = emp.Surname;
                    this.txtSalary.Text = emp.Salary.ToString();
                    this.birthdayPicker.Value = emp.Birthday;
                    this.btnSave.Text = "Izmijeni zaposlenog"; 
                }
                else
                {
                    MessageBox.Show("Greska! Nepostojeci zaposleni!"); 
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Name = this.txtName.Text; 
            emp.Surname = this.txtSurname.Text;
            emp.Salary = Convert.ToDecimal(this.txtSalary.Text);
            emp.Birthday = this.birthdayPicker.Value;

            if (this.parentForm.selectedEmployeeID != -1)
            {
                // UPDATE
                emp.EmployeeID = this.parentForm.selectedEmployeeID;
                bool result = EmployeeRepository.UpdateEmployee(emp, conn);
                if (result)
                {
                    MessageBox.Show("Izmijenjen zaposleni!");
                }
            }
            else
            {
                bool result = EmployeeRepository.InsertEmployee(emp, conn);
                if (result)
                {
                    MessageBox.Show("Unijet zaposleni!");
                }
            }

            this.parentForm.GetData();
        }
    }
}
