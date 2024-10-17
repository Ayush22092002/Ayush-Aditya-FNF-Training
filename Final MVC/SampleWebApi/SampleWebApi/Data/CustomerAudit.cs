using System;
using System.Collections.Generic;

namespace SampleWebApi.Data;

public partial class CustomerAudit
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;
}
