using Pay_Tips.Core.Contexts;
using Pay_Tips.Core.Repositories;
using Pay_Tips.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pay_Tips.Core.UnitOfWorks
{
    public class PayUnitOfWork : UnitOfWork, IPayUnitOfWork
    {
        public IEmployeeRepository EmployeeRepository { get; set; }
        public IPaymentClaimRepository PaymentClaimRepository { get; set; }
        public ISalaryRepository SalaryRepository { get; set; }

        public PayUnitOfWork(
            PayContext payContext, 
            IEmployeeRepository employeeRepository, 
            ISalaryRepository salaryRepository,
            IPaymentClaimRepository paymentClaimRepository
            ): base(payContext)
        {
            EmployeeRepository = employeeRepository;
            SalaryRepository = salaryRepository;
            PaymentClaimRepository = paymentClaimRepository;
        }
    }
}
