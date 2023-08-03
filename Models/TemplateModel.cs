using System;
using System.Collections.Generic;

namespace SampleCoreWebApp.Models;

public partial class TemplateModel
{
    public Guid TemplateId { get; set; }

    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Criteria { get; set; } = null!;

    public string Format { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public int CreatedBy { get; set; }

    public string DataCount { get; set; } = null!;
}
