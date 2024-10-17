using System;
using System.Collections.Generic;

namespace SampleWebApi.Data;

public partial class EmpTable
{
    public int EmpId { get; set; }

    public string EmpName { get; set; } = null!;

    public string EmpAddress { get; set; } = null!;

    public decimal EmpSalary { get; set; }

    public int? DepId { get; set; }

    public virtual DeptTable? Dep { get; set; }
}
