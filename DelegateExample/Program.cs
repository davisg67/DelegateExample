using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    //Defined Delegate - takes the Employee object as a parameter and returns a boolean
    public delegate bool EligibleToPromoteDelegate(Employee E);


    public class Program
    {
        
        static void Main(string[] args)
        {
            //Get list of employees.
            List<Employee> lstEmployees = new List<Employee>();
            lstEmployees = GetEmployeeList();

            //Assign Promote() to delegate.
            EligibleToPromoteDelegate promoteMethod = new EligibleToPromoteDelegate(Program.Promote);

            //Promote employees.
            Employee.PromoteEmployee(lstEmployees, promoteMethod);

            Console.ReadKey();
        }


        //This method has the logic of how we want to promote our employees.
        public static bool Promote(Employee employee)
        {
            if (employee.Salary > 10000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Employee list
        public static List<Employee> GetEmployeeList()
        {
            //Employee Objects
            Employee emp1 = new Employee()
            {
                ID = 101,
                Name = "Pranaya",
                Gender = "Male",
                Experience = 5,
                Salary = 10000
            };
            Employee emp2 = new Employee()
            {
                ID = 102,
                Name = "Priyanka",
                Gender = "Female",
                Experience = 10,
                Salary = 20000
            };
            Employee emp3 = new Employee()
            {
                ID = 103,
                Name = "Anurag",
                Experience = 15,
                Salary = 30000
            };

            //Set a list of employees created.
            List<Employee> lstEmployees = new List<Employee>();
            lstEmployees.Add(emp1);
            lstEmployees.Add(emp2);
            lstEmployees.Add(emp3);

            return lstEmployees;
        }
    }


    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Experience { get; set; }
        public int Salary { get; set; }

        //Takes a list of Employees and a Delegate.
        public static void PromoteEmployee(List<Employee> lstEmployees, EligibleToPromoteDelegate IsEmployeeEligible)
        {
            //Loops thru each employee object.
            foreach (Employee employee in lstEmployees)
            {
                //Passes employee to the delegate.
                //No hard coded logic on how to promote employee.
                if (IsEmployeeEligible(employee))
                {
                    Console.WriteLine("Employee {0} Promoted", employee.Name);
                }
            }
        }
    }

}
