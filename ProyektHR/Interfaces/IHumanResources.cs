using ProyektHR.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyektHR.Interfaces
{
    interface IHumanResources
    {
        Departament[] departaments { get; }
        Employee[] employees { get; }
        void AddDepartament(Departament[] departaments);
        void Getdepartament(Departament[] departaments);
        void Editdepartaments(Departament[] departaments);
        void AddEmployee(Employee[] employees);
        void RemoveEmployee(Employee[] employees);
        void EditEployee(Employee[] employees);

    }
}
