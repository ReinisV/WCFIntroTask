using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatsDataAccess
{
    using System.Data.Entity;
    public class CatsDbContext: DbContext
    {
        public DbSet<Cat> Cats { get; set; }
    }
}
