using BusinessLogicLayer.Interface;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Model;
using GlobalEntity;

namespace BusinessLogicLayer.Services
{
    public class BuildingService : IBuildingService
    {
        private readonly IGenericRepository<Building> _repository;
        public BuildingService(IGenericRepository<Building> repository)
        {
            _repository = repository;
        }
        public async Task<List<BuildingModel>> GetBuildings()
        {

            try
            {
                List<BuildingModel> list = new List<BuildingModel>();
                var result = await _repository.GetAllAsync();
                result.ForEach(item => { list.Add(new BuildingModel() { Id = item.Id, Location = item.Location, Name = item.Name }); });
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
