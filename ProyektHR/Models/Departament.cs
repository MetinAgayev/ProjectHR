using System;
using System.Collections.Generic;
using System.Text;

namespace ProyektHR.Models
{
    class Departament
    {
        public string[] Name { get; set; }
        public Employee WorkerLimit { get; set; }
        public Employee SalaryLimit { get; set; }
        public Employee Employees { get; set; }
        public DepSalaryAvarage[] DepSalaryAvarages { get; set; }

     
    }
     
     

    
}
