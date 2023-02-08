using BusinessLogicLayer.Interface;
using DataAccessLayer.Interfaces;
using GlobalEntity;
using Object = DataAccessLayer.Model.Object;

namespace BusinessLogicLayer.Services
{
    public class ObjectService : IObjectService
    {
        private readonly IGenericRepository<Object> _repository;
        public ObjectService(IGenericRepository<Object> repository)
        {
            _repository = repository;
        }
        public async Task<List<ObjectModel>> GetObjects()
        {

            try
            {
                List<ObjectModel> list = new List<ObjectModel>();
                var result = await _repository.GetAllAsync();
                result.ForEach(item => { list.Add(new ObjectModel() { Id = item.Id, Name = item.Name }); });
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
