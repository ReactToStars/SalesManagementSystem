using BusinessObjects;
using DataAccessObjects.Models;

namespace Repositories
{
	public interface IOrderRepository : IBaseRepository<Order>
    {
        IEnumerable<RevenueData> GetRevenueBy(DateTime fromDate, DateTime toDate);
    }
}
