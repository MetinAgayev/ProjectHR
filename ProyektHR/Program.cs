using ProyektHR.Enum;
using ProyektHR.Models;
using System;

namespace ProyektHR
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("MetinAgayev", "CEO", 450, Category.Maliyye);
            Employee employee1 = new Employee("MetinAgayev", "CEO", 450, Category.HumanResources);
            Employee employee2 = new Employee("MetinAgayev", "CEO", 350, Category.Management);
            Employee employee3 = new Employee("MetinAgayev", "CEO", 1000, Category.IT);

            DepSalaryAvarage depSalaryAvarage = new DepSalaryAvarage(employee, 4);
            DepSalaryAvarage depSalaryAvarage1 = new DepSalaryAvarage(employee1, 4);
            DepSalaryAvarage depSalaryAvarage2 = new DepSalaryAvarage(employee2, 4);
            DepSalaryAvarage depSalaryAvarage3 = new DepSalaryAvarage(employee3, 4);
            Console.WriteLine(depSalaryAvarage);
            Console.WriteLine(depSalaryAvarage1);
            Console.WriteLine(depSalaryAvarage2);
            Console.WriteLine(depSalaryAvarage3);
        }
    }
}
