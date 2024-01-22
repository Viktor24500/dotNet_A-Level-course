using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Catalog.Host.Data
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDBContext>
    {
        private static string? _connectionString;

        public AppDBContext CreateDbContext()
        {
            return CreateDbContext(null);
        }
        public AppDBContext CreateDbContext(string[] args)
        {
            if (string.IsNullOrEmpty(_connectionString))
            {
                LoadConnectionString();
            }

            //choose context
            var builder = new DbContextOptionsBuilder<AppDBContext>();

            //choose sql provider
            builder.UseSqlServer(_connectionString);

            return new AppDBContext(builder.Options);
        }

        private static void LoadConnectionString()
        {
            var builder = new ConfigurationBuilder();
            builder
                .AddJsonFile("appsettings.json", optional: false)
                .AddUserSecrets<AppDbContextFactory>();

            var configuration = builder.Build();

            _connectionString = configuration.GetConnectionString("WebApiDatabase");
        }
    }
}
