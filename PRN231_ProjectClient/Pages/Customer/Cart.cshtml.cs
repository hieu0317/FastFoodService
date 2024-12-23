using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PRN231_ProjectClient.Services;

namespace PRN231_ProjectClient.Pages.Customer
{ 
    [Authorize(Roles = "CUSTOMER")]
    public class CartModel : PageModel
    {
        private CartService _cartService;
        public LstCartRepl lstCart { get; set; }
        public CartModel(CartService cartService)
        {
            _cartService = cartService;
        }

        public void OnGet()
        {
            LoadData();
        }

        public void OnGetDelete(int productId)
        {
            string userId = User.FindFirst("Id").Value.ToString();
            CRUDRepl repl = _cartService.DeleteProductInCart(
                new DeleteProductInCartReq 
                { 
                    UserId = userId, 
                    ProductId = productId 
                }).Result;
            LoadData();
        }

        public void OnPost(UpdateProductCartByUserIdReq req)
        {
            string userId = User.FindFirst("Id").Value.ToString();
            req.UserId = userId;
            CRUDRepl repl = _cartService.UpdateCartByUserId(req).Result;
            if (repl.Status)
            {
                Response.WriteAsync("<script>alert('Update successfull!')</script>");
            }
            else
            {
                Response.WriteAsync("<script>alert('Update failed!')</script>");
            }
        }

        private void LoadData()
        {
            string userId = User.FindFirst("Id").Value.ToString();
            lstCart = _cartService.GetCartsByUserId(new GetListCartByUserIdReq { UserId = userId }).Result;
        }
    }
}
