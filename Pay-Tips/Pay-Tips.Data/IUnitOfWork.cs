using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Pay_Tips.Data
{
    public interface IUnitOfWork
    {
        void Save();
        Task SaveAsync();
    }
}
