using System;
using System.Collections.Generic;

namespace SampleWebApi.Data;

public partial class Customer
{
    public int Cstid { get; set; }

    public string Cstname { get; set; } = null!;

    public string Cstaddress { get; set; } = null!;

    public DateOnly? Billdate { get; set; }

    public decimal? Billamount { get; set; }
}
