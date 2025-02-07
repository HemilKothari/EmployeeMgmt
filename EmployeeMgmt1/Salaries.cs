﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeMgmt1
{
    public partial class Salaries : Form
    {
        Functions Con;
        public Salaries()
        {
            InitializeComponent();
            Con = new Functions();
            ShowSalary();
            GetEmployees();
        }
        private void ShowSalary()
        {
            try
            {
                string Query = "Select * from SalaryTbl";
                SalaryList.DataSource = Con.GetData(Query);
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void GetEmployees()
        {
            string Query = "select * from EmployeeTbl";
            EmpCb.DisplayMember = Con.GetData(Query).Columns["EmpName"].ToString();
            EmpCb.ValueMember = Con.GetData(Query).Columns["EmpId"].ToString();
            EmpCb.DataSource = Con.GetData(Query);
        }
        int DSal = 0;
        string Period = "";
        private void GetSalary()
        {
            string Query = "select EmpSal from EmployeeTbl where EmpId = {0} ";
            Query = string.Format(Query, EmpCb.SelectedValue.ToString());
            foreach (DataRow dr in Con.GetData(Query).Rows)
            {
                DSal = Convert.ToInt32(dr["EmpSal"].ToString());
            }
            //MessageBox.Show("" + DSal);

            if (DaysTb.Text == "")
            {
                AmountTb.Text = "₹ " + (d * DSal);
            }
            else if (Convert.ToInt32(DaysTb.Text) > 31)
            {
                MessageBox.Show("Days Cannot be gretae than 31.");
            }
            else
            {
                d = Convert.ToInt32(DaysTb.Text);
                AmountTb.Text = "₹ " + (d * DSal);
            }
        }
        private void SalaryList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int d = 1;
        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpCb.SelectedIndex == -1 || DaysTb.Text == "" || PeriodTb.Text == "")
                {
                    MessageBox.Show("Missing Details!!!");
                }
                else
                {
                    Period = PeriodTb.Value.Date.Month.ToString() + " " + PeriodTb.Value.Date.Year.ToString();
                    int Amount = DSal + Convert.ToInt32(DaysTb.Text);
                    int Days = Convert.ToInt32(DaysTb.Text);
                    string Query = "insert into SalaryTbl values({0}, {1}, '{2}', {3}, '{4}')";
                    Query = string.Format(Query, EmpCb.SelectedValue.ToString(), Days, Period, Amount, DateTime.Today.Date);
                    Con.SetData(Query);
                    ShowSalary();
                    MessageBox.Show("Salary Paid!!!");
                    DaysTb.Text = "";
                    AmountTb.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void EmpCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetSalary();
        }

        private void EmployeeLbl_Click(object sender, EventArgs e)
        {
            Employees Obj = new Employees();
            Obj.Show();
            this.Hide();
        }

        private void DepartmentLbl_Click(object sender, EventArgs e)
        {
            Departments Obj = new Departments();
            Obj.Show();
            this.Hide();
        }

        private void LogoutLbl_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }
    }
}
