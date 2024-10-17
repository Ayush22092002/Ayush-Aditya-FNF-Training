using System;
using System.Collections.Generic;

namespace SampleWebApi.Data;

public partial class BookTable
{
    public int BookId { get; set; }

    public string Title { get; set; } = null!;

    public string Author { get; set; } = null!;

    public int Price { get; set; }
}
