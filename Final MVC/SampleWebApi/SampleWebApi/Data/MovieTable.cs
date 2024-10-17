using System;
using System.Collections.Generic;

namespace SampleWebApi.Data;

public partial class MovieTable
{
    public int MovieId { get; set; }

    public string MovieName { get; set; } = null!;

    public string MovieDescription { get; set; } = null!;

    public string MovieDirector { get; set; } = null!;

    public string MovieActor { get; set; } = null!;

    public int MovieRating { get; set; }
}
