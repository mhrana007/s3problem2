using DataAccessLayer.Model;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.DataContext
{
    public class S3DbContext: DbContext
    {
        public S3DbContext(DbContextOptions<S3DbContext> options) :base(options)
        {
        }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<DataAccessLayer.Model.Object> Objects { get; set; }
        public DbSet<DataField> DataFields { get; set; }
        public DbSet<Reading> Readings { get; set; }
    }
}
