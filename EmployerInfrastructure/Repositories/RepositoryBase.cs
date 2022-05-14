
namespace EmployerInfrastructure.Repositories
{
    using EmployerDomain.Interfaces;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Linq;
    using System.Linq.Expressions;

    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected EmployeeDbContext employeeDbContext { get; set; }

        public RepositoryBase(EmployeeDbContext employeeDbContext)
        {
            this.employeeDbContext = employeeDbContext;
        }

        public T Create(T entity)
        {
           if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            this.employeeDbContext.Set<T>().Add(entity);
            this.employeeDbContext.SaveChanges();
            return entity;
        }

        public void Delete(T entity)
        {
            this.employeeDbContext.Set<T>().Remove(entity);
            this.employeeDbContext.SaveChanges(true);
        }

        public void Detach(T entity)
        {
            this.employeeDbContext.Entry(entity).State = EntityState.Detached;
        }

        public IQueryable<T> FindAll()
        {
            return this.employeeDbContext.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.employeeDbContext.Set<T>()
                .Where(expression).AsNoTracking();
        }

        public void SaveChanges()
        {
            this.employeeDbContext.SaveChanges();
        }

        public bool Update(T entity)
        {
            if(entity == null)
            {
                return false;
            }
            this.employeeDbContext.Set<T>().Update(entity);
            this.employeeDbContext.SaveChanges();
            return true;
        }
    }
}
