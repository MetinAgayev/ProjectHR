using ProyektHR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyektHR.Interfaces
{
    interface IHumanResourceManager
    {
        Department[] Departments { get; }
        Employee[] Employees { get; }

        void AddDepartment(string name, double workerLimit, double salaryLimit /*Department Employees*/);
        //void GetDepartments(Department Departaments);
        void EditDepartments(string name, double workerLimit, double salaryLimit);
        void AddEmployee(string fullname, string position, double salary, string DepName);
        void RemoveEmployee();
        void ShowEmployee();
        void EditEmploye();

    }
}
