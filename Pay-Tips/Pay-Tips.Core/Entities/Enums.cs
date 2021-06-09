using System;
using System.Collections.Generic;
using System.Text;

namespace Pay_Tips.Core.Entities
{
    public enum Gender
    {
        Male=1,
        Femaile
    }

    public enum MaritalStatus
    {
        Single=1,
        Married,
        Divorced
    }

    public enum Designation
    {
        CEO=1,
        CTO,
        Manager,
        DeputyManager,
        SeniorExecutive,
        Executive
    }

    public enum Department
    {
        Admin=1,
        HR,
        Finance,
        Marketing
    }
}
