using Grpc.Core;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using PRN231_ProjectMain.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace PRN231_ProjectMain.Services
{
    public class AuthenticateService : Authenticater.AuthenticaterBase
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IConfiguration _configuration;

        public AuthenticateService(UserManager<User> userManager, IConfiguration configuration, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _configuration = configuration;
            _signInManager = signInManager;
        }
      
        public override async Task<LoginResponse> Login(LoginRequest request, ServerCallContext context)
        {
            LoginResponse response = new LoginResponse();
            var user = await _userManager.FindByEmailAsync(request.Email);
            string hash = HashPassword(request.Password);

            var result = await _signInManager.PasswordSignInAsync(user.UserName, request.Password, false, false);
            if (result.Succeeded && user != null)
            {
                var userRoles = await _userManager.GetRolesAsync(user);
                var authClaims = new List<Claim>
                {
                    new Claim("Id", user.Id),
                    new Claim(ClaimTypes.Name, user.Fullname),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                };

                foreach (var userRole in userRoles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, userRole));
                }

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var expiry = DateTime.Now.AddDays(Convert.ToInt32(_configuration["Jwt:ExpiryInDays"]));
                var token = new JwtSecurityToken(
                    _configuration["Jwt:Issuer"],
                    _configuration["Jwt:Audience"],
                    authClaims,
                    expires: expiry,
                    signingCredentials: creds
                    );
                response.IsSuccess = true;
                response.Message = "Login successfully!";
                response.Token = new JwtSecurityTokenHandler().WriteToken(token);
            }
            else
            {
                response.IsSuccess = false;
                response.Message = "Your email or password is invalid!";
            }
            return response;
        }

        public override async Task<RegisterResponse> Register(RegisterRequest request, ServerCallContext context)
        {
            RegisterResponse response = new RegisterResponse();
            var userExisted = await _userManager.FindByEmailAsync(request.Email);
            if (userExisted != null)
            {
                response.IsSuccess = false;
                response.Message = "User is already existed";
            }
            else
            {
                User u = new User
                {
                    Email = request.Email,
                    Fullname = request.Fullname,
                    Address = request.Address,
                    PhoneNumber = request.Phonenum,
                    UserName = request.Username,
                    Status = true
                };
                var result = await _userManager.CreateAsync(u, request.Password);
                string hash = HashPassword(request.Password);
                var createRole = await _userManager.AddToRoleAsync(u, "CUSTOMER");
                if (!result.Succeeded || !createRole.Succeeded)
                {
                    response.IsSuccess = false;
                    response.Message = result.ToString();
                }
                else
                {
                    response.IsSuccess = true;
                    response.Message = "Create user successfull";
                }
            }
            return response;
        }

        public static string HashPassword(string password)
        {
            byte[] salt;
            byte[] buffer2;
            if (password == null)
            {
                throw new ArgumentNullException("password");
            }
            using (Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(password, 0x10, 0x3e8))
            {
                salt = bytes.Salt;
                buffer2 = bytes.GetBytes(0x20);
            }
            byte[] dst = new byte[0x31];
            Buffer.BlockCopy(salt, 0, dst, 1, 0x10);
            Buffer.BlockCopy(buffer2, 0, dst, 0x11, 0x20);
            return Convert.ToBase64String(dst);
        }
    }
}
