namespace PRN231_ProjectClient.Services
{
    public class CartService
    {
        private Carter.CarterClient _client;

        public CartService(Carter.CarterClient client)
        {
            _client = client;
        }

        public async Task<LstCartRepl> GetCartsByUserId(GetListCartByUserIdReq req)
        {
            LstCartRepl repl = await _client.GetListCartByUserIdAsync(req);
            return repl;
        }

        public async Task<CRUDRepl> AddProductToCart(AddProductToCartWithUserIdReq req)
        {
            CRUDRepl repl = await _client.AddProductToCartWithUserIdAsync(req);
            return repl;
        }

        public async Task<CRUDRepl> DeleteProductInCart(DeleteProductInCartReq req)
        {
            CRUDRepl repl = await _client.DeleteProductInCartAsync(req);
            return repl;
        }

        public async Task<CRUDRepl> UpdateCartByUserId(UpdateProductCartByUserIdReq req)
        {
            CRUDRepl repl = await _client.UpdateProductCartByUserIdAsync(req);
            return repl;
        }
    }
}
