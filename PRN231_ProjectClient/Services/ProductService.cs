namespace PRN231_ProjectClient.Services
{
    public class ProductService
    {
        private Producter.ProducterClient _client;

        public ProductService(Producter.ProducterClient client)
        {
            _client = client;
        }

        public async Task<LstProductRepl> GetAllProduct(GetAllReq req)
        {
            LstProductRepl repl = await _client.GetAllProductAsync(req);
            return repl;
        }

        public async Task<LstProductRepl> GetProducsByCategory(GetProductsByCategoryReq req)
        {
            LstProductRepl repl = await _client.GetProductsByCategoryAsync(req);
            return repl;
        }

        public async Task<ProductProto> GetProductById(GetProductByIdReq req)
        {
            ProductProto product = await _client.GetProductByIdAsync(req);
            return product;
        }

        public async Task<CRUDRepl> DeleteProductById(DeleteProductReq req)
        {
            CRUDRepl repl = await _client.DeleteProductByIdAsync(req);
            return repl;
        }

        public async Task<CRUDRepl> UpdateProductById(UpdateProductReq req)
        {
            CRUDRepl repl = await _client.UpdateProductByIdAsync(req);
            return repl;
        }

        public async Task<CRUDRepl> CreateProduct(CreateProductReq req)
        {
            CRUDRepl repl = await _client.CreateProductAsync(req);
            return repl;
        }
    }
}
