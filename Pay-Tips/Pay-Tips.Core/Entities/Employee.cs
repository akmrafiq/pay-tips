using Pay_Tips.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pay_Tips.Core.Entities
{
    public class Employee : User, IEntity<int>
    {
        public Designation Designation { get; set; }
        public Department? Department { get; set; }

        public IList<Salary> Salaries { get; set; }
        public IList<PaymentClaim> PaymentClaims { get; set; }
    }
}
