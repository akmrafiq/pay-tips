using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pay_Tips.Core.Entities;
using Pay_Tips.Core.Services;

namespace Pay_Tips.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [HttpGet]
        public virtual async Task<IEnumerable<Employee>> Get()
        {
            return await _employeeService.Get();
        }
        [HttpGet("GetById/{id}")]
        public Employee GetById(int id)
        {
            var data = _employeeService.GetEmployee(id);
            return data;
        }

        [HttpDelete]
        public virtual async Task Delete(int id)
        {
            await _employeeService.DeleteAsync(id);
        }
    }
}