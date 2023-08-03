using System;
using System.Collections.Generic;

namespace SampleCoreWebApp.Models;

public partial class Gender
{
    public int Id { get; set; }

    public string GenderType { get; set; } = null!;
}
