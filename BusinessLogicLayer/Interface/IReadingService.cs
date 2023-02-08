using GlobalEntity;

namespace BusinessLogicLayer.Interface
{
    public interface IReadingService
    {
        Task<List<ReadingModel>> GetReadings(GetSearchReadingQuery query);
    }
}
