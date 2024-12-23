using AutoMapper;
using Grpc.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using PRN231_ProjectMain.Models;
using System.Net;

namespace PRN231_ProjectMain.Services
{
    [Authorize]
    public class OrderService : Orderer.OrdererBase
    {
        private IMapper _mapper;
        private FinalProjectDbContext _context;

        public OrderService(IMapper mapper, FinalProjectDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public override Task<CRUDRepl> AddOrderByUserId(AddOrderByUserIdReq request, ServerCallContext context)
        {
            CRUDRepl repl = new CRUDRepl();
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    Order order = new Order
                    {
                        UserId = request.UserId,
                        Total = request.Total,
                        Date = DateTime.Parse(request.Date),
                        Address = request.Address,
                        Note = request.Note,
                        OrderStatusId = 1,
                        CustomerName = request.CustomerName,
                        Email = request.Email,
                        PaymentMethod = "COD",
                        PhoneNumber = request.Phonenum
                    };
                    _context.Orders.Add(order);
                    _context.SaveChanges();

                    for(int i = 0; i < request.ProductId.Count; i++)
                    {
                        OrderInfo oi = new OrderInfo
                        {
                            OrderId = order.OrderId,
                            ProductId = request.ProductId[i],
                            Quantity = request.Quantity[i]
                        };
                        _context.OrderInfos.Add(oi);
                        _context.SaveChanges();

                        Cart c = _context.CartDetails.FirstOrDefault(c => c.UserId == request.UserId && c.ProductId == request.ProductId[i]);
                        _context.CartDetails.Remove(c);
                        _context.SaveChanges();
                    }
                    transaction.Commit();
                    repl.Status = true;
                } catch (Exception ex)
                {
                    transaction.Rollback();
                    repl.Status = false;
                    repl.Message = ex.Message;
                }
            }
            return Task.FromResult(repl);
        }

        public override Task<LstOrderRepl> GetListOrderByUserId(GetListOrderByUserIdReq request, ServerCallContext context)
        {
            LstOrderRepl repl = new LstOrderRepl();
            List<Order> orders = _context.Orders.Include(o => o.OrderStatus).Where(o => o.UserId == request.UserId).ToList();
            repl.Orders.AddRange(_mapper.Map<List<Order>, List<OrderProto>>(orders));
            return Task.FromResult(repl);
        }

        public override Task<LstOrderInfoRepl> GetOrderInfoByOrderId(GetOrderInfoByOrderIdReq request, ServerCallContext context)
        {
            LstOrderInfoRepl repl = new LstOrderInfoRepl();
            List<OrderInfo> orderInfos = _context.OrderInfos.Include(oi => oi.Product).Include(oi => oi.Order).Where(oi => oi.OrderId == request.OrderId).ToList();
            repl.OrderInfos.AddRange(_mapper.Map<List<OrderInfo>, List<OrderInfoProto>>(orderInfos));
            return Task.FromResult(repl);
        }
    }
}
