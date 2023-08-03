using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SampleCoreWebApp.Migrations
{
    /// <inheritdoc />
    public partial class DepartmentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AreaCodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaCodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryModel",
                columns: table => new
                {
                    category_guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    category_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    category_color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryModel", x => x.category_guid);
                });

            migrationBuilder.CreateTable(
                name: "CommonNames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommonNames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompanyCodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyCodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DataPoints",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataPoints", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gender_Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LastNames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LastNames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MalesFirstName",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MalesFirstName", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Names",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FemaleFirstNames = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Names", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrgabsenceTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrgabsenceType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrgabsenceTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StateAreaCodes",
                columns: table => new
                {
                    StateAreaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AreaCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateAreaCodes", x => x.StateAreaId);
                });

            migrationBuilder.CreateTable(
                name: "StateCodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateCodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TemplateCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Template_Id_FK = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Category_Id_FK = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Organisation_Id = table.Column<int>(type: "int", nullable: false),
                    Created_On = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created_By = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemplateCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TemplateModel",
                columns: table => new
                {
                    Template_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "ntext", nullable: false),
                    Criteria = table.Column<string>(type: "ntext", nullable: false),
                    Format = table.Column<string>(type: "ntext", nullable: false),
                    Created_On = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created_By = table.Column<int>(type: "int", nullable: false),
                    DataCount = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "(N'')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemplateModel", x => x.Template_Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AreaCodes");

            migrationBuilder.DropTable(
                name: "CategoryModel");

            migrationBuilder.DropTable(
                name: "CommonNames");

            migrationBuilder.DropTable(
                name: "CompanyCodes");

            migrationBuilder.DropTable(
                name: "DataPoints");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "LastNames");

            migrationBuilder.DropTable(
                name: "MalesFirstName");

            migrationBuilder.DropTable(
                name: "Names");

            migrationBuilder.DropTable(
                name: "OrgabsenceTypes");

            migrationBuilder.DropTable(
                name: "StateAreaCodes");

            migrationBuilder.DropTable(
                name: "StateCodes");

            migrationBuilder.DropTable(
                name: "TemplateCategory");

            migrationBuilder.DropTable(
                name: "TemplateModel");
        }
    }
}
