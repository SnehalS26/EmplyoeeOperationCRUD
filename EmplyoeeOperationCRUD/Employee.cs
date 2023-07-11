using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplyoeeOperationCRUD
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
    }

    public class EmployeeCRUD
    {
        private List<Employee> employees;
        public EmployeeCRUD()
        {
            employees = new List<Employee>();
        }
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public List<Employee> GetEmployee()
        {
            return employees;
        }

        public void UpdateEmployee(Employee employee)
        {
            foreach (Employee emp in employees)
            {
                if (emp.Id == employee.Id)
                {
                    emp.Name = employee.Name;
                    emp.Salary = employee.Salary;
                    break;
                }
            }
        }

        public void DeleteEmployee(int id)
        {
            foreach (Employee emp in employees)
            {
               if(emp.Id == id) 
                {
                    employees.Remove(emp);
                    break;
                }
            }
        }
    }
}
