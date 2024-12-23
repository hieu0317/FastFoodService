using AutoMapper;
using Grpc.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using PRN231_ProjectMain.Models;

namespace PRN231_ProjectMain.Services
{
    [Authorize]
    public class UserService : Userer.UsererBase
    {
        private UserManager<User> _userManager;
        private IMapper _mapper;

        public UserService(IMapper mapper, UserManager<User> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }

        public override async Task<UserProto> GetUserByUserId(GetUserByUserIdReq request, ServerCallContext context)
        {
            User u = await _userManager.FindByIdAsync(request.UserId);
            return _mapper.Map<User,UserProto>(u);
        }
    }
}
