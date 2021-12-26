
using System;
using ProyektHR.Models;
using ProyektHR.Services;
namespace ProyektHR
{
    class Program
    {
        static void Main(string[] args)
        {
            HumanResourcesManager humanResourcesManager = new HumanResourcesManager();
            do
            {
                Console.WriteLine("-------------------------WORK--------------------");
                Console.WriteLine("Nomre daxil edin");
                Console.WriteLine("1: Departameantlerin siyahisini gostermek");
                Console.WriteLine("2: Departamenet yaratmaq");
                Console.WriteLine("3: Departamenetde deyisiklik et");
                Console.WriteLine("4: Isci elave et");
                Console.WriteLine("5: Iscilerin siyahisini gostermek");

                string choose = Console.ReadLine();
                int chooseNum;
                int.TryParse(choose, out chooseNum);
                switch (chooseNum)
                {
                    case 1:
                        Console.Clear();
                        ShowAllList(ref humanResourcesManager);
                        break;
                    case 2:
                        Console.Clear();
                        AddDepartmen(ref humanResourcesManager);
                        break;
                    case 3:
                        Console.Clear();
                        EditDepartments(ref humanResourcesManager);
                        break;
                    case 4:
                        Console.Clear();
                        AddEmployee(ref humanResourcesManager);
                        break;
                    case 5:
                        Console.Clear();
                        ShowEmpList(ref humanResourcesManager);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Duzgun Daxil Et");
                        break;
                }

            } while (true);

        }

        public static void EditDepartments(ref HumanResourcesManager humanResourcesManager)
        {
            if (humanResourcesManager.Departments.Length <= 0)
            {
                Console.WriteLine("Siyahi Bosdur. Once Daxil Edin");
                return;
            }

            foreach (Department item in humanResourcesManager.Departments)
            {
                Console.WriteLine(item);
                Console.WriteLine("------------------------------------");
            }

            Console.Write("Duzelis Etmek Isdediyniz Departamentin adini Daxil Et");
            string depName = Console.ReadLine();
            bool checkDepName = true;
            int count = 0;
        start:
            while (checkDepName)
            {
                foreach (Department item in humanResourcesManager.Departments)
                {
                    if (item.Name.ToLower() == depName.ToLower())
                    {
                        count++;
                    }
                }

                if (count <= 0)
                {
                    Console.WriteLine("Daxil Etdiyniz adda department yoxdur");
                    Console.Write("Duzgun Departament adi Daxil Et: ");
                    depName = Console.ReadLine();
                    goto start;
                }

                else
                {
                    checkDepName = false;

                }
                count = 0;




                Console.Write("Yeni departament adi daxil edin: ");
                string nameE = Console.ReadLine();


                while (nameE.Length! < 2)
                {
                    Console.WriteLine("Departamentin adi 2 herfden az ola bilmez:");
                    nameE = Console.ReadLine();
                }

                foreach (Department item in humanResourcesManager.Departments)
                {
                    if (item.Name.ToLower() == depName)
                    {
                        item.Name = nameE;
                    }


                }
                Console.WriteLine("Salarynin yeni limitini Daxil Et: ");
                string price = Console.ReadLine();
                double priceNum;

                while (!double.TryParse(price, out priceNum) || priceNum < 250)
                {
                    Console.WriteLine("Duzgun Limit Daxil Et:");
                    price = Console.ReadLine();
                }
                foreach (Department item in humanResourcesManager.Departments)
                {
                    if (item.Name.ToLower() == depName)
                    {
                        item.SalaryLimit = priceNum;
                    }


                }

            }




        }

        static void ShowAllList(ref HumanResourcesManager humanResourcesManager)
        {
            if (humanResourcesManager.Departments.Length <= 0)
            {
                Console.WriteLine("Siyahi bosdur, evvelce daxil edin.");
                return;

            }
            foreach (Department item in humanResourcesManager.Departments)
            {
                Console.WriteLine(item);
                Console.WriteLine("--------------------------------------------------");
            }
        }
        static void ShowEmpList(ref HumanResourcesManager humanResourcesManager)
        {
            if (humanResourcesManager.Employees.Length <= 0)
            {
                Console.WriteLine("Siyahi bosdur, evvelce daxil edin.");
                return;

            }
            foreach (Employee item in humanResourcesManager.Employees)
            {
                Console.WriteLine(item);
                Console.WriteLine("----------------------------------------------------");
            }
        }
        static void AddDepartmen(ref HumanResourcesManager humanResourcesManager)
        {
            Console.Write("Elave edeceyiniz Departmenti daxil edin: ");
            string name = Console.ReadLine();
            bool chechName = true;
            int count = 0;

            while (chechName)
            {
                foreach (Department item in humanResourcesManager.Departments)
                {
                    if (item.Name.ToLower() == name.ToLower())
                    {
                        count++;
                    }
                }


                if (count > 0)
                {
                    Console.WriteLine("Daxil etdiyiniz departman artiq movcuddur");
                    Console.Write("Duzgun daxil edin: ");
                    name = Console.ReadLine();
                }
                else
                {
                    chechName = false;
                }
                count = 0;
            }

            Console.WriteLine("Isci sayini daxil edin");
            string workerLimit = Console.ReadLine();
            double workekNum;

            while (!double.TryParse(workerLimit, out workekNum) || workekNum < 1)
            {
                Console.WriteLine("Duzgun Say Daxil Et:");
                workerLimit = Console.ReadLine();
            }

            Console.WriteLine("Salary Limiti daxil edin");
            string salaryLimit = Console.ReadLine();
            double salaryNum;

            while (!double.TryParse(salaryLimit, out salaryNum) || salaryNum < 250)
            {
                Console.WriteLine("Duzgun Salary Daxil Et:");
                salaryLimit = Console.ReadLine();

            }

            humanResourcesManager.AddDepartment(name, workekNum, salaryNum);
        }

        static void AddEmployee(ref HumanResourcesManager humanResourcesManager)
        {
            string no;
            foreach (Employee item in humanResourcesManager.Employees)
            {
                no = item.DepartmentName.Substring(0, 2) + item.Count;
                item.No = no;

            }


            if (humanResourcesManager.Departments.Length <= 0)
            {
                Console.WriteLine("Evvelce department yaradin.");
                return;

            }


            Console.Write("Elave edeceyiniz Iscinin adini daxil edin: ");
            string name = Console.ReadLine();



            Console.WriteLine("Isci Positionunu daxil edin");
            string workerPos = Console.ReadLine();


            while (workerPos.Length! < 2)
            {
                Console.WriteLine("Position adi 2 herfden az olmamalidir:");
                workerPos = Console.ReadLine();
            }

            Console.WriteLine("Salary daxil edin");
            string salary = Console.ReadLine();
            double salaryNum;

            while (!double.TryParse(salary, out salaryNum) || salaryNum < 250)
            {
                Console.WriteLine("Duzgun Salary Daxil Et:");
                salary = Console.ReadLine();

            }
            Console.Write("Elave edeceyiniz Departmenti daxil edin: ");
            string nameDep = Console.ReadLine();
            bool chechNameD = true;
            int countCheck = 0;


            while (chechNameD)
            {
                foreach (Department item in humanResourcesManager.Departments)
                {
                    if (nameDep == item.Name)
                    {
                        countCheck++;
                    }

                }

                if (countCheck <= 0)
                {
                    Console.WriteLine("Bu departament movcud deyil");
                    Console.Write("Duzgun daxil edin: ");
                    nameDep = Console.ReadLine();

                }


                else
                {

                    chechNameD = false;
                }
                countCheck = 0;
                //humanResourcesManager.AddEmployee (/*no, */name, workerPos, salaryNum, nameDep);
            }

        }
    }
}
