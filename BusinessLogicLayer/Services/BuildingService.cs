using BusinessLogicLayer.Interface;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Model;

namespace BusinessLogicLayer.Services
{
    public class BuildingService : IBuildingService
    {
        private readonly IGenericRepository<Building> _repository;
        public BuildingService(IGenericRepository<Building> repository)
        {
            _repository = repository;
        }
        public async Task<List<Building>> GetBuildings()
        {
            try
            {
                return await _repository.GetAllAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
