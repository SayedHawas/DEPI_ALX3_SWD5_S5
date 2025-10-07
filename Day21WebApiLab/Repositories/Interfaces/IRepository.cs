using System.Linq.Expressions;

namespace Day21WebApiLab.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetByID(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        int RowCount();
        //Use Include for Eager Loading
        IEnumerable<T> GetAllIncluding(params string[] includes);
    }
}
