namespace Repositories
{
    using BusinessObjects;

    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(FStoreDBContext context)
            : base(context)
        {
        }
    }
}
