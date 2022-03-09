using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using TutorialWcf6.BE;

namespace TutorialWcf6.WcfServiceTutorCap6
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IEmployeeService
    {

        [OperationContract]
        EmployeeInfo GetEmployee(EmployeeRequest request);

        [OperationContract]
        void SaveEmployee(EmployeeInfo employee);


    }
}
