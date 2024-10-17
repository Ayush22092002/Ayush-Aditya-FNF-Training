using System;
using System.Collections.Generic;

namespace SampleWebApi.Data;

public partial class EmployeeTable
{
    public int EmpId { get; set; }

    public string EmpName { get; set; } = null!;

    public string EmpAddress { get; set; } = null!;

    public int EmpSalary { get; set; }

    public string EmpImage { get; set; } = null!;
}
