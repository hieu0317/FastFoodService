namespace PRN231_ProjectClient.Services
{
    public class CategoryService
    {
        private Categorier.CategorierClient _client;

        public CategoryService(Categorier.CategorierClient client)
        {
            _client = client;
        }

        public async Task<CRUDRepl> CreateCategory(CreateCategoryReq req)
        {
            CRUDRepl repl = await _client.CreateCategoryAsync(req);
            return repl;
        }

        public async Task<CRUDRepl> DeleteCategory(DeleteCategoryReq req)
        {
            CRUDRepl repl = await _client.DeleteCategoryAsync(req);
            return repl;
        }

        public async Task<CRUDRepl> UpdateCategory(UpdateCategoryReq req)
        {
            CRUDRepl repl = await _client.UpdateCategoryAsync(req);
            return repl;
        }

        public async Task<LstCateRepl> GetAllCategories(GetAllCateReq req)
        {
            LstCateRepl repl = await _client.GetAllCategoriesAsync(req);
            return repl;
        }
    }
}
