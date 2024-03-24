namespace Repositories
{
    using BusinessObjects;

    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(FStoreDBContext context)
            : base(context)
        {
        }
    }
}
