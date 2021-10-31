
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



//
//var settings = MongoClientSettings.FromConnectionString("mongodb+srv://Dsco:<password>@cluster0.eq1vt.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
//var client = new MongoClient(settings);
//var database = client.GetDatabase("test");
