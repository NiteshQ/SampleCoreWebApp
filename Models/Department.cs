using System.ComponentModel.DataAnnotations;

namespace SampleCoreWebApp.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        [StringLength(200)]
        public string Description { get; set; } = string.Empty;
        public CommonName DepartmentHead { get; set; } = null!;
    }
}
