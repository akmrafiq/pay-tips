using Pay_Tips.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pay_Tips.Core.Entities
{
    public class PaymentClaim:IEntity<int>
    {
        public int Id { get; set; }
        public string Heading { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public string FileInfo { get; set; }
        public string Status { get; set; }
        public int EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
