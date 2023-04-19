using WebApplication1.Data;

namespace WebApplication1.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly ApplicationDbContext _context;
        public GenericRepository(ApplicationDbContext context) 
        {
            _context = context;
        }
        public ValueTask<TEntity> AddAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetAll() => _context.Set<TEntity>();

        public TEntity? GetById(int id) => _context.Set<TEntity>().Find(id);
         

        public async ValueTask<TEntity> Remove(TEntity entity)
        {
            var entry = _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }

        public ValueTask<TEntity> Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
