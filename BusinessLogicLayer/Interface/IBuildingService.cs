using GlobalEntity;

namespace BusinessLogicLayer.Interface
{
    public interface IBuildingService
    {
        Task<List<BuildingModel>> GetBuildings();
    }
}
