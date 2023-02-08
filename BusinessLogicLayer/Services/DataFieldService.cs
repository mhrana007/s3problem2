using BusinessLogicLayer.Interface;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Model;
using GlobalEntity;

namespace BusinessLogicLayer.Services
{
    public class DataFieldService : IDataFieldService
    {
        private readonly IGenericRepository<DataField> _repository;
        public DataFieldService(IGenericRepository<DataField> repository)
        {
            _repository = repository;
        }
        public async Task<List<DataFieldModel>> GetDataFields()
        {

            try
            {
                List<DataFieldModel> list = new List<DataFieldModel>();
                var result = await _repository.GetAllAsync();
                result.ForEach(item => { list.Add(new DataFieldModel() { Id = item.Id, Name = item.Name }); });
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
