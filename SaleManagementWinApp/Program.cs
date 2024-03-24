using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SaleManagementWinApp
{

	using BusinessObjects;
	using Microsoft.EntityFrameworkCore;
	using Repositories;
	using SaleManagementWinApp.Mappers;

	internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var services = new ServiceCollection();
			var configuration = new ConfigurationBuilder()
								.SetBasePath(Directory.GetCurrentDirectory())
								.AddJsonFile("appsettings.json")
								.Build();

			ConfigureServices(services, configuration);

			// Build the service provider
			var serviceProvider = services
				.AddAutoMapper(typeof(MappingProfiles))
				.BuildServiceProvider();

			Application.Run(new frmLogin(serviceProvider));
        }

        private static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
			// DbContext
			services.AddDbContext<FStoreDBContext>(opt => {
				opt.UseSqlServer(configuration.GetConnectionString("FStoreDBContext"));
			});

			// Repositories
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ISupplierRepository, SupplierRepository>();
        }
    }
}