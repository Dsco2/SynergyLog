using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Persistence
{
    public class PrincipalContextFactory:IDesignTimeDbContextFactory<MainContext>
    {
        public MainContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MainContext>();

            builder.UseSqlServer("Server=localhost;Database=FinApp;Trusted_Connection=True;",
                optionsBuilder => optionsBuilder
                    .MigrationsAssembly(typeof(MainContext)
                        .GetTypeInfo()
                        .Assembly
                        .GetName().Name)
            );
            return new MainContext(builder.Options);
        }
    }
}