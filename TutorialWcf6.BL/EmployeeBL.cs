using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorialWcf6.BE;
using TutorialWcf6.DL;

namespace TutorialWcf6.BL
{
    public class EmployeeBL
    {
        EmployeeDL employeeDL;

        public EmployeeBL()
        {
            this.employeeDL = new EmployeeDL();
        }

        public Employee GetEmployee(int id)
        {
            Employee employee = null;
            try
            {
                employee = this.employeeDL.GetEmployee(id);
            }
            catch (Exception)
            {

                throw;
            }
            return employee;
        }

        
        public void SaveEmployee(Employee employee)
        {
            try
            {
                this.employeeDL.SaveEmployee(employee);
            }
            catch (Exception)
            {

                throw;
            }
        } 

        public void SaveEmployee(EmployeeInfo employeeInfo)
        {
            Employee employee = null;
            try
            {
                if (employeeInfo.Type == EmployeeType.FullTimeEmployee)
                {
                    employee = new FullTimeEmployee();
                    ((FullTimeEmployee)employee).AnnualSalary = employeeInfo.AnnualSalary;
                } 
                else
                {
                    ((PartTimeEmployee)employee).HourlyPay = employeeInfo.HourlyPay;
                    ((PartTimeEmployee)employee).HoursWorked = employeeInfo.HoursWorked;
                }
                    
                employee.Name = employeeInfo.Name;  
                employee.Id = employeeInfo.Id;  
                employee.Gender = employeeInfo.Gender;  
                employee.Type = employeeInfo.Type;
                employee.DateOfBirth = employeeInfo.DOB;
                this.employeeDL.SaveEmployee(employee);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
