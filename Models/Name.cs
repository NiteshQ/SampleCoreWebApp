using System;
using System.Collections.Generic;

namespace SampleCoreWebApp.Models;

public partial class Name
{
    public int Id { get; set; }

    public string FemaleFirstNames { get; set; } = null!;
}
