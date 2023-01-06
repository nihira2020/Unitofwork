using Microsoft.EntityFrameworkCore;
using Unitofwork.Interface;
using Unitofwork.Modelss;

namespace Unitofwork.Repos
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected LearnDbContext dbContext;
        internal DbSet<T> DbSet { get; set; }
        public GenericRepository(LearnDbContext learnDb)
        {
            this.dbContext = learnDb;
            this.DbSet=this.dbContext.Set<T>();
        }
        public virtual Task<bool> AddEntity(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual Task<bool> DeleteEntity(int id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<List<T>> GetAllAsync()
        {
            return this.DbSet.ToListAsync();
        }

        public virtual Task<T> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<bool> UpdateEntity(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
