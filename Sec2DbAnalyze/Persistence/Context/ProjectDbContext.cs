using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Sec2DbAnalyze.AppSettings;
using Sec2DbAnalyze.Domain.Abstract;
using Sec2DbAnalyze.Domain.Concrete;

namespace Sec2DbAnalyze.Persistence.Context
{
    public class ProjectDbContext : DbContext
    {
        
        private readonly AppSetting _appSetting;

        public ProjectDbContext(AppSetting appSetting)
        {
            _appSetting = appSetting;
            ChangeTracker.LazyLoadingEnabled = false;
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<User> Users { get; set; }
        //public DbSet<UserPartition> UserPartitions { get; set; }
        //public DbSet<IdentityPartition> IdentityPartitions { get; set; }
        public DbSet<Identity> Identities { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<UserSection> UserSections { get; set; }
        public DbSet<IdentitySection> IdentitySections { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseNpgsql(_appSetting.PostgresqlSettings.ConnectionString , x=> x.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery));
                // .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()))
                // .EnableSensitiveDataLogging();

            base.OnConfiguring(optionsBuilder);
        }

        // public override int SaveChanges()
        // {
        //     this.OnBeforeSaving();
        //
        //     return base.SaveChanges();
        // }
        //
        // public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        // {
        //     this.OnBeforeSaving();
        //
        //     return base.SaveChangesAsync(cancellationToken);
        // }
        //
        // public override int SaveChanges(bool acceptAllChangesOnSuccess)
        // {
        //     this.OnBeforeSaving();
        //
        //     return base.SaveChanges(acceptAllChangesOnSuccess);
        // }
        //
        // public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess,
        //     CancellationToken cancellationToken = default)
        // {
        //     this.OnBeforeSaving();
        //
        //     return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        // }
        //
        // private void OnBeforeSaving()
        // {
        //     foreach (var entry in this.ChangeTracker.Entries<IAuditEntity>())
        //     {
        //         if (entry.State != EntityState.Deleted)
        //         {
        //             continue;
        //         }
        //
        //         entry.CurrentValues[nameof(IAuditEntity.IsDeleted)] = true;
        //         entry.State = EntityState.Modified;
        //     }
        //
        //
        //     foreach (var entry in this.ChangeTracker.Entries<IAuditEntity>())
        //     {
        //         if (entry.State == EntityState.Added)
        //         {
        //             entry.CurrentValues[nameof(IAuditEntity.CreatedDate)] = DateTime.Now;
        //             entry.CurrentValues[nameof(IAuditEntity.IsDeleted)] = false;
        //         }
        //     }
        //
        //     foreach (var entry in this.ChangeTracker.Entries<IAuditEntity>())
        //     {
        //         if (entry.State == EntityState.Modified)
        //         {
        //             entry.CurrentValues[nameof(IAuditEntity.UpdatedDate)] = DateTime.UtcNow;
        //         }
        //     }
        // }
    }
}