using System;
using System.Collections.Generic;

namespace SampleCoreWebApp.Models;

public partial class StateAreaCode
{
    public int StateAreaId { get; set; }

    public string StateCode { get; set; } = null!;

    public string AreaCode { get; set; } = null!;
}
