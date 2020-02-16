using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    public class VTContext : DbContext
    {
        public VTContext():base("urunConnection")
        {
            Database.SetInitializer(new DataInitializer());
        }

        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Urun> Urunler { get; set; }
    }
}
