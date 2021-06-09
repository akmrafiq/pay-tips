using System;
using System.Collections.Generic;
using System.Text;

namespace Pay_Tips.Data
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
