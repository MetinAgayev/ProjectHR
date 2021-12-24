using System;
using System.Collections.Generic;
using System.Text;

namespace ProyektHR.Models
{
    class DepSalaryAvarage
    {
        public Employee Employee { get; set; }
        public int Count { get; set; }
        public DepSalaryAvarage(Employee employee,int count)
        {
            Employee = employee;
            Count = count;
        }
        
    }
}
