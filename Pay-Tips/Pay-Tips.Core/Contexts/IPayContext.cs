using Microsoft.EntityFrameworkCore;
using Pay_Tips.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pay_Tips.Core.Contexts
{
    public interface IPayContext
    {
        DbSet<Employee> Employee { get; set; }
        DbSet<PaymentClaim> PaymentClaim { get; set; }
        DbSet<Salary> Salary { get; set; }
    }
}
