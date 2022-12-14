using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMVC.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public ICollection<SalesRecord> Salles { get; set; } = new List<SalesRecord>();

        public Seller()
        {
        }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }


        public void AddSale(SalesRecord sr)
        {
            Salles.Add(sr);
        }
        public void RemoveSale(SalesRecord sr)
        {
            Salles.Remove(sr);
        }
        public double TotalSales(DateTime initial, DateTime final) {

            return Salles.Where(x => x.Date >= initial && x.Date <= final).Sum(x => x.Amount);
        }

    }
}
