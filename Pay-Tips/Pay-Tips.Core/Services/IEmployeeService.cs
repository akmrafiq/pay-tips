﻿using Pay_Tips.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pay_Tips.Core.Services
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetEmployees(
          int pageIndex,
          int pageSize,
          string searchText,
          string sortText,
          out int total,
          out int totalFiltered);

        Employee GetEmployee(int id);
    }
}
