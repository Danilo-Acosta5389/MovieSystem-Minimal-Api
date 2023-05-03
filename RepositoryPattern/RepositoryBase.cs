using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using MovieSystem_Minimal_Api.Data;

namespace MovieSystem_Minimal_Api.RepositoryPattern
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected DataContext DataContext { get; set; }
        public RepositoryBase(DataContext dataContext)
        {
            DataContext = dataContext;
        }
        public IQueryable<T> GetAll() => DataContext.Set<T>().AsNoTracking();
        public IQueryable<T> GetByCondition(Expression<Func<T, bool>> expression) =>
            DataContext.Set<T>().Where(expression).AsNoTracking();
        public void Create(T entity) => DataContext.Set<T>().Add(entity);
        public void Update(T entity) => DataContext.Set<T>().Update(entity);
        public void Delete(T entity) => DataContext.Set<T>().Remove(entity);
    }
}
