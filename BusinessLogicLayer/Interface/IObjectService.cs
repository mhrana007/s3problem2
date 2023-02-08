using GlobalEntity;

namespace BusinessLogicLayer.Interface
{
    public interface IObjectService
    {
        Task<List<ObjectModel>> GetObjects();
    }
}
