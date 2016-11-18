using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Data
{
    class Context:DbContext
    {
        public DbSet<Manufactures> Manuf { get; set; }
        public DbSet<Model> Mode { get; set; }
        public DbSet<Car> Cara { get; set; }
        public Context() : base("localsql")
        {
        }
    }
}
