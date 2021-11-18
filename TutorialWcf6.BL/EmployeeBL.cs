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
    }
}
