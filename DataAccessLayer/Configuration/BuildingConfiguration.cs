using DataAccessLayer.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.Configuration
{
    public class BuildingConfiguration : IEntityTypeConfiguration<Building>
    {
        public void Configure(EntityTypeBuilder<Building> builder)
        {
            // Insert 100 Building
            for (Int16 i = 1; i < 101; i++)
            {
                builder.HasData(
                    new Building { Id = i, Name = "Building_Name_" + i, Location = "Location_" + i }
                    );
            }
        }
    }
}
