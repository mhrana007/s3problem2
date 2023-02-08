using GlobalEntity;

namespace BusinessLogicLayer.Interface
{
    public interface IDataFieldService
    {
        Task<List<DataFieldModel>> GetDataFields();
    }
}
