using System.Linq;

namespace TempHire.Services
{
    public interface IRepository<T>
    {
        IQueryable<T> All();
        bool BeforeUpdate(T originalEntity, T entityToUpdate);
        void AfterUpdate(T originalEntity, T entityToUpdate);
        bool BeforeAdd(T newEntity);
        void AfterAdd(T newEntity);
        bool BeforeDelete(T entityToDelete);
        void AfterDelete(T entityToDelete);
    }
}