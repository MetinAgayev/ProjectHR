using ProyektHR.Interfaces;
using ProyektHR.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyektHR.Services
{
    class HumanResourcesmanager : IHumanResources
    {

        public Departament[] _departaments;
        public Departament[] departaments => _departaments;

        public Employee[] employees => throw new NotImplementedException();

        public void AddDepartament(Departament[] departaments)
        {
            Departament departaments = new Departament();
            Array.Resize(ref _menuItems, _menuItems.Length + 1);
            _menuItems[_menuItems.Length - 1] = menuItem;
        }

        public void AddEmployee(Employee[] employees)
        {
          
        }

        public void Editdepartaments(Departament[] departaments)
        {
           
        }

        public void EditEployee(Employee[] employees)
        {
          
        }

        public void Getdepartament(Departament[] departaments)
        {
          
        }

        public void RemoveEmployee(Employee[] employees)
        {
          
        }
    }
}
