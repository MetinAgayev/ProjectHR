
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


        public Department[] Departments => _departments;
        public Department[] _departments;

        public HumanResourcesManager()
        {
            _departments = new Department[0];



        }


        public void AddDepartment(string name, double workerLimit, double salaryLimit)
        {
            Department department = new Department(name, workerLimit, salaryLimit);
            Array.Resize(ref _departments, _departments.Length + 1);
            _departments[_departments.Length - 1] = department;

        }



        public void AddEmployee(string fullname, string position, double salary, string DepName)
        {
            foreach (Department item in Departments)
            {
                if (item.Employees!=null &&item.Name.ToLower() == DepName.ToLower())
                {
                    Employee employee = new Employee(fullname, position, salary, DepName);

                    Array.Resize(ref item._employees, item._employees.Length + 1);
                    item._employees[item._employees.Length - 1] = employee;
                    break;
                }
            }
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


        public void EditEmployee(string pos, double salary)
        {
            Employee employe = null;
            foreach (Department item in Departments)
            {


                foreach (Employee item1 in item._employees)
                {
                    if (item1.Position == pos)
                    {
                        employe = item1;
                        break;
                    }
                }
                foreach (Employee item2 in item._employees)
                {
                    if (item2.Salary == salary)
                    {
                        employe = item2;
                        break;
                    }
                }

                employe.Position = pos;
                employe.Salary = salary;
            }

        }

        public void GetDepartments(Department Departaments)
        {
            throw new NotImplementedException();
        }

        public void RemoveEmployee(string isci)
        {
            foreach (var item in Departments)
            {


                for (int i = 0; i < item._employees.Length; i++)
                {
                    if (item.Employees[i] != null &&item._employees[i].No == isci)
                    {
                        item._employees[i] = null;
                        return;
                    }
                }
            }
        }

        public void ShowEmployee()
        {
            throw new NotImplementedException();
        }

        public void GetEmployeeByDepartment(string DepName)
        {
            //foreach (Employee item in _employees)
            //{
            //    if (item.DepartmentName == DepName)
            //    {
            //        Console.WriteLine(item);
            //    }

            //}
        }


    }
}
