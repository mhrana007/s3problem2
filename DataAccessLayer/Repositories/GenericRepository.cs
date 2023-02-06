using DataAccessLayer.DataContext;
using DataAccessLayer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly S3DbContext _context;
        public GenericRepository(S3DbContext context)
        {
            _context = context;
        }
        public async Task<List<T>> GetAllAsync()
        {
            try
            {
                return await _context.Set<T>().ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
