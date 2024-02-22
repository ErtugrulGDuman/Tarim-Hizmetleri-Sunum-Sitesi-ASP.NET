using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionBuilder)
        {
            dbContextOptionBuilder.UseSqlServer("server=EGD\\SQLEXPRESS;databaese=DbNewOOPCore;integrated security=true;");
        }

    }
}
