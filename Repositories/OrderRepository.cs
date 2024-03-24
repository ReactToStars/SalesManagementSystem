namespace Repositories
{
	using BusinessObjects;
	using DataAccessObjects.Enums;
	using DataAccessObjects.Models;
	using Microsoft.EntityFrameworkCore;
	using System;
	using System.Linq;
	using System.Linq.Expressions;

	public class OrderRepository : BaseRepository<Order>, IOrderRepository
	{
		public OrderRepository(FStoreDBContext context)
			: base(context)
		{
		}

		public override IEnumerable<Order> GetAll()
		{
			return Context.Orders.AsNoTracking().Include(x => x.Customer);
		}

		public override IEnumerable<Order> GetBy(Expression<Func<Order, bool>> predicate)
		{
			return Context.Orders.AsNoTracking().Include(x => x.Customer).Where(predicate);
		}

		public override Order? Get(Expression<Func<Order, bool>> predicate)
		{
			return Context.Orders.AsNoTracking().Include(x => x.OrderDetails).FirstOrDefault(predicate);
		}

		public IEnumerable<RevenueData> GetRevenueBy(DateTime fromDate, DateTime toDate)
		{
			var result = Context.Orders.AsNoTracking()
							.Where(o => o.OrderStatus.Trim() == OrderStatus.Completed.ToString() &&
										o.OrderDate.Date >= fromDate.Date && o.OrderDate.Date <= toDate.Date)
							.GroupBy(o => new { o.OrderDate })
							.Select(final => new RevenueData
							{
								Date = final.Key.OrderDate,
								Revenue = final.Sum(f => f.Total)
							}).ToList();

			return result;
		}
	}
}
