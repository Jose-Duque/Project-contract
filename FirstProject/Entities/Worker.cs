using System;
using System.Collections.Generic;
using FirstProject.Entities.Enums;

namespace FirstProject.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contract { get; set; } = new List<HourContract>();

        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contract.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contract.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contracts in Contract)
            {
                if (contracts.Date.Year == year && contracts.Date.Month == month)
                {
                    sum += contracts.TotalValue();
                }
            }
            return sum;
        }

       
    }
}
