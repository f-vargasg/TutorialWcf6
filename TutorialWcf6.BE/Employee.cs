using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace TutorialWcf6.BE
{

    [MessageContract(IsWrapped =true, WrapperName ="EmployeeRequestObject", WrapperNamespace ="http://MyCompany.com/Employee")]
    public class EmployeeRequest
    {
        [MessageHeader(Namespace = "http://MyCompany.com/Employee")]
        public string LicenseKey { get; set; }

        [MessageBodyMember(Namespace = "http://MyCompany.com/Employee")]
        public int EmployeeId { get; set; }
    }

    [MessageContract(IsWrapped = true, WrapperName = "EmployeeInfoObject", WrapperNamespace = "http://MyCompany.com/Employee")]
    public class EmployeeInfo
    {
        public EmployeeInfo()
        {

        }

        public EmployeeInfo(Employee employee)
        {
            this.Id = employee.Id;
            this.Name = employee.Name;  
            this.Gender = employee.Gender;
            this.DOB = employee.DateOfBirth;
            this.Type = employee.Type;
            if (employee.Type == EmployeeType.FullTimeEmployee)
            {
                this.AnnualSalary = ((FullTimeEmployee)employee).AnnualSalary;
            }
            else
            {
                this.HourlyPay = ((PartTimeEmployee)employee).HourlyPay;
                this.HoursWorked = ((PartTimeEmployee)employee).HoursWorked;
            }
        }
        [MessageBodyMember(Order = 1, Namespace = "http://MyCompany.com/Employee")]
        public int Id { get; set; }

        [MessageBodyMember(Order = 2, Namespace = "http://MyCompany.com/Employee")]
        public string Name { get; set; }

        [MessageBodyMember(Order = 3, Namespace = "http://MyCompany.com/Employee")]
        public string Gender { get; set; }

        [MessageBodyMember(Order = 4, Namespace = "http://MyCompany.com/Employee")]
        public DateTime DOB { get; set; }

        [MessageBodyMember(Order = 5, Namespace = "http://MyCompany.com/Employee")]
        public EmployeeType Type { get; set; }

        [MessageBodyMember(Order = 6, Namespace = "http://MyCompany.com/Employee")]
        public int AnnualSalary { get; set; }

        [MessageBodyMember(Order = 7, Namespace = "http://MyCompany.com/Employee")]
        public int HourlyPay { get; set; }

        [MessageBodyMember(Order = 8, Namespace = "http://MyCompany.com/Employee")]
        public int HoursWorked { get; set; }

    }

    /// <summary>
    /// Las anotaciones DataContract y DataMember son explicitos en .net framework 3.5 up
    /// Con esas anotaciones se puede controlar cosas como la serialización de los elementos
    /// de la clase (ver atributos privados, en el cliente, el orden y otros)
    /// Falta averiguar para que sirve la anotacion Namespace
    /// </summary>

    [KnownType(typeof(FullTimeEmployee))]
    [KnownType(typeof(PartTimeEmployee))]
    [DataContract(Namespace = "http://fvgprinc.com/Employee")]
    public class Employee
    {
        [DataMember(Order = 1)]
        public int Id { get; set; }
        [DataMember(Order = 2)]
        public string Name { get; set; }
        [DataMember(Order = 3)]
        public string Gender { get; set; }
        [DataMember(Order = 4)]
        public DateTime DateOfBirth { get; set; }
        [DataMember(Order = 5)]
        public EmployeeType Type { get; set; }

    }

    public enum EmployeeType
    {
        FullTimeEmployee = 1,
        PartTimeEmployee = 2
    }
}
