using Microsoft.EntityFrameworkCore;
using RecapProjecr1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapProjecr1
{
    public class NorthWindContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
