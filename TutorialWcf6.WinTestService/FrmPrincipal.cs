using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TutorialWcf6.WinTestService.EmployeeServiceRef;

namespace TutorialWcf6.WinTestService
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            InitMyComponents();
        }


        private void InitMyComponents()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = ConfigurationManager.AppSettings["formCaption"];

            dtpDateOfBirth.Format = DateTimePickerFormat.Custom;
            dtpDateOfBirth.CustomFormat = "dd-MM-yyyy";

            lblMessage.Text = string.Empty;

        }

        private void butGetEmployee_Click(object sender, EventArgs e)
        {
            EmployeeServiceClient client = new EmployeeServiceClient();

            Employee employee =  client.GetEmployee( Convert.ToInt32( txtID.Text));

            txtName.Text = employee.Name;
            txtGender.Text = employee.Gender;
            dtpDateOfBirth.Value = employee.DateOfBirth;
            lblMessage.Text = "Employee retrieved";
        }

        private void butSaveEmployee_Click(object sender, EventArgs e)
        {
            EmployeeServiceClient client = new EmployeeServiceClient();

            Employee employee = new Employee()
            {
                Id = Convert.ToInt32(txtID.Text),
                Name = txtName.Text,
                Gender = txtGender.Text,
                DateOfBirth = dtpDateOfBirth.Value
            };

            client.SaveEmployee(employee);
            lblMessage.Text = "Employee saved!!!";
        }
    }
}
