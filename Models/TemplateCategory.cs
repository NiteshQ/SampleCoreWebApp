using System;
using System.Collections.Generic;

namespace SampleCoreWebApp.Models;

public partial class TemplateCategory
{
    public int Id { get; set; }

    public Guid TemplateIdFk { get; set; }

    public Guid CategoryIdFk { get; set; }

    public int OrganisationId { get; set; }

    public DateTime CreatedOn { get; set; }

    public int CreatedBy { get; set; }
}
