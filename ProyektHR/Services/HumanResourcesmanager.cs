
using ProyektHR.Interfaces;
using ProyektHR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ProyektHR.Services
{
    class HumanResourcesManager : IHumanResourceManager
    {
        public Employee[] Employees => _employees;
        public Employee[] _employees;

        public Department[] Departments => _departments;
        public Department[] _departments;
       
        public HumanResourcesManager()
        {
            _departments = new Department[0];
            _employees = new Employee[0];


        }


        public void AddDepartment(string name, double workerLimit, double salaryLimit)
        {
            Department department = new Department(name, workerLimit, salaryLimit);
            Array.Resize(ref _departments, _departments.Length + 1);
            _departments[_departments.Length - 1] = department;
        }


      
        public void AddEmployee( string fullname, string position, double salary, string DepName)
        {
            Employee employee = new Employee( fullname, position, salary, DepName);
            Array.Resize(ref _employees, _employees.Length + 1);
            _employees[_employees.Length - 1] = employee;
        }

        public void EditDepartments(string name, double workerLimit, double salaryLimit)
        {
            Department department = null;

            foreach (Department item in _departments)
            {
                if (item.Name == name)
                {
                    department = item;
                    break;
                }
            }

            department.Name = name;
           
        }


        public void EditEmploye(string pos, double salary)
        {
            Employee employe = null;

            foreach (Employee item in _employees)
            {
                if (item.Position == pos)
                {
                    employe = item;
                    break;
                }
            }
            foreach (Employee item in _employees)
            {
                if (item.Salary == salary)
                {
                    employe = item;
                    break;
                }
            }

            employe.Position = pos;
            employe.Salary = salary;


        }

        public void GetDepartments(Department Departaments)
        {
            throw new NotImplementedException();
        }

        public void RemoveEmployee(string isci)
        {
            for (int i = 0; i < _employees.Length; i++)
            {
                if (Employees[i] != null && _employees[i].No == isci)
                {
                    _employees[i] = null;
                    return;
                }
            }
        }

        public void ShowEmployee()
        {
            throw new NotImplementedException();
        }

        public void GetEmployeeByDepartment(string DepName)
        {
            foreach (Employee item in _employees)
            {
                if (item.DepartmentName == DepName)
                {
                    Console.WriteLine(item);
                }

            }
        }

    }
}
