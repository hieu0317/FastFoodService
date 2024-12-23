using PRN231_ProjectMain;

namespace PRN231_ProjectClient.Services
{
    public class OrderService
    {
        private Orderer.OrdererClient _ordererClient;

        public OrderService(Orderer.OrdererClient ordererClient)
        {
            _ordererClient = ordererClient;
        }

        public async Task<CRUDRepl> AddOrderByUserId(AddOrderByUserIdReq req)
        {
            CRUDRepl repl = await _ordererClient.AddOrderByUserIdAsync(req);
            return repl;
        }

        public async Task<LstOrderRepl> GetLstOrderByUserId(GetListOrderByUserIdReq req)
        {
            LstOrderRepl repl = await _ordererClient.GetListOrderByUserIdAsync(req);
            return repl;
        }

        public async Task<LstOrderInfoRepl> GetLstOrderInfoByOrderId(GetOrderInfoByOrderIdReq req)
        {
            LstOrderInfoRepl repl = await _ordererClient.GetOrderInfoByOrderIdAsync(req);
            return repl;
        }
    }
}
