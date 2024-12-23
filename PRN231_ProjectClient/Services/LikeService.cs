namespace PRN231_ProjectClient.Services
{
    public class LikeService
    {
        private Liker.LikerClient _client;

        public LikeService(Liker.LikerClient client)
        {
            _client = client;
        }

        public async Task<LstLikeRepl> GetLstLikeProductByUserId(GetListLikedProductByUserIdReq req)
        {
            LstLikeRepl repl = await _client.GetListLikedProductByUserIdAsync(req);
            return repl;
        }
    }
}
