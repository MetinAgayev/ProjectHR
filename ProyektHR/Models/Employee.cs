using ProyektHR.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyektHR.Models
{
    class Employee
    {
        private static int count = 1000;
        public string No { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
        public Category Category { get; set; }
        public Employee(string name, string position, int salary, Category category)
        {
            count++;
            FullName = name;
            Position = position;
            Salary = salary;
            Category = category;


            switch ((int)category)
            {

                case 0:
                    No += "Ma" + count;
                    break;
                case 1:
                    No += "IT" + count;
                    break;
                case 2:
                    No += "HR" + count;
                    break;
                case 3:
                    No += "MG" + count;
                    break;


            }
        }
             public override string ToString()
        {
            return $"SiraNomresi:{No}\nName:{FullName}\nPosition:{Position}\nSalary:{Salary}\nCategory:{Category}";
        }


       
    }
}
