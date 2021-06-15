﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PropertySales.Data;
using PropertySales.Models;

namespace PropertySales.Pages.BuyPropertyViews
{
    public class CreateModel : PageModel
    {
        private readonly PropertySales.Data.PropertySalesContext _context;

        public CreateModel(PropertySales.Data.PropertySalesContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public BuyProperty BuyProperty { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.BuyProperty.Add(BuyProperty);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
