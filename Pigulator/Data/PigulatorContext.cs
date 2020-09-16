using Pigulator.Models;
using Microsoft.EntityFrameworkCore;


namespace Pigulator.Data
{
    public class PigulatorContext : DbContext
    {
        public PigulatorContext (DbContextOptions<PigulatorContext> options)
            : base(options)
        {

        }

        public DbSet<Pigs> Pigulator { get; set; }
    }
}
