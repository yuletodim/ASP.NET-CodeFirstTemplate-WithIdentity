namespace CodeFirstTemplate.DATA.Repositories
{
    using System.Linq;

    public interface IDbRepository<TEntity, in TKey> where TEntity : class
    {
        IQueryable<TEntity> GetAll();

        TEntity Find(TKey id);

        TEntity Add(TEntity entity);

        TEntity Update(TEntity entity);

        void Remove(TEntity entity);

        TEntity Remove(TKey id);

        void SaveChanges();
    }
}
