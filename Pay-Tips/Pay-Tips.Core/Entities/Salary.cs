using Pay_Tips.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pay_Tips.Core.Entities
{
    public class Salary:IEntity<int>
    {
        public int Id { get; set; }
        public DateTime MonthName { get; set; }
        public double BasicAmount { get; set; }
        public double? ClaimAmount { get; set; }
        public double GrossAmount 
        {
            get => this.GrossAmount;
            set => this.GrossAmount = this.BasicAmount + this.ClaimAmount ?? this.BasicAmount;
        }
        public int EmployeeId { get; set; }
        
        public virtual Employee Employee { get; set; }
    }
}
