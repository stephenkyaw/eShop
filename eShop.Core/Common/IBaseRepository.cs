namespace eShop.Core.Common
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        Task AddAsync(TEntity entity);

        Task AddRangeAsync(IEnumerable<TEntity> entities);

        void Update(TEntity entity);

        void UpdateRange(IEnumerable<TEntity> entities);

        void Delete(TEntity entity);

        void DeleteRange(IEnumerable<TEntity> entities);

        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> GetEntityById(Guid id);

        void SaveChanges();

        Task SaveChangesAsync();

    }
}
