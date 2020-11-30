using System;
using System.Globalization;
using System.Collections.Generic;
using FirstProject.Entities;
using FirstProject.Entities.Enums;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string dptName = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department department = new Department(dptName);

            Worker worker = new Worker(name, level, baseSalary, department);

            Console.WriteLine("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime dateTime = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per (hours): ");
                double valuePerHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hour = int.Parse(Console.ReadLine());

                HourContract hourContract = new HourContract(dateTime, valuePerHours, hour);

                worker.AddContract(hourContract);
                Console.WriteLine();
            }

            Console.Write("Enter month and year to caculate income (MM/YYYY): ");
            string[] monthYear =  Console.ReadLine().Split('/');
            int month = int.Parse(monthYear[0]);
            int year = int.Parse(monthYear[1]);

            double income =  worker.Income(year, month);

            
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department " + worker.Department.Name);
            Console.WriteLine("Income for " + monthYear + ": " + income.ToString("F2",CultureInfo.InvariantCulture));

        }

    }
}
