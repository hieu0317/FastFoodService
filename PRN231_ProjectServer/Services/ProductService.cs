using AutoMapper;
using Grpc.Core;
using Microsoft.EntityFrameworkCore;
using PRN231_ProjectMain.Models;

namespace PRN231_ProjectMain.Services
{
    public class ProductService : Producter.ProducterBase
    {
        private IMapper _mapper;
        private FinalProjectDbContext _context;

        public ProductService(IMapper mapper, FinalProjectDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public override Task<LstProductRepl> GetAllProduct(GetAllReq request, ServerCallContext context)
        {
            List<Product> lstProducts = _context.Products.Include(p => p.Category).ToList();   
            LstProductRepl repl = new LstProductRepl(); 
            repl.Products.AddRange(_mapper.Map<List<Product>,List<ProductProto>>(lstProducts));
            return Task.FromResult(repl);
        }

        public override Task<LstProductRepl> GetProductsByCategory(GetProductsByCategoryReq request, ServerCallContext context)
        {
            List<Product> lstProducts = _context.Products.Include(p => p.Category).Where(p => p.CategoryId == request.CategoryId).ToList();
            LstProductRepl repl = new LstProductRepl();
            repl.Products.AddRange(_mapper.Map<List<Product>, List<ProductProto>>(lstProducts));
            return Task.FromResult(repl);
        }

        public override Task<ProductProto> GetProductById(GetProductByIdReq request, ServerCallContext context)
        {
            Product p = _context.Products.Include(p => p.Category).FirstOrDefault(p => p.ProductId == request.ProductId);
            return Task.FromResult(_mapper.Map<Product, ProductProto>(p));
        }

        public override Task<CRUDRepl> DeleteProductById(DeleteProductReq request, ServerCallContext context)
        {
            CRUDRepl repl = new CRUDRepl();
            try
            {
                Product p = _context.Products.FirstOrDefault(p => p.ProductId == request.ProductId);
                if(p == null)
                {
                    repl.Status = false;
                    repl.Message = "Product not found!";
                }
                else
                {
                    p.Status = false;
                    _context.SaveChanges();
                    repl.Status = true;
                    repl.Message = "Delete product successfull";
                }
            }catch(Exception ex)
            {
                repl.Status = false;
                repl.Message = "Delete not successful!";
            }
            return Task.FromResult(repl);
        }

        public override Task<CRUDRepl> UpdateProductById(UpdateProductReq request, ServerCallContext context)
        {
            CRUDRepl repl = new CRUDRepl();
            try
            {
                Product p = _context.Products.FirstOrDefault(p => p.ProductId == request.ProductId);
                if(p == null)
                {
                    repl.Status = false;
                    repl.Message = "Product not found!";
                }
                else
                {
                    p.CategoryId = request.CategoryId;
                    p.ProductName = request.ProductName;
                    p.Price = request.Price;
                    p.Details = request.Details;
                    p.ImageUrl = request.Url;
                    _context.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                repl.Status = false;
                repl.Message = "Update not successful!";
            }
            return Task.FromResult(repl);
        }

        public override Task<CRUDRepl> CreateProduct(CreateProductReq request, ServerCallContext context)
        {
            CRUDRepl repl = new CRUDRepl();
            try
            {
                Product p = _context.Products.FirstOrDefault(p => p.ProductName.ToLower() == request.ProductName.ToLower() && p.CategoryId == p.CategoryId);
                if (p != null)
                {
                    repl.Status = false;
                    repl.Message = "Product is already existed found!";
                }
                else
                {
                    Product newProduct = new Product();
                    newProduct.CategoryId = request.CategoryId;
                    newProduct.ProductName = request.ProductName;
                    newProduct.Price = request.Price;
                    newProduct.Details = request.Details;
                    _context.Products.Add(newProduct);
                    _context.SaveChanges();
                    repl.Status = true;
                    repl.Message = "Product create successfull!";
                }
            }
            catch (Exception ex)
            {
                repl.Status = false;
                repl.Message = "Add not successful!";
            }
            return Task.FromResult(repl);
        }
    }
}
