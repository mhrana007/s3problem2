using BusinessLogicLayer.Interface;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Model;
using GlobalEntity;

namespace BusinessLogicLayer.Services
{
    public class ReadingService : IReadingService
    {
        private readonly IReadingRepository _repository;
        public ReadingService(IReadingRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<ReadingModel>> GetReadings(GetSearchReadingQuery query)
        {

            try
            {
                List<ReadingModel> list = new List<ReadingModel>();
                List<Reading> result = await _repository.GetDataByCondition(query);
                result.ForEach(item => { list.Add(new ReadingModel() { 
                    Id = item.Id, BuildingId = item.BuildingId, ObjectId = item.ObjectId,DataFieldId=item.DataFieldId,Timestamp=item.Timestamp,Value=item.Value }); 
                });
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
