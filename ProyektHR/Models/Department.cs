
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
            {  ;
            }
        }
        public double _salarylimit { get; set; }
        public double SalaryLimit {
            get
            {
                return _salarylimit;
            }
            set
            {
                ;
            }

           }
        
        public Department(string name, double workerLimit, double salaryLimit)
        {
            Name = name;
            _workerlimit = workerLimit;
          _salarylimit = salaryLimit;
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
