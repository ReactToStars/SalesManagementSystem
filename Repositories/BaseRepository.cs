namespace Repositories
{
    using BusinessObjects;
    using Microsoft.EntityFrameworkCore;
	using System.Linq.Expressions;

    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        public BaseRepository(FStoreDBContext context)
        {
            this.Context = context;
        }

        protected FStoreDBContext Context { get; set; }

        public virtual T? Get(Expression<Func<T, bool>> predicate)
        {
            return Context.Set<T>().AsNoTracking().FirstOrDefault(predicate);
        }

		public virtual IEnumerable<T> GetBy(Expression<Func<T, bool>> predicate)
		{
			return Context.Set<T>().AsNoTracking().Where(predicate);
		}

		public virtual IEnumerable<T> GetAll()
        {
            return Context.Set<T>().AsNoTracking();
        }

        public virtual bool Add(T entity)
        {
            Context.Set<T>().Add(entity);
            return Context.SaveChanges() > 0;
        }

        public virtual bool AddRange(IEnumerable<T> entities)
        {
            Context.Set<T>().AddRange(entities);
            return Context.SaveChanges() > 0;
        }

        public virtual void Update(T entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public virtual void Delete(T entity)
        {
            Context.Set<T>().Remove(entity);
            Context.SaveChanges();
        }
    }
}