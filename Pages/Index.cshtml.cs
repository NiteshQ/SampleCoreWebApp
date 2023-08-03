using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SampleCoreWebApp.Models;

namespace SampleCoreWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly MockDatabaseContext _Context;
        public IndexModel(ILogger<IndexModel> logger, MockDatabaseContext context)
        {
            _logger = logger;
            _Context = context;
        }

        public void OnGet()
        {
            //_Context.Add<AreaCode>(new AreaCode() { AreaCode1 = "AreaCode1" });
            //_Context.SaveChanges();
            //var d = new Department()
            //{ Description = "IT Infra", Name = "IT Infrastructure" };
            //_Context.Add<Department>(d);
            //_Context.SaveChanges();
            //_Context.Add<CommonName>(new CommonName() { Name = "John Smith", DepartmentId = 1 });
            //_Context.SaveChanges();
            ViewData["Department"] = _Context.Departments.Where(d => d.Id == 1).SingleOrDefault()?.DepartmentHead?.Name;
        }
    }
}