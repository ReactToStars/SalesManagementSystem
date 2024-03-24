using BusinessObjects;

namespace Repositories
{
    public interface IProductRepository : IBaseRepository<FlowerBouquet>
    {
        IEnumerable<FlowerBouquet> GetProducts();
    }
}
