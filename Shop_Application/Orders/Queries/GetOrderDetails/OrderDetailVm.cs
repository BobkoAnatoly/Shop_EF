using AutoMapper;
using Shop_Application.Common.Mappings;
using Shop_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Application.Orders.Queries.GetOrderDetails
{
    public class OrderDetailVm : IMapWith<Order>
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public User? User { get; set; }
        public Product? Product { get; set; }
        public DeliveryPoint? DeliveryPoint { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Order, OrderDetailVm>()
                .ForMember(orderVm => orderVm.Id,
                opt => opt.MapFrom(order => order.Id))
                .ForMember(orderVm => orderVm.OrderDate,
                opt => opt.MapFrom(order => order.OrderDate))
                .ForMember(orderVm => orderVm.Product,
                opt => opt.MapFrom(order => order.Product))
                .ForMember(orderVm => orderVm.DeliveryPoint,
                opt => opt.MapFrom(order => order.DeliveryPoint))
                .ForMember(orderVm => orderVm.User,
                opt => opt.MapFrom(order => order.User));


        } 
    }
}
