
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyektHR.Models
{
    class Employee
    {
        private static int count = 1000;
        public string Name { get; set; }
        public string No { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
        public Departament[] Departaments { get; set; }
        public Employee(string name, string position, int salary,string Depname)
        {
            if (salary < 250)
            {
                Console.WriteLine("Maas 250den kicik ola bilmez");
                return;
            }
            else if (position.Length<2)
            {
                Console.WriteLine("Duzgun vezife adi daxil edin");
                return;
            }
           
            


            count++;
            FullName = name;
            Position = position;
            Salary = salary;
            Name = Depname;

           
            No += Name.Substring(0, 2)+count;
          

        }
        
        
       
        public override string ToString()
        {
            return $"SiraNomresi:{No}\nName:{FullName}\nPosition:{Position}\nSalary:{Salary}\nDepname:{Name}";
        }



    }
}
