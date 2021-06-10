using Pay_Tips.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using Pay_Tips.Core.UnitOfWorks;

namespace Pay_Tips.Core.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IPayUnitOfWork _payUnitOfWork;

        public EmployeeService(IPayUnitOfWork payUnitOfWork)
        {
            _payUnitOfWork = payUnitOfWork;
        }

        public Employee GetEmployee(int id)
        {
            return _payUnitOfWork.EmployeeRepository.GetById(id);
        }

        public virtual async Task<IEnumerable<Employee>> Get()
        
        {
           var data= await _payUnitOfWork.EmployeeRepository.GetAllAsync();
           return data;
        }
        public virtual async Task DeleteAsync(int id)
        {
           await _payUnitOfWork.EmployeeRepository.RemoveAsync(id);
        }

        public IEnumerable<Employee> GetEmployees(int pageIndex, int pageSize, string searchText, string sortText, out int total, out int totalFiltered)
        {
            throw new NotImplementedException();
        }
    }
}
