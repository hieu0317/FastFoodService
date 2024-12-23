using AutoMapper;
using Grpc.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using PRN231_ProjectMain.Models;

namespace PRN231_ProjectMain.Services
{
    [Authorize]
    public class CartService : Carter.CarterBase
    {
        private FinalProjectDbContext _context;
        private IMapper _mapper;

        public CartService(FinalProjectDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public override Task<LstCartRepl> GetListCartByUserId(GetListCartByUserIdReq request, ServerCallContext context)
        {
            List<Cart> carts = _context.CartDetails.Include(c => c.Product).Where(c => c.UserId == request.UserId).ToList();
            LstCartRepl repl = new LstCartRepl();
            repl.Cart.AddRange(_mapper.Map<List<Cart>, List<CartProto>>(carts));
            return Task.FromResult(repl);
        }

        public override Task<CRUDRepl> AddProductToCartWithUserId(AddProductToCartWithUserIdReq request, ServerCallContext context)
        {
            CRUDRepl repl = new CRUDRepl();
            try
            {
                Cart existed = _context.CartDetails.FirstOrDefault(c => c.UserId == request.UserId && c.ProductId == request.ProductId);
                if(existed != null)
                {
                    existed.Quantity += request.Quantity;
                }else
                {
                    Cart cart = new Cart();
                    cart.ProductId = request.ProductId;
                    cart.UserId = request.UserId;
                    cart.Quantity = request.Quantity;
                    _context.CartDetails.Add(cart);
                }
                _context.SaveChanges();
                repl.Status = true;
                repl.Message = "Add successfull!";
            }
            catch(Exception ex)
            {
                repl.Status = false;
                repl.Message = ex.Message;
            }
            return Task.FromResult(repl);
        }

        public override Task<CRUDRepl> DeleteProductInCart(DeleteProductInCartReq request, ServerCallContext context)
        {
            CRUDRepl repl = new CRUDRepl();
            try
            {
                Cart c = _context.CartDetails.FirstOrDefault(c => c.UserId == request.UserId && c.ProductId == request.ProductId);
                _context.CartDetails.Remove(c);
                _context.SaveChanges();
                repl.Status = true;
            }
            catch (Exception ex)
            {
                repl.Status = false;
                repl.Message = ex.Message;
            }
            return Task.FromResult(repl);
        }

        public override Task<CRUDRepl> UpdateProductCartByUserId(UpdateProductCartByUserIdReq request, ServerCallContext context)
        {
            CRUDRepl repl = new CRUDRepl();
            using(var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    List<Cart> carts = _context.CartDetails.Where(c => c.UserId == request.UserId).ToList();
                    for(int i = 0; i < request.ProductId.Count; i++)
                    {
                        foreach(Cart c in carts)
                        {
                            if(c.ProductId == request.ProductId[i])
                            {
                                c.Quantity = request.Quantity[i];
                                _context.SaveChanges();
                            }
                        }
                    }
                    transaction.Commit();
                    repl.Status = true;
                }catch (Exception ex)
                {
                    transaction.Rollback();
                    repl.Status = false;
                    repl.Message = ex.Message;
                }
            }
            return Task.FromResult(repl);
        }
    }
}
