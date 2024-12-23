using AutoMapper;
using Grpc.Core;
using Microsoft.EntityFrameworkCore;
using PRN231_ProjectMain.Models;

namespace PRN231_ProjectMain.Services
{
    public class LikeService : Liker.LikerBase
    {
        private FinalProjectDbContext _context;
        private IMapper _mapper;

        public LikeService(FinalProjectDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public override Task<LstLikeRepl> GetListLikedProductByUserId(GetListLikedProductByUserIdReq request, ServerCallContext context)
        {
            List<Like> likes = _context.Likes.Include(l => l.Product).Where(l => l.UserId == request.UserId).ToList();
            LstLikeRepl repl = new LstLikeRepl();
            repl.Like.AddRange(_mapper.Map<List<Like>, List<LikeProto>>(likes));
            return Task.FromResult(repl);
        }
    }
}
