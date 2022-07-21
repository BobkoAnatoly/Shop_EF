using MediatR;
using Shop_Application.Common.Mappings;
using Shop_Application.Models;
using AutoMapper;

namespace Shop_Application.Orders.Queries.GetOrderList
{
    public class OrderLookupDto: IMapWith<Order>
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string? DeliveryPointAdress { get; set; }
        public string? ProductName { get; set; }
        public decimal ProductPrice { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Order, OrderLookupDto>()
                .ForMember(orderDto => orderDto.Id,
                opt => opt.MapFrom(order => order.Id))
                .ForMember(orderDto => orderDto.OrderDate,
                opt => opt.MapFrom(order => order.OrderDate))
                .ForMember(orderDto => orderDto.DeliveryPointAdress,
                opt => opt.MapFrom(order => order.DeliveryPoint!.Adress))
                .ForMember(orderDto => orderDto.ProductName,
                opt => opt.MapFrom(order => order.Product!.Name))
                .ForMember(orderDto => orderDto.ProductPrice,
                opt => opt.MapFrom(order => order.Product!.Price));
                
        }
    }
}
