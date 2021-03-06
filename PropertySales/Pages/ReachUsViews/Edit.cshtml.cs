using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PropertySales.Data;
using PropertySales.Models;

namespace PropertySales.Pages.ReachUsViews
{
    public class EditModel : PageModel
    {
        private readonly PropertySales.Data.PropertySalesContext _context;

        public EditModel(PropertySales.Data.PropertySalesContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ReachUs).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReachUsExists(ReachUs.id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ReachUsExists(int id)
        {
            return _context.ReachUs.Any(e => e.id == id);
        }
    }
}
