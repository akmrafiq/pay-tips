using Pay_Tips.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pay_Tips.Core.Entities
{
    public class User: IEntity<int>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public TimeSpan Age
        {
            get => this.Age;
            set => this.Age = DateTime.Today - DateOfBirth ?? TimeSpan.Zero; 
        }
        public Gender? Sex { get; set; }
        public MaritalStatus? MaritalStatus { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
