using AutoMapper;
using Fligth.Models;
using Fligth.Web.ViewModels.Users;

namespace Fligth.Services.Mapping
{
    public class FlighProfile : Profile
    {
        public FlighProfile()
        {
            CreateMap<UserInputViewModel, User>();
        }
    }
}
