using AutoMapper;
using Grpc.Core;
using PRN231_ProjectMain.Models;

namespace PRN231_ProjectMain.Services
{
    public class CategoryService : Categorier.CategorierBase
    {
        private FinalProjectDbContext _context;
        private IMapper _mapper;
        public CategoryService(FinalProjectDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public override Task<CRUDRepl> CreateCategory(CreateCategoryReq request, ServerCallContext context)
        {
            CRUDRepl repl = new CRUDRepl();
            try
            {
                Category category = _context.Categories.FirstOrDefault(cate => cate.CategoryName.ToLower() == request.CategoryName.ToLower());
                if (category != null)
                {
                    repl.Status = false;
                    repl.Message = "Category is already existed!";
                }
                else
                {
                    Category newCategory = new Category();
                    newCategory.CategoryName = request.CategoryName;
                    newCategory.Describe = request.CategoryName;
                    _context.Categories.Add(newCategory);
                    _context.SaveChanges();
                    repl.Status = true;
                    repl.Message = "Category create successfull";
                }

            }
            catch (Exception ex)
            {
                repl.Status = false;
                repl.Message = "Category create not successfully!";
            }
            return Task.FromResult(repl);
        }

        public override Task<CRUDRepl> DeleteCategory(DeleteCategoryReq request, ServerCallContext context)
        {
            CRUDRepl repl = new CRUDRepl();
            try
            {
                Category category = _context.Categories.FirstOrDefault(cate => cate.CategoryId == request.CategoryId);
                if (category == null)
                {
                    repl.Status = false;
                    repl.Message = "Category is not already existed!";
                }
                else
                {
                    _context.Remove(category);
                    _context.SaveChanges();
                    repl.Status = true;
                    repl.Message = "Category delete successfull";
                }

            }
            catch (Exception ex)
            {
                repl.Status = false;
                repl.Message = "Category delete not successfully!";
            }
            return Task.FromResult(repl);
        }

        public override Task<LstCateRepl> GetAllCategories(GetAllCateReq request, ServerCallContext context)
        {
            List<Category> categories = _context.Categories.ToList();
            LstCateRepl repl = new LstCateRepl();
            repl.Categories.AddRange(_mapper.Map<List<Category>, List<CategoryProto>>(categories));
            return Task.FromResult(repl);
        }

        public override Task<CRUDRepl> UpdateCategory(UpdateCategoryReq request, ServerCallContext context)
        {
            CRUDRepl repl = new CRUDRepl();
            try
            {
                Category category = _context.Categories.FirstOrDefault(cate => cate.CategoryId == request.CategoryId);
                if (category != null)
                {
                    repl.Status = false;
                    repl.Message = "Category is already existed!";
                }
                else
                {
                    category.CategoryName = request.CategoryName;
                    category.Describe = request.CategoryName;
                    _context.SaveChanges();
                    repl.Status = true;
                    repl.Message = "Category update successfull";
                }

            }
            catch (Exception ex)
            {
                repl.Status = false;
                repl.Message = "Category update not successfully!";
            }
            return Task.FromResult(repl);
        }
    }
}
