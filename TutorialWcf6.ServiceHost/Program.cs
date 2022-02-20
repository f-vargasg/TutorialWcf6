using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace TutorialWcf6.MyServiceHost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var serviceHost = new ServiceHost(typeof(TutorialWcf6.WcfServiceTutorCap6.EmployeeService)))
            {
                serviceHost.Open();
                Console.WriteLine("Host Started @ " + DateTime.Now.ToString());
                Console.ReadLine();
            }

        }
    }
}
