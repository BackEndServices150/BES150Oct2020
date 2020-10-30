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
    public class DetailsModel : PageModel
    {
        private readonly IssuesDataContext _context;

        public DetailsModel(IssuesDataContext context)
        {
            _context = context;
        }

        public Defect Defect { get; set; }
        public string ErrorMessage { get; set; }

        public async Task OnGetAsync(int issueId)
        {
            Defect = await _context.Defects
                .SingleOrDefaultAsync(issue => issueId == issue.Id);

            if(Defect == null)
            {
                ErrorMessage = "No Issue with that Id";
            } 
        }

        public async Task<ActionResult> OnPostClose(int id)
        {
            var defects = await _context.Defects.SingleOrDefaultAsync(d => d.Id == id);
            defects.Closed = DateTime.Now;
            await _context.SaveChangesAsync();
            TempData["flash"] = $"Closed Defect {id}";
            return RedirectToPage("Tracking");
        }

        public async Task<ActionResult> OnPostOpen(int id)
        {
            var defects = await _context.Defects.SingleOrDefaultAsync(d => d.Id == id);
            defects.Closed = null;
            await _context.SaveChangesAsync();
            TempData["flash"] = $"Opened Defect {id}";
            return RedirectToPage("Tracking");
        }
    }
}
