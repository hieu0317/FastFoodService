using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PRN231_ProjectClient.Services;

namespace PRN231_ProjectClient.Pages.Common
{
    public class ProductDetailModel : PageModel
    {
        private ProductService _productService;
        private CartService _cartService;
        [BindProperty(SupportsGet = true)]
        public int productId { get; set; }
        public ProductProto Product { get; set; }

        public ProductDetailModel(ProductService productService, CartService cartService)
        {
            _productService = productService;
            _cartService = cartService;
        }

        public void OnGet()
        {
            LoadData();
        }

        public void OnPost(int quantity)
        {
            string userId = User.FindFirst("Id").Value.ToString();
            CRUDRepl repl = _cartService.AddProductToCart(new AddProductToCartWithUserIdReq
            {
                ProductId = productId,
                UserId = userId,
                Quantity = quantity
            }).Result;
            if (repl.Status)
            {
                Response.Redirect("/Customer/Cart");
            }
            LoadData();
        }

        private void LoadData()
        {
            Product = _productService.GetProductById(new GetProductByIdReq { ProductId = productId}).Result;
        }
    }
}
