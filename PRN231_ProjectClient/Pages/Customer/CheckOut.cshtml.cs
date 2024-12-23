using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PRN231_ProjectClient.Services;
using PRN231_ProjectMain;
using System.Diagnostics;

namespace PRN231_ProjectClient.Pages.Customer
{
    [Authorize(Roles = "CUSTOMER")]
    public class CheckOutModel : PageModel
    {
        private OrderService _orderService;
        private CartService _cartService;
        public LstCartRepl carts { get; set; }

        public CheckOutModel(OrderService orderService, CartService cartService)
        {
            _orderService = orderService;
            _cartService = cartService;
        }

        public void OnGet()
        {
            LoadData();
        }

        private void LoadData()
        {
            string userId = User.FindFirst("Id").Value.ToString();
            carts = _cartService.GetCartsByUserId(new GetListCartByUserIdReq { UserId = userId }).Result;
        }

        public void OnPost(AddOrderByUserIdReq req, string detailAddress,string streetAddress)
        {
            string userId = User.FindFirst("Id").Value.ToString();
            req.Address = detailAddress + " " + streetAddress;
            req.Date = DateTime.Now.ToString("dd/MM/yyyy");
            req.UserId = userId;
            CRUDRepl repl = _orderService.AddOrderByUserId(req).Result;
            if (repl.Status)
            {
                Response.Redirect("/Customer/MyOrder");
            }
            else
            {
                Response.WriteAsync("<script>alert('" + repl.Message + "')</script>");
            }
            LoadData();
        }
    }
}
