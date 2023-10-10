using System;
using System.Linq;
using SalesWebMVC.Models;
using SalesWebMVC.Models.Enums;

namespace SalesWebMVC.Data
{
    public class SeedingService
    {
        private SalesWebMVCContext _context;

        public SeedingService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return; // O banco já está populado.
            }

            Department d1 = new Department(1, "Eletrônicos");
            Department d2 = new Department(2, "Eletrodomésticos");
            Department d3 = new Department(3, "Telefonia");
            Department d4 = new Department(4, "Cama, Mesa e Banho");

            Seller s1 = new Seller(1, "João", "joao@gmail.com", 1000.0, new DateTime(1987, 01, 23), d1);
            Seller s2 = new Seller(2, "Maria", "maria@gmail.com", 2000.0, new DateTime(1990, 01, 23), d2);
            Seller s3 = new Seller(3, "Pedro", "pedro@gmail.com", 3000.0, new DateTime(1993, 01, 23), d3);
            Seller s4 = new Seller(4, "Daniela", "daniela@gmail.com", 4000.0, new DateTime(1996, 01, 23), d4);

            SalesRecord sr1 = new SalesRecord(1, new DateTime(2022,01,01), 5000.0, SaleStatus.Billed, s1);
            SalesRecord sr2 = new SalesRecord(2, new DateTime(2022, 02, 01), 10000.0, SaleStatus.Billed, s2);
            SalesRecord sr3 = new SalesRecord(3, new DateTime(2022, 03, 01), 15000.0, SaleStatus.Billed, s3);
            SalesRecord sr4 = new SalesRecord(4, new DateTime(2022, 04, 01), 20000.0, SaleStatus.Billed, s4);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4);
            _context.SalesRecord.AddRange(sr1, sr2, sr3, sr4);

            _context.SaveChanges();
        }
    }
}
