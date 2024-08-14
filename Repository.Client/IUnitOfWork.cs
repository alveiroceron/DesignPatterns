using Repository.Client.Models;

namespace Repository.Client
{
    public interface IUnitOfWork
    {
        IRepository<Beer> Beers { get; }
        IRepository<Brand> Brands { get; }

        int Complete();
    }
}
