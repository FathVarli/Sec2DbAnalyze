using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Sec2DbAnalyze.AppSettings;
using Sec2DbAnalyze.Domain.Concrete;

namespace Sec2DbAnalyze.Persistence.Context
{
    public class PartitionDbContext : DbContext
    {
        private readonly AppSetting _appSetting;

        public PartitionDbContext(AppSetting appSetting)
        {
            _appSetting = appSetting;
        }
        
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<UserPartition> Users { get; set; }
        public DbSet<IdentityPartition> Identities { get; set; }
        public DbSet<Log> Logs { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseNpgsql(_appSetting.PostgresqlSettings.PartitionConnectionString)
                .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()))
                .EnableSensitiveDataLogging();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}