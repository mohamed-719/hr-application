using System.Collections.Generic;

namespace HRApplicationAR.Models
{
    public class Repository
    {
        private static List<Employee>  employeesList = new List<Employee>(); 

        public static IEnumerable<Employee> GetEmployee()
        {
            return employeesList;
        }
        public static void  AddEmployee( Employee emp)
        {
            employeesList.Add(emp);
        }
    }
}
