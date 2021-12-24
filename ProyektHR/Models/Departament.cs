using System;
using System.Collections.Generic;
using System.Text;

namespace ProyektHR.Models
{
    class Departament
    {
        private static int count = 0;
        public string Name { get; set; }
        public int WorkerLimit { get; set; }
        public int SalaryLimit { get; set; }
        public string Employees { get; set; }
        public DepSalaryAvarage[] DepSalaryAvarages { get; set; }



        public Departament(DepSalaryAvarage[] depSalaryAvarages)
        {
            if (depSalaryAvarages.Length <= 0)
            {
                return;
            }
            count++;
            WorkerLimit = count;
            DepSalaryAvarages = depSalaryAvarages;
            foreach (DepSalaryAvarage item in depSalaryAvarages)
            {
               SalaryLimit += (item.Employee.Salary * item.Count);
                DepSalaryAvarages=   ;

            }
        }
          public override string ToString()
        {

            return $"{SalaryLimit} {count}";
        }

      }
     

    
}
