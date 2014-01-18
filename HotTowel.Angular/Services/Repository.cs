using System.Data.Entity;
using System.Linq;

namespace TempHire.Services
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public Repository(DbContext context)
        {
            Context = context;
        }

        protected DbContext Context { get; private set; }

        public IQueryable<T> All()
        {
            return Context.Set<T>();
        }

        public bool BeforeUpdate(T originalEntity, T entityToUpdate)
        {
            throw new System.NotImplementedException();
        }

        public void AfterUpdate(T originalEntity, T entityToUpdate)
        {
            throw new System.NotImplementedException();
        }

        public bool BeforeAdd(T newEntity)
        {
            throw new System.NotImplementedException();
        }

        public void AfterAdd(T newEntity)
        {
            throw new System.NotImplementedException();
        }

        public bool BeforeDelete(T entityToDelete)
        {
            throw new System.NotImplementedException();
        }

        public void AfterDelete(T entityToDelete)
        {
            throw new System.NotImplementedException();
        }
    }
}