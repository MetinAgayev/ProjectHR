
using ProyektHR.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyektHR.Models
{
    class Department
    {

        public string Name { get; set; }
        public Employee[] Employees => _employees;
        public Employee[] _employees;
        public double Average { get; set; }
        public double _workerlimit { get; set; }
        public double WorkerLimit {
            get
            {
                return _workerlimit;
            }
            set
            {
                foreach (var item in Employees)
                {

                
                if (value<item.)
                {
                    Console.WriteLine("isci limitini kecmisiniz");
                }

            }
        }
        public double SalaryLimit { get; set; }


        
        public Department(string name, double workerLimit, double salaryLimit)
        {
            Name = name;
            WorkerLimit = workerLimit;
            SalaryLimit = salaryLimit;
       _employees   = new Employee[0];

        }

        public double CalcSalaryAverage()
        {
            double avarage = 0;
            int count = 0;
            foreach (var item in Employees)
            {

                if (item.DepartmentName != null )
                {
                    count++;
                }
                avarage = item.Salary / count;
            }

            return avarage;
        }


        public override string ToString()
        {
            return $"Departmentin adi:{Name}\nIsci limiti :{WorkerLimit}\nMaas limiti:{SalaryLimit}";
        }

      




    }
}
