using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PropertySales.Models;

namespace PropertySales.Data
{
    public class PropertySalesContext : DbContext
    {
        public PropertySalesContext (DbContextOptions<PropertySalesContext> options)
            : base(options)
        {
        }

        public DbSet<PropertySales.Models.Property> Property { get; set; }

        public DbSet<PropertySales.Models.BuyProperty> BuyProperty { get; set; }

        public DbSet<PropertySales.Models.ReachUs> ReachUs { get; set; }
    }
}
