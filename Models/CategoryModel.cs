using System;
using System.Collections.Generic;

namespace SampleCoreWebApp.Models;

public partial class CategoryModel
{
    public Guid CategoryGuid { get; set; }

    public string CategoryName { get; set; } = null!;

    public string CategoryColor { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public int CreatedBy { get; set; }
}
