using DataAccessLayer.Model;
using GlobalEntity;

namespace DataAccessLayer.Interfaces
{
    public interface IReadingRepository :IGenericRepository<Reading>
    {
        Task<List<Reading>> GetDataByCondition(GetSearchReadingQuery query);
    }
}
