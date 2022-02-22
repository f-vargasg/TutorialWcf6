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
using TutorialWcf6.WinTestService.RefWcfService;

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
            dtpDateOfBirth.CustomFormat = "dd/MM/yyyy";

            PickEmployeeType pickEmployeeType = new PickEmployeeType()
            {
                Codigo = 1,
                TypeDescription = "Full Time Employee"
            };
            cmbEmployeeType.Items.Add(pickEmployeeType);

            pickEmployeeType = new PickEmployeeType()
            {
                Codigo = 2,
                TypeDescription = "Part Type Employee"
            };
            cmbEmployeeType.Items.Add(pickEmployeeType);

            cmbEmployeeType.SelectedIndex = 0;

            lblMessage.Text = string.Empty;

        }

        private void butGetEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeServiceClient client = new EmployeeServiceClient();

                Employee employee = client.GetEmployee(Convert.ToInt32(txtID.Text));

                if (employee != null)
                {
                    txtName.Text = employee.Name;
                    txtGender.Text = employee.Gender;
                    dtpDateOfBirth.Value = employee.DateOfBirth;

                    cmbEmployeeType.SelectedIndex = (int)(employee.Type) - 1;

                    if (employee.Type == EmployeeType.FullTimeEmployee)
                    {
                        txtAnualSalary.Text = ((FullTimeEmployee)employee).AnnualSalary.ToString();
                    }
                    else
                    {
                        txtHourlyPay.Text = ((PartTimeEmployee)employee).HourlyPay.ToString();
                        txtHoursWorked.Text = ((PartTimeEmployee)employee).HoursWorked.ToString();
                    }

                    lblMessage.Text = "Employee retrieved";
                }
                else
                {
                    MessageBox.Show("Registro: "  + txtID.Text + " no encontrado!!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void butSaveEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeServiceClient client = new EmployeeServiceClient();

                Employee employee = null;

                if (cmbEmployeeType.SelectedIndex == 0)
                {
                    employee = new FullTimeEmployee()
                    {
                        Id = Convert.ToInt32(txtID.Text),
                        Name = txtName.Text,
                        Gender = txtGender.Text,
                        DateOfBirth = dtpDateOfBirth.Value,
                        Type = (EmployeeType)(((PickEmployeeType)cmbEmployeeType.SelectedItem).Codigo),
                        AnnualSalary = Convert.ToInt32(txtAnualSalary.Text)
                    };
                }
                else
                {
                    employee = new PartTimeEmployee()
                    {
                        Id = Convert.ToInt32(txtID.Text),
                        Name = txtName.Text,
                        Gender = txtGender.Text,
                        DateOfBirth = dtpDateOfBirth.Value,
                        Type = (EmployeeType)(((PickEmployeeType)cmbEmployeeType.SelectedItem).Codigo),
                        HourlyPay = Convert.ToInt32(txtHourlyPay.Text),
                        HoursWorked = Convert.ToInt32(txtHoursWorked.Text)
                    };

                }

                client.SaveEmployee(employee);
                lblMessage.Text = "Employee saved!!!";
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cmbEmployeeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAnualSalary.Visible = (((ComboBox)sender).SelectedIndex == 0);
            txtHourlyPay.Visible = txtHoursWorked.Visible = (((ComboBox)sender).SelectedIndex == 1);
        }
    }

    class PickEmployeeType
    {
        public int Codigo { get; set; }
        public string TypeDescription { get; set; }

        public override string ToString()
        {
            return this.Codigo.ToString() + " - " + this.TypeDescription;
        }
    }
}
