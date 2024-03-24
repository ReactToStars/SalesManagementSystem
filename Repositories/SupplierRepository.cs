namespace Repositories
{
    using BusinessObjects;

    public class SupplierRepository : BaseRepository<Supplier>, ISupplierRepository
    {
        public SupplierRepository(FStoreDBContext context)
            : base(context)
        {
        }
    }
}
