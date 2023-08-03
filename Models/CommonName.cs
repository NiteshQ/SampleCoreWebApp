using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Transactions;

namespace SampleCoreWebApp.Models;

public partial class CommonName
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;
    public Department Department { get; set; } = null!;
    public int DepartmentId { get; set; }
}
public class CommonNameConfiguration : IEntityTypeConfiguration<CommonName>
{
    public void Configure(EntityTypeBuilder<CommonName> builder)
    {
        builder.HasOne(x => x.Department)
            .WithOne(x => x.DepartmentHead).HasForeignKey<CommonName>(x => x.DepartmentId);
    }
}
