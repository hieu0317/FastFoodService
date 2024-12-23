using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PRN231_ProjectClient.Services;
using PRN231_ProjectMain;

namespace PRN231_ProjectClient.Pages.Customer
{
    [Authorize(Roles = "CUSTOMER")]
    public class MyOrderModel : PageModel
    {
        private OrderService _orderService;
        private string userId;
        public LstOrderRepl orders { get; set; }
        public MyOrderModel(OrderService orderService)
        {
            _orderService = orderService;
        }

        public void OnGet()
        {
            LoadData();
        }

        private void LoadData()
        {
            userId = User.FindFirst("Id").Value.ToString();
            orders = _orderService.GetLstOrderByUserId(new GetListOrderByUserIdReq { UserId = userId }).Result;
        }
    }
}
