using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EmployeeMgt_Tejbir.BussyLayer;
using EmployeeMgt_Tejbir.Data;

namespace EmployeeMgt_Tejbir.Pages.Departments
{
    public class DetailsModel : PageModel
    {
        private readonly EmployeeMgt_Tejbir.Data.ApplicationDbContext _context;

        public DetailsModel(EmployeeMgt_Tejbir.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Department Department { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Department = await _context.Departments.FirstOrDefaultAsync(m => m.ID == id);

            if (Department == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
