using DataAccessLayer.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.Configuration
{
    public class ReadingConfiguration : IEntityTypeConfiguration<Reading>
    {
        public void Configure(EntityTypeBuilder<Reading> builder)
        {
            DateTime startTime = DateTime.Parse("2022-01-01 12:00:00 am");
            
            for (int i = 1; i < 101; i++)//Building 100
            {
                for (int day = 0; day < 731; day++)// 2 Years 730 day
                {
                    for (int j = 1; j < 3; j++)//DataField 2 row
                    {
                        for (int k = 1; k < 6; k++)//Object 5 row
                        {
                            for (int l = 1; l < 1441; l++) // 1440 per day
                            {
                                DateTime End = startTime.AddMinutes(1);
                                int pid = l + k + j + day + i;                                
                                Random rand = new Random(100);
                                
                                builder.HasData(
                        new Reading { Id = pid, BuildingId = (Int16)i, DataFieldId = (sbyte)j, ObjectId = (sbyte)k, Value = rand.Next(), Timestamp = End }
                        );
                            }

                        }
                    }
                }
            }
        }       
    }
    
}
