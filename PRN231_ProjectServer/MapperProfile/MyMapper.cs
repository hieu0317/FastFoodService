using AutoMapper;
using Microsoft.IdentityModel.Tokens;
using PRN231_ProjectMain.Models;

namespace PRN231_ProjectMain.MapperProfile
{
    public class MyMapper : Profile
    {
        public MyMapper() 
        {
            CreateMap<Product, ProductProto>()
                .ForMember(dest => dest.ImageUrl,
                act => act.MapFrom(p => string.IsNullOrEmpty(p.ImageUrl) ? "" : p.ImageUrl))
                .ForMember(dest => dest.CategoryName,
                act => act.MapFrom(p => p.Category.CategoryName))
                .ForMember(dest => dest.Details,
                act => act.MapFrom(p => string.IsNullOrEmpty(p.Details) ? "" : p.Details));
            CreateMap<Category, CategoryProto>()
                .ForMember(dest => dest.Describe,
                act => act.MapFrom(c => string.IsNullOrEmpty(c.Describe) ? "" : c.Describe));
            CreateMap<Cart, CartProto>()
                .ForMember(dest => dest.Product,
                act => act.MapFrom(c => new ProductProto
                {
                    CategoryId = c.Product.CategoryId,
                    ProductID = c.Product.ProductId,
                    ProductName = c.Product.ProductName,
                    Details = string.IsNullOrEmpty(c.Product.Details) ? "" : c.Product.Details,
                    Price = c.Product.Price,
                    Status = c.Product.Status,
                    ImageUrl = c.Product.ImageUrl
                }));
            CreateMap<Like, LikeProto>()
                .ForMember(dest => dest.Product,
                act => act.MapFrom(l => new ProductProto
                {
                    CategoryId = l.Product.ProductId,
                    ProductID = l.Product.CategoryId,
                    ProductName = l.Product.ProductName,
                    Details = l.Product.Details,
                    Price = l.Product.Price,
                    Status = l.Product.Status
                }));
            CreateMap<User, UserProto>();   
            CreateMap<Order, OrderProto>()
                .ForMember(dest => dest.OrderStatus,
                act => act.MapFrom(o => o.OrderStatus.OrderStatusName))
                .ForMember(dest => dest.Date,
                act => act.MapFrom(o => o.Date.ToString("dd/MM/yyyy")));
            CreateMap<OrderInfo, OrderInfoProto>()
                .ForMember(dest => dest.Order,
                act => act.MapFrom(oi => new OrderInfoProto
                {
                    OrderId = oi.OrderId,
                    ProductId = oi.ProductId,
                    Quantity = (int)oi.Quantity
                }))
                .ForMember(dest => dest.Product,
                act => act.MapFrom(oi => new ProductProto
                {
                    CategoryId = oi.Product.CategoryId,
                    ProductID = oi.Product.ProductId,
                    ProductName = oi.Product.ProductName,
                    Details = string.IsNullOrEmpty(oi.Product.Details) ? "" : oi.Product.Details,
                    ImageUrl = oi.Product.ImageUrl,
                    Price = oi.Product.Price,
                    Status = oi.Product.Status
                }));
        }
    }
}
