using Repository.Client.Models;

namespace Repository.Client
{
    public interface IRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(int id);
        void Add(TEntity data);
        void Delete(int id);
        void Update(TEntity data);

        void Save();
    }
}
