﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TutorialWcf6.WebClient.EmployeeService;

namespace TutorialWcf6.WebClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetEmployee_Click(object sender, EventArgs e)
        {
            EmployeeServiceClient client = new EmployeeServiceClient();

            Employee employee = client.GetEmployee(Convert.ToInt32(txtID.Text));
            txtName.Text = employee.Name;
            txtGender.Text = employee.Gender;
            txtDateOfBirth.Text = employee.DateOfBirth.ToShortDateString();
            lblMessage.Text = "Employee Retrieved";
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            EmployeeServiceClient client = new EmployeeServiceClient();
            Employee employee = new Employee();
            employee.Name = txtName.Text; 
            employee.Gender = txtGender.Text;   
            employee.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);
            client.SaveEmployee(employee);
            lblMessage.Text = "Employee Saved!!";
        }
    }
}