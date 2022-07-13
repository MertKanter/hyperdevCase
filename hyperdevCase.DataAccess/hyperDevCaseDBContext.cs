using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hyperdevCase.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace hyperdevCase.DataAccess
{
    public class hyperDevCaseDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //optionsBuilder.UseSqlServer("Server=MERTPC; Database=hyperDevCaseDb; Trusted_Connection=True;");
            optionsBuilder.UseNpgsql("Server=localhost; port=5432; Database=hyperDevCaseDb; User Id=postgres; password = mert346534;");
        }

        public DbSet<Sirket> Sirketler { get; set; }
        public DbSet<Departman> Departmanlar { get; set; }
        public DbSet<AltDepartman> AltDepartmanlar { get; set; }
    }
}
