using System;
using System.Collections.Generic;

namespace SampleWebApi.Data;

public partial class StockTable
{
    public int StockId { get; set; }

    public string StockName { get; set; } = null!;

    public string StockDescription { get; set; } = null!;

    public double UnitPrice { get; set; }
}
