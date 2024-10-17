using System;
using System.Collections.Generic;

namespace SampleWebApi.Data;

public partial class DeptTable
{
    public int DepId { get; set; }

    public string DeptName { get; set; } = null!;

    public virtual ICollection<EmpTable> EmpTables { get; set; } = new List<EmpTable>();
}
