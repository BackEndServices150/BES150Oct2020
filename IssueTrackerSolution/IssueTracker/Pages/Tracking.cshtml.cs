using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IssueTracker.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace IssueTracker.Pages
{
    public class TrackingModel : PageModel
    {
        private readonly IssuesDataContext _context;

        public TrackingModel(IssuesDataContext context)
        {
            _context = context;
        }
        public List<Defect> Defects { get; set; }
        public async Task OnGetAsync()
        {
            Defects = await _context.Defects
                .OrderByDescending(d => d.Created)
                .ToListAsync();
        }
    }
}
