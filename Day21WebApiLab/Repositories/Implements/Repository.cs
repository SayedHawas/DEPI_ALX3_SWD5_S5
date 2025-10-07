using Day21WebApiLab.Repositories.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Day21WebApiLab.Repositories.Implements
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _dbContext;
        private readonly DbSet<T> _dbSet;
        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }
        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }
        public void Delete(int id)
        {
            var entity = _dbSet.Find(id);
            if (entity != null) _dbSet.Remove(entity);
        }
        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate).AsNoTracking().ToList();
        }
        public IEnumerable<T> GetAll()
        {
            try
            {
                return _dbSet.AsNoTracking().ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }
        public IEnumerable<T> GetAllIncluding(params string[] includes)
        {
            IQueryable<T> query = _dbSet.AsQueryable();

            foreach (var include in includes)
            {
                query = query.Include(include);
            }
            return query.AsNoTracking().ToList();
        }
        public T GetByID(int id)
        {
            var keyName = _dbContext.Model.FindEntityType(typeof(T)).FindPrimaryKey().Properties.Select(x => x.Name).Single();

            // Use EF Core's Find method instead of reflection
            return _dbSet.AsNoTracking().FirstOrDefault(e => EF.Property<int>(e, keyName) == id);
        }
        public int RowCount()
        {
            try
            {
                return _dbSet.AsNoTracking().Count();
            }
            catch (SqlException)
            {
                return -1;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public void Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
        }
    }
}
