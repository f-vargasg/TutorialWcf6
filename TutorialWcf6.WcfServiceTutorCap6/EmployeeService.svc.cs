using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using TutorialWcf6.BE;
using TutorialWcf6.BL;

namespace TutorialWcf6.WcfServiceTutorCap6
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class EmployeeService : IEmployeeService
    {
        public Employee GetEmployee(int id)
        {
            EmployeeBL employeeBL = new EmployeeBL();
            Employee employee = employeeBL.GetEmployee(id);
            return employee;
        }

        public void SaveEmployee(Employee employee)
        {
            EmployeeBL employeeBL = new EmployeeBL();
            employeeBL.Insertar(employee);
        }
    }
}
