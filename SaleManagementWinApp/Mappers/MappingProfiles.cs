using AutoMapper;
using BusinessObjects;
using DataAccessObjects;

namespace SaleManagementWinApp.Mappers
{
	public class MappingProfiles : Profile
	{
		public MappingProfiles()
		{
			CreateMap<Customer, CustomerDAO>().ReverseMap();
			CreateMap<Category, CategoryDAO>().ReverseMap();
			CreateMap<Supplier, SupplierDAO>().ReverseMap();
			CreateMap<Order, HistoryOrderDAO>().ReverseMap();

			CreateMap<Order, OrderDAO>().
				ForMember(dest => dest.CustomerName, opt => opt.MapFrom(src => src.Customer.CustomerName)).ReverseMap();
			
			CreateMap<OrderDetail, OrderDetailDAO>().
				ForMember(dest => dest.FlowerBouquetName, opt => opt.MapFrom(src => src.FlowerBouquet.FlowerBouquetName));

			CreateMap<FlowerBouquet, FlowerBouquetDAO>()
				.ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.CategoryName))
				.ForMember(dest => dest.SupplierName, opt => opt.MapFrom(src => src.Supplier.SupplierName));
		}
	}
}
