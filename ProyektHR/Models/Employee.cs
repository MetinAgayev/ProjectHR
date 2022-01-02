
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
        public double _salary { get; set; }

        public static int Count = 1000;
       

        public Employee(string fullname, string position, double salary, string DepName)
        {
            Count++;


            No = DepName.Substring(0, 2).ToUpper() + Count;  
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
                {
                    Console.WriteLine("Maas 250den az ola bilmez");
                }
                    _salary = value;
            }
        }


        public override string ToString()
        {
            return $"Nomresi: {No} Adi: {Fullname}position: {Position} Maasi {Salary} Departmenti {DepartmentName }  ";
        }
    }
}
