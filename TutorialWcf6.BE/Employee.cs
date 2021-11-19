using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TutorialWcf6.BE
{
    /// <summary>
    /// Las anotaciones DataContract y DataMember son explicitos en .net framework 3.5 up
    /// Con esas anotaciones se puede controlar cosas como la serialización de los elementos
    /// de la clase (ver atributos privados, en el cliente, el orden y otros)
    /// Falta averiguar para que sirve la anotacion Namespace
    /// </summary>

    [KnownType(typeof(FullTimeEmployee))]
    [KnownType(typeof(PartTimeEmployee))]
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
