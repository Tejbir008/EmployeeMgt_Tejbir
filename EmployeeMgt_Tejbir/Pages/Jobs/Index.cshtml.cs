using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EmployeeMgt_Tejbir.BussyLayer;
using EmployeeMgt_Tejbir.Data;

namespace EmployeeMgt_Tejbir.Pages.Jobs
{
    public class IndexModel : PageModel
    {
        private readonly EmployeeMgt_Tejbir.Data.ApplicationDbContext _context;

        public IndexModel(EmployeeMgt_Tejbir.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Job> Job { get;set; }

        public async Task OnGetAsync()
        {
            Job = await _context.Jobs.ToListAsync();
        }
    }
}
