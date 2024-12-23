using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PRN231_ProjectClient.Services;

namespace PRN231_ProjectClient.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private CategoryService _categoryService;
        private ProductService _productService;

        public LstProductRepl lstProduct { get; set; }
        public LstCateRepl lstCate { get; set; }

        public IndexModel(ILogger<IndexModel> logger, CategoryService categoryService, ProductService productService)
        {
            _logger = logger;
            _categoryService = categoryService;
            _productService = productService;
        }

        public void OnGet()
        {
            LoadData();
        }

        private void LoadData()
        {
            lstCate = _categoryService.GetAllCategories(new GetAllCateReq()).Result;
            lstProduct = _productService.GetAllProduct(new GetAllReq()).Result;
        }
    }
}
