namespace Repositories
{
    using BusinessObjects;
	using Microsoft.EntityFrameworkCore;
	using System;
	using System.Linq.Expressions;

	public class ProductRepository : BaseRepository<FlowerBouquet>, IProductRepository
    {
        public ProductRepository(FStoreDBContext context)
            : base(context)
        {
        }

		public IEnumerable<FlowerBouquet> GetProducts()
		{
			return this.Context.FlowerBouquets.Include(x => x.Category).Include(x => x.Supplier).AsNoTracking();
		}

		public override IEnumerable<FlowerBouquet> GetBy(Expression<Func<FlowerBouquet, bool>> predicate)
		{
			return Context.FlowerBouquets.Include(x => x.Category).Include(x => x.Supplier).Where(predicate).AsNoTracking();
		}
	}
}
