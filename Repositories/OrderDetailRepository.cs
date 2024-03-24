namespace Repositories
{
    using BusinessObjects;
	using Microsoft.EntityFrameworkCore;
	using System.Collections.Generic;
	using System.Linq.Expressions;

	public class OrderDetailRepository : BaseRepository<OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(FStoreDBContext context)
            : base(context)
        {
        }

		public override IEnumerable<OrderDetail> GetAll()
		{
			return Context.OrderDetails.AsNoTracking().Include(x => x.FlowerBouquet);
		}

		public override IEnumerable<OrderDetail> GetBy(Expression<Func<OrderDetail, bool>> predicate)
		{
			return Context.OrderDetails.AsNoTracking().Include(x => x.FlowerBouquet).Where(predicate);
		}
	}
}
