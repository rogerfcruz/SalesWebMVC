using System;
using System.Collections.Generic;
using System.Linq;
namespace SalesWebMVC.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Emai { get; set; }
        public double BaseSalary { get; set; }
        public DateTime Birthday { get; set; }
        public Department Department { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {
        }

        public Seller(int id, string name, string emai, double baseSalary, DateTime birthday, Department department)
        {
            Id = id;
            Name = name;
            Emai = emai;
            BaseSalary = baseSalary;
            Birthday = birthday;
            Department = department;
        }

        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }

        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }
}
