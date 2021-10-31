
using Microsoft.EntityFrameworkCore;


namespace Persistence
{
    public class MainContext:DbContext
    {
        //public DbSet<Debt> Debts { get; set; }


        public MainContext(DbContextOptions<MainContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new DebtMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}


