using Repository.Client.Models;

namespace Repository.Client
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BeerdbContext _context;
        private IRepository<Beer> _beers;
        private IRepository<Brand> _brands;

        public IRepository<Beer> Beers
        {
            get => _beers ??= new Repository<Beer>(_context);
        }

        public IRepository<Brand> Brands
        {
            get => _brands ??= new Repository<Brand>(_context);
        }

        public UnitOfWork(BeerdbContext context)
        {
            _context = context;
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }
    }
}
