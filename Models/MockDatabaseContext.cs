using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SampleCoreWebApp.Models;

public partial class MockDatabaseContext : DbContext
{
    public MockDatabaseContext()
    {
    }

    public MockDatabaseContext(DbContextOptions<MockDatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AreaCode> AreaCodes { get; set; }

    public virtual DbSet<CategoryModel> CategoryModels { get; set; }

    public virtual DbSet<CommonName> CommonNames { get; set; }

    public virtual DbSet<CompanyCode> CompanyCodes { get; set; }

    public virtual DbSet<DataPoint> DataPoints { get; set; }

    public virtual DbSet<Gender> Genders { get; set; }

    public virtual DbSet<LastName> LastNames { get; set; }

    public virtual DbSet<MalesFirstName> MalesFirstNames { get; set; }

    public virtual DbSet<Name> Names { get; set; }

    public virtual DbSet<OrgabsenceType> OrgabsenceTypes { get; set; }

    public virtual DbSet<StateAreaCode> StateAreaCodes { get; set; }

    public virtual DbSet<StateCode> StateCodes { get; set; }

    public virtual DbSet<TemplateCategory> TemplateCategories { get; set; }

    public virtual DbSet<TemplateModel> TemplateModels { get; set; }
    public virtual DbSet<Department> Departments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //optionsBuilder.UseSqlServer("name=ConnectionStrings:MockDB");
        
    }
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AreaCode>(entity =>
        {
            entity.Property(e => e.AreaCode1).HasColumnName("AreaCode");
        });

        modelBuilder.Entity<CategoryModel>(entity =>
        {
            entity.HasKey(e => e.CategoryGuid);

            entity.ToTable("CategoryModel");

            entity.Property(e => e.CategoryGuid)
                .ValueGeneratedNever()
                .HasColumnName("category_guid");
            entity.Property(e => e.CategoryColor).HasColumnName("category_color");
            entity.Property(e => e.CategoryName).HasColumnName("category_name");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.CreatedDate).HasColumnName("created_date");
        });

        modelBuilder.Entity<CompanyCode>(entity =>
        {
            entity.Property(e => e.CompanyCode1).HasColumnName("CompanyCode");
        });

        modelBuilder.Entity<DataPoint>(entity =>
        {
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<Gender>(entity =>
        {
            entity.ToTable("Gender");

            entity.Property(e => e.GenderType).HasColumnName("Gender_Type");
        });

        modelBuilder.Entity<MalesFirstName>(entity =>
        {
            entity.ToTable("MalesFirstName");
        });

        modelBuilder.Entity<OrgabsenceType>(entity =>
        {
            entity.Property(e => e.OrgabsenceType1).HasColumnName("OrgabsenceType");
        });

        modelBuilder.Entity<StateAreaCode>(entity =>
        {
            entity.HasKey(e => e.StateAreaId);
        });

        modelBuilder.Entity<StateCode>(entity =>
        {
            entity.Property(e => e.StateCode1).HasColumnName("StateCode");
        });

        modelBuilder.Entity<TemplateCategory>(entity =>
        {
            entity.ToTable("TemplateCategory");

            entity.Property(e => e.CategoryIdFk).HasColumnName("Category_Id_FK");
            entity.Property(e => e.CreatedBy).HasColumnName("Created_By");
            entity.Property(e => e.CreatedOn).HasColumnName("Created_On");
            entity.Property(e => e.OrganisationId).HasColumnName("Organisation_Id");
            entity.Property(e => e.TemplateIdFk).HasColumnName("Template_Id_FK");
        });

        modelBuilder.Entity<TemplateModel>(entity =>
        {
            entity.HasKey(e => e.TemplateId);

            entity.ToTable("TemplateModel");

            entity.Property(e => e.TemplateId)
                .ValueGeneratedNever()
                .HasColumnName("Template_Id");
            entity.Property(e => e.CreatedBy).HasColumnName("Created_By");
            entity.Property(e => e.CreatedOn).HasColumnName("Created_On");
            entity.Property(e => e.Criteria).HasColumnType("ntext");
            entity.Property(e => e.DataCount).HasDefaultValueSql("(N'')");
            entity.Property(e => e.Format).HasColumnType("ntext");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Name).HasColumnType("ntext");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
