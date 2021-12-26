
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyektHR.Models
{
    class Employee
    {
        public string No { get; set; }
        public string Fullname { get; set; }
        public string Position { get; set; }
        public string DepartmentName { get; set; }
        private double _salary { get; set; }
       
        public int Count = 1000;
    
        public int isciCount = 0;
        public Employee(/*string no,*/ string fullname, string position, double salary, string DepName)
        {

            //No = no;



            Fullname = fullname;
            Position = position;
            _salary = salary;

            DepartmentName = DepName;
          


        }

        public double Salary
        {
            get { return _salary; }
            set
            {
                if (value > 250)
                    _salary = value;
            }

        }


        public override string ToString()
        {
            return $"Nomresi: {No} Adi: {Fullname}position: {Position} Maasi {Salary} Departmenti {DepartmentName }  ";
        }
    }
}
