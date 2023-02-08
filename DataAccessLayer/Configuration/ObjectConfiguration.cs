using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.Configuration
{
    public class ObjectConfiguration : IEntityTypeConfiguration<Model.Object>
    {
        public void Configure(EntityTypeBuilder<Model.Object> builder)
        {
            //5 data insert into Object Table
            builder.HasData(
                    new Model.Object { Id = 1, Name = "Chiller" },
                    new Model.Object { Id = 2, Name = "Chilled Water Pump" },
                    new Model.Object { Id = 3, Name = "Condenser Water Pump" },
                    new Model.Object { Id = 4, Name = "Cooling Tower" },
                    new Model.Object { Id = 5, Name = "System" }
                    );
        }
    }
}
