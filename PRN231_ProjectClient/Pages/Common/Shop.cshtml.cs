using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PRN231_ProjectClient.Services;

namespace PRN231_ProjectClient.Pages.Common
{
    public class ShopModel : PageModel
    {
        private ProductService _productService;
        private CategoryService _categoryService;
        [BindProperty(SupportsGet = true)]
        public int categoryId { get; set; }
        [BindProperty(SupportsGet = true)]
        public int pageNum { get; set; }
        [BindProperty]
        public string productName { get; set; }
        [BindProperty]
        public string sortBy { get; set; }
        public decimal totalPage { get; set; }
        public int totalProductFound { get; set; }
        public LstCateRepl lstCategory { get; set; }
        public LstProductRepl lstProduct { get; set; }
        private decimal productPerPage = 6;
        public ShopModel(ProductService productService, CategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public void OnGet()
        {
            LoadData();
        }

        private void LoadData()
        {
            lstCategory = _categoryService.GetAllCategories(new GetAllCateReq()).Result;
            lstProduct = _productService.GetAllProduct(new GetAllReq()).Result;
            lstProduct = GetLstProductByPage(productName, pageNum, categoryId,sortBy);
        }

        public void OnPost()
        {
            LoadData();
        }

        public void OnPostSearch() 
        { 
            LoadData(); 
        }

        private LstProductRepl GetLstProductByPage(string productName,int pageNum, int categoryId, string sortBy)
        {
            if (pageNum == 0)
            {
                pageNum = 1;
            }

            LstProductRepl lst = new LstProductRepl();

            var filter = lstProduct.Products.Where(p => string.IsNullOrEmpty(productName) || p.ProductName.ToLower().Contains(productName.ToLower()))
                                                            .Where(p => categoryId == 0 || p.CategoryId == categoryId);            
            if (!string.IsNullOrEmpty(sortBy))
            {
                filter = filter.OrderBy(p => p.Price);
            }
            totalProductFound = filter.ToList().Count;
            totalPage = Math.Ceiling(totalProductFound / productPerPage);
            filter = filter.Skip((int)((pageNum - 1) * productPerPage)).Take((int)productPerPage).ToList();
            lst.Products.AddRange(filter);
            return lst;
        }
    }
}
