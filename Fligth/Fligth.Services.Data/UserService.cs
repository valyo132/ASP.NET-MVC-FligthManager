using AutoMapper;
using Fligth.Data;
using Fligth.Models;
using Fligth.Services.Data.Interfaces;
using Fligth.Web.ViewModels.Users;

namespace Fligth.Services.Data
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly FligthManagerContext _context;

        public UserService(IMapper mapper, FligthManagerContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task CreateAsync(UserInputViewModel obj)
        {
            User user = _mapper.Map<User>(obj);
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }
    }
}
