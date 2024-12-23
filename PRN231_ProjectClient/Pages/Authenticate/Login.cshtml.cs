using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PRN231_ProjectClient.Services;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;

namespace PRN231_ProjectClient.Pages.Authenticate
{
    public class LoginModel : PageModel
    {
        private AuthenticateService _authenticateService;
        public string loginMessage { get; set; }
        public bool isRegisterSuccess { get; set; }
        public string registerMessage { get; set; }

        public LoginModel(AuthenticateService authenticateService)
        {
            _authenticateService = authenticateService;
        }

        public void OnGet()
        {
        }

        public async void OnPostSignin(LoginRequest request)
        {
            LoginResponse response = _authenticateService.AuthenticateUser(request).Result;
            if (response.IsSuccess)
            {
                HttpContext.Session.SetString("token", response.Token.ToString());
                var handler = new JwtSecurityTokenHandler();
                var jsonToken = handler.ReadToken(response.Token) as JwtSecurityToken;
                List<Claim> claims = new List<Claim>();
                foreach (var claim in jsonToken.Claims)
                {
                    claims.Add(new Claim(claim.Type, claim.Value));
                }
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal, new AuthenticationProperties()
                {
                    IsPersistent = true
                });
                Response.Redirect("/Index");
            }
            else
            {
                loginMessage = response.Message;
            }
        }

        public void OnPostSignup(RegisterRequest request)
        {
            RegisterResponse response = _authenticateService.RegisterUser(request).Result;
            isRegisterSuccess = response.IsSuccess;
            registerMessage = response.Message;
        }
    }
}
