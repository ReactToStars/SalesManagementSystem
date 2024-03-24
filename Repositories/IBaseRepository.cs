using System.Linq.Expressions;

namespace Repositories
{
	public interface IBaseRepository<T> where T : class
	{
		T? Get(Expression<Func<T, bool>> predicate);
		IEnumerable<T> GetBy(Expression<Func<T, bool>> predicate);
		IEnumerable<T> GetAll();
		bool Add(T entity);
		bool AddRange(IEnumerable<T> entities);
		void Update(T entity);
		void Delete(T entity);
	}
}
