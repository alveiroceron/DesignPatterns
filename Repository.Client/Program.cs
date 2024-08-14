using Repository.Client;
using Repository.Client.Models;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new BeerdbContext())
        {

            var unitOfWork = new UnitOfWork(context);

            var beers = unitOfWork.Beers;
            var beer = new Beer() {Name = "Fuller 2", Style = "Porter 2" };
            beers.Add(beer);

            var brands = unitOfWork.Brands;
            var brand = new Brand() { Name = "Fuller 2" };
            brands.Add(brand);

            unitOfWork.Complete();
        }
    }
}