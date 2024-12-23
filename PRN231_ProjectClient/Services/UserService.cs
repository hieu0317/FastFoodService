namespace PRN231_ProjectClient.Services
{
    public class UserService
    {
        private Userer.UsererClient _client;

        public UserService(Userer.UsererClient client)
        {
            _client = client;
        }

        public async Task<UserProto> GetUserById(GetUserByUserIdReq req)
        {
            UserProto user = await _client.GetUserByUserIdAsync(req);
            return user;
        }
    }
}
