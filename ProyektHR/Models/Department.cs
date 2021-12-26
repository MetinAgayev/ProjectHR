using System;
using System.Collections.Generic;
using System.Text;

namespace ProyektHR.Models
{
    class Department
    {

        public string Name { get; set; }
        public double WorkerLimit { get; set; }
        public double SalaryLimit { get; set; }
        public Department(string name, double workerLimit, double salaryLimit)
        {
            Name = name;
            WorkerLimit = workerLimit;
            SalaryLimit = salaryLimit;
        }


        public override string ToString()
        {
            return $"Departmentin adi:{Name}\nIsci limiti :{WorkerLimit}\nMaas limiti:{SalaryLimit}";
        }
       

    }
}
