using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Portfolio_NetCore_BL;
using System.IO;

namespace Portfolio_NetCore_DAL
{
    public class APIDomain_DbContext: DbContext
    {
        public APIDomain_DbContext(DbContextOptions<APIDomain_DbContext> options) : base(options) { }
        public virtual DbSet<Plant> Plants { get; set; }
        public virtual DbSet<PlantType> PlantTypes { get; set; }
        public virtual DbSet<Season> Seasons { get; set; }
    }

    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<APIDomain_DbContext>
    {
        public APIDomain_DbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile(@Directory.GetCurrentDirectory() + "/../MyCookingMaster.API/appsettings.json").Build();
            var builder = new DbContextOptionsBuilder<APIDomain_DbContext>();
            var connectionString = configuration.GetConnectionString("DatabaseConnection");
            builder.UseSqlServer(connectionString);
            return new APIDomain_DbContext(builder.Options);
        }
    }
}