using DataAccessLayer.Configuration;
using DataAccessLayer.Model;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.DataContext
{
    public class S3DbContext: DbContext
    {
        public S3DbContext(DbContextOptions<S3DbContext> options) :base(options)
        {

            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<S3DbContext, EF6Console.Migrations.Configuration>());
        }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<DataAccessLayer.Model.Object> Objects { get; set; }
        public DbSet<DataField> DataFields { get; set; }
        public DbSet<Reading> Readings { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BuildingConfiguration());
            modelBuilder.ApplyConfiguration(new DataFieldConfiguration());
            modelBuilder.ApplyConfiguration(new ObjectConfiguration());
            //modelBuilder.ApplyConfiguration(new ReadingConfiguration());
        }
    }
}
