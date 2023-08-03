using System;
using System.Collections.Generic;

namespace SampleCoreWebApp.Models;

public partial class DataPoint
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? ParentId { get; set; }

    public string? Type { get; set; }
}
