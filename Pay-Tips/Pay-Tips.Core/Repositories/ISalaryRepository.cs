using Pay_Tips.Core.Contexts;
using Pay_Tips.Core.Entities;
using Pay_Tips.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pay_Tips.Core.Repositories
{
    public interface ISalaryRepository:IRepository<Salary, int, PayContext>
    {
    }
}
