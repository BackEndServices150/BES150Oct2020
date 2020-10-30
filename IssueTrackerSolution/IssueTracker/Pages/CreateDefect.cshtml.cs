using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IssueTracker.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IssueTracker.Pages
{
    public class CreateDefectModel : PageModel
    {
        private readonly IssuesDataContext _context;

        public CreateDefectModel(IssuesDataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Defect Defect { get; set; }
        public void OnGet()
        {
            
        }

        public async Task<ActionResult> OnPostAsync()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            } else
            {
                Defect.Created = DateTime.Now;
                _context.Defects.Add(Defect);
                await _context.SaveChangesAsync();
                TempData["flash"] = $"Added Defect {Defect.Description} Successfully";
                return RedirectToPage("Tracking");
            }
        }
    }
}
