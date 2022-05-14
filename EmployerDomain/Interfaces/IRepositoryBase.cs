namespace EmployerDomain.Interfaces
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;

    public interface IRepositoryBase<T> where T : class
    {
        IQueryable<T> FindAll();
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
        T Create(T entity);
        bool Update(T entity);
        void Delete(T entity);
        void SaveChanges();
        void Detach(T entity);
    }
}
