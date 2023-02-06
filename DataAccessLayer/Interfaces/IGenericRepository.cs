
namespace DataAccessLayer.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        //  Task<T> GetById(int id);
    }
}
