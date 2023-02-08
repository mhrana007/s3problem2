using DataAccessLayer.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.Configuration
{
    public class DataFieldConfiguration : IEntityTypeConfiguration<DataField>
    {
        public void Configure(EntityTypeBuilder<DataField> builder)
        {
            // 2 data insert into DataField Table
            builder.HasData(
                    new DataField { Id = 1, Name = "Effiency" },
                    new DataField { Id = 2, Name = "Power" }
                    );
        }
    }
}
