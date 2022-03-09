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
        public EmployeeInfo GetEmployee(EmployeeRequest request)
        {
            Console.WriteLine("License Key = " + request.LicenseKey);
            EmployeeBL employeeBL = new EmployeeBL();
            Employee employee = employeeBL.GetEmployee(request.EmployeeId);
            return new EmployeeInfo(employee);
        }

        public void SaveEmployee(EmployeeInfo employee)
        {
            EmployeeBL employeeBL = new EmployeeBL();
            employeeBL.SaveEmployee(employee);
        }
    }
}
