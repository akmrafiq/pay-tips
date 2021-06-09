using Pay_Tips.Core.Repositories;
using Pay_Tips.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pay_Tips.Core.UnitOfWorks
{
    public interface IPayUnitOfWork:IUnitOfWork
    {
        IEmployeeRepository EmployeeRepository { get; set; }
        IPaymentClaimRepository PaymentClaimRepository { get; set; }
        ISalaryRepository SalaryRepository { get; set; }
    }
}
