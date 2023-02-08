using DataAccessLayer.DataContext;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Model;
using GlobalEntity;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories
{
    public class ReadingRepository :GenericRepository<Reading>, IReadingRepository
    {
        protected readonly S3DbContext _context;        
        public ReadingRepository(S3DbContext context) : base(context)
        {
            _context = context;
        }
        public async Task<List<Reading>> GetDataByCondition(GetSearchReadingQuery query)
        {
            try
            {
                if (!string.IsNullOrEmpty(query.StartDateRange) && !string.IsNullOrEmpty(query.EndDateRange))
                {
                    var result = _context.Readings.Where((u) => u.BuildingId == (query.BuildingId > 0 ? query.BuildingId : u.BuildingId)
                            && u.ObjectId == (query.ObjectId > 0 ? query.ObjectId : u.ObjectId)
                            && u.DataFieldId == (query.DataFieldId > 0 ? query.DataFieldId : u.DataFieldId)
                            && (u.Timestamp.Date >= Convert.ToDateTime(query.StartDateRange).Date && u.Timestamp.Date <= Convert.ToDateTime(query.EndDateRange).Date))
                        .Select(u => new Reading()
                        {
                            Id = u.Id,
                            BuildingId = u.BuildingId,
                            DataFieldId = u.DataFieldId,
                            ObjectId = u.ObjectId,
                            Value = u.Value,
                            Timestamp = u.Timestamp
                        });
                    return await result.ToListAsync();
                }
                else
                {
                    var result = _context.Readings.Where((u) => u.BuildingId == (query.BuildingId > 0 ? query.BuildingId : u.BuildingId)
                            && u.ObjectId == (query.ObjectId > 0 ? query.ObjectId : u.ObjectId)
                            && u.DataFieldId == (query.DataFieldId > 0 ? query.DataFieldId : u.DataFieldId))
                    .Select(u => new Reading()
                    {
                        Id = u.Id,
                        BuildingId = u.BuildingId,
                        DataFieldId = u.DataFieldId,
                        ObjectId = u.ObjectId,
                        Value = u.Value,
                        Timestamp = u.Timestamp
                    });
                    return await result.ToListAsync();
                }
                //if (!string.IsNullOrEmpty(query.EndDateRange))
                //{
                //    result.Where((u) => u.Timestamp.Date <= Convert.ToDateTime(query.EndDateRange).Date);
                //}
                //result
                //    .Select(u => new Reading()
                //    {
                //        Id = u.Id,BuildingId=u.BuildingId,DataFieldId=u.DataFieldId,ObjectId=u.ObjectId,Value=u.Value,Timestamp=u.Timestamp
                //    });
                
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
