using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Module4_ModuleHW.Configurations
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
            if (string.IsNullOrWhiteSpace(_connectionString))
            {
                LoadConnection();
            }

            var builder = new DbContextOptionsBuilder<AppDBContext>();
            builder.UseSqlServer(_connectionString);

            return new AppDBContext(builder.Options);
        }

        private static void LoadConnection()
        {
            var builder = new ConfigurationBuilder();

            builder
                .AddJsonFile("appsettings.json", optional: false)
                .AddUserSecrets<AppDbContextFactory>();

            var configuration = builder.Build();

            _connectionString = configuration.GetConnectionString(nameof(AppDBContext));
        }
    }
}
