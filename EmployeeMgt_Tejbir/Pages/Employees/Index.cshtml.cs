using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EmployeeMgt_Tejbir.BussyLayer;
using EmployeeMgt_Tejbir.Data;

namespace EmployeeMgt_Tejbir.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly EmployeeMgt_Tejbir.Data.ApplicationDbContext _context;

        public IndexModel(EmployeeMgt_Tejbir.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; }

        public async Task OnGetAsync()
        {
            Employee = await _context.Employees
                .Include(e => e.Department)
                .Include(e => e.Job).ToListAsync();
        }
    }
}
