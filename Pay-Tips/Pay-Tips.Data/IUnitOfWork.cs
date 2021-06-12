using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pay_Tips.Data
{
    public interface IUnitOfWork
    {
        void Save();
        Task SaveAsync();
    }
}
