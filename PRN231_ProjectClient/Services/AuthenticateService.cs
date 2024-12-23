namespace PRN231_ProjectClient.Services
{
    public class AuthenticateService
    {
        private Authenticater.AuthenticaterClient _client;

        public AuthenticateService(Authenticater.AuthenticaterClient client)
        {
            _client = client;
        }

        public async Task<LoginResponse> AuthenticateUser(LoginRequest request)
        {
            LoginResponse response = await _client.LoginAsync(request);
            return response;
        }

        public async Task<RegisterResponse> RegisterUser(RegisterRequest request)
        {
            RegisterResponse response = await _client.RegisterAsync(request);
            return response;
        }
    }
}
