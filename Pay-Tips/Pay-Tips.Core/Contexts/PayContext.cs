using Microsoft.EntityFrameworkCore;
using Pay_Tips.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pay_Tips.Core.Contexts
{
    public class PayContext:DbContext
    {
        private string _connectionString;
        private string _migrationAssemblyName;

        public PayContext(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseSqlServer(
                    _connectionString,
                    m => m.MigrationsAssembly(_migrationAssemblyName));
            }

            base.OnConfiguring(dbContextOptionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Salary>()
                .HasOne(s => s.Employee)
                .WithMany(s => s.Salaries)
                .HasForeignKey(s => s.EmployeeId);
            
            builder.Entity<PaymentClaim>()
                .HasOne(p => p.Employee)
                .WithMany(p => p.PaymentClaims)
                .HasForeignKey(p => p.EmployeeId);

            builder.Entity<Employee>()
                .HasIndex("FirstName, LastName, Designation, Department, Email, Phone");

            builder.Entity<Salary>()
                .HasIndex("MonthName, BaiscAmount, ClaimAmount, GrossAmount");

            base.OnModelCreating(builder);
        }


        DbSet<Employee> Employee { get; set; }
        DbSet<PaymentClaim> PaymentClaim { get; set; }
        DbSet<Salary> Salary { get; set; }
    }
}
