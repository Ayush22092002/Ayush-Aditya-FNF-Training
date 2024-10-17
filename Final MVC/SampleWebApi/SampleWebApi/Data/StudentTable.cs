using System;
using System.Collections.Generic;

namespace SampleWebApi.Data;

public partial class StudentTable
{
    public int StudentId { get; set; }

    public string StudentName { get; set; } = null!;

    public string StudentEmail { get; set; } = null!;

    public long ContactNo { get; set; }
}
