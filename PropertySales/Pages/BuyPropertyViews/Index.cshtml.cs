using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PropertySales.Data;
using PropertySales.Models;

namespace PropertySales.Pages.BuyPropertyViews
{
    public class IndexModel : PageModel
    {
        private readonly PropertySales.Data.PropertySalesContext _context;

        public IndexModel(PropertySales.Data.PropertySalesContext context)
        {
            _context = context;
        }

        public IList<BuyProperty> BuyProperty { get;set; }

        public async Task OnGetAsync()
        {
            BuyProperty = await _context.BuyProperty.ToListAsync();
        }
    }
}
