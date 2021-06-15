using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PropertySales.Data;
using PropertySales.Models;

namespace PropertySales.Pages.ReachUsViews
{
    public class DeleteModel : PageModel
    {
        private readonly PropertySales.Data.PropertySalesContext _context;

        public DeleteModel(PropertySales.Data.PropertySalesContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ReachUs ReachUs { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ReachUs = await _context.ReachUs.FirstOrDefaultAsync(m => m.id == id);

            if (ReachUs == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ReachUs = await _context.ReachUs.FindAsync(id);

            if (ReachUs != null)
            {
                _context.ReachUs.Remove(ReachUs);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
