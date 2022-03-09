using System;
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
            IEmployeeService client = new EmployeeService.EmployeeServiceClient();
            EmployeeRequest request =
                new EmployeeRequest("AXG120ABC", Convert.ToInt32(txtID.Text));
            EmployeeInfo employee = client.GetEmployee(request);

            if (employee.Type == EmployeeType.FullTimeEmployee)
            {
                txtAnnualSalary.Text = employee.AnnualSalary.ToString();
                trAnnualSalary.Visible = true;
                trHourlPay.Visible = false;
                trHoursWorked.Visible = false;
            }
            else
            {
                txtHourlyPay.Text = employee.HourlyPay.ToString();
                txtHoursWorked.Text = employee.HoursWorked.ToString();
                trAnnualSalary.Visible = false;
                trHourlPay.Visible = true;
                trHoursWorked.Visible = true;
            }
            ddlEmployeeType.SelectedValue = ((int)employee.Type).ToString();

            txtName.Text = employee.Name;
            txtGender.Text = employee.Gender;
            txtDateOfBirth.Text = employee.DOB.ToShortDateString();
            lblMessage.Text = "Employee Retrieved";
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            IEmployeeService client = new EmployeeServiceClient();
            EmployeeInfo employee = new EmployeeInfo();

            if (ddlEmployeeType.SelectedValue == "-1")
            {
                lblMessage.Text = "Please Select Employee Type";
            }
            else
            {
                if (((EmployeeType)Convert.ToInt32(ddlEmployeeType.SelectedValue)) == EmployeeType.FullTimeEmployee)
                {
                    employee.Type = EmployeeType.FullTimeEmployee;
                    employee.AnnualSalary = Convert.ToInt32(txtAnnualSalary.Text);
                }
                else
                {
                    employee.Type = EmployeeType.PartTimeEmployee;
                    employee.HourlyPay = Convert.ToInt32(txtHourlyPay.Text);
                    employee.HoursWorked = Convert.ToInt32(txtHoursWorked.Text);
                }

                employee.Id = Convert.ToInt32(txtID.Text);
                employee.Name = txtName.Text;
                employee.Gender = txtGender.Text;
                employee.DOB = Convert.ToDateTime(txtDateOfBirth.Text);
                client.SaveEmployee(employee);
                lblMessage.Text = "Employee saved";
            }
        }

        protected void ddlEmployeeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlEmployeeType.SelectedValue == "-1")
            {
                trAnnualSalary.Visible = false;
                trHourlPay.Visible = false;
                trHoursWorked.Visible = false;
            }
            else if (ddlEmployeeType.SelectedValue == "1")
            {
                trAnnualSalary.Visible = true;
                trHourlPay.Visible = false;
                trHoursWorked.Visible = false;
            }
            else
            {
                trAnnualSalary.Visible = false;
                trHourlPay.Visible = true;
                trHoursWorked.Visible = true;
            }
        }
    }
}