using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplyoeeOperationCRUD
{
    public class Program
    {
        static void Main(string[] args)
        {
            EmployeeCRUD employeeCRUD = new EmployeeCRUD();
            int option = 0;
            do
            {
                Console.WriteLine("1. Add Employee Data");
                Console.WriteLine("2. Update Employee Data");
                Console.WriteLine("3. Delete Employee Data");
                Console.WriteLine("4. Display All Employee Data");
                int op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Employee employee = new Employee();
                        Console.WriteLine("Enter Employee Id");
                        employee.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Employee Name:");
                        employee.Name = Console.ReadLine();
                        Console.WriteLine("Enter Employee Salary:");
                        employee.Salary = Convert.ToDouble(Console.ReadLine());

                        employeeCRUD.AddEmployee(employee);
                        break;

                    case 2:
                        Employee employee1 = new Employee();
                        Console.WriteLine("Enter id to modify");
                        employee1.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Employee Name:");
                        employee1.Name = Console.ReadLine();
                        Console.WriteLine("Enter Employee Salary:");
                        employee1.Salary = Convert.ToDouble(Console.ReadLine());

                        employeeCRUD.UpdateEmployee(employee1);
                        break;

                    case 3:
                        Console.WriteLine("Enter id to delete");
                        int id = Convert.ToInt32(Console.ReadLine());
                        employeeCRUD.DeleteEmployee(id);
                        break;

                    case 4:
                        List<Employee> list = employeeCRUD.GetEmployee();
                        foreach (Employee emp in list)
                        {
                            Console.WriteLine($"{emp.Id} --> {emp.Name} -->{emp.Salary}");
                        }
                        break;
                }
                Console.WriteLine("Press 1 for Continue");
                option = Convert.ToInt32(Console.ReadLine());


            }
            while (option == 1);
            
        }
    }
}
