
using ProyektHR.Models;
using System;

namespace ProyektHR
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("metin","Ceo",260,"Maliyye");
            Employee employee1 = new Employee("mehmemed","co",1200,"Hrasda");
            Console.WriteLine(employee);
            Console.WriteLine(employee1);
        }

    }
}
