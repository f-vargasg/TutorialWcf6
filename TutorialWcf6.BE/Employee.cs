using System;
using System.Collections.Generic;
using System.Linq;
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
     public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}
