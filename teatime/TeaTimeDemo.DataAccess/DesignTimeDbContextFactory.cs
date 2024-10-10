using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace TeaTimeDemo.DataAccess.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

            // Use the same connection string and migration assembly as in the OnConfiguring method
            optionsBuilder.UseSqlite("Data Source=/home/yizaochen/codes/dotnet-tutorial/dotnet_learn/teatime/TeaTimeDemo.DataAccess/TeaTime.db",
                sqliteOptions => sqliteOptions.MigrationsAssembly("TeaTimeDemo.DataAccess"));

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
