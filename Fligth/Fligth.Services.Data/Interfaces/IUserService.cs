using Fligth.Web.ViewModels.Users;

namespace Fligth.Services.Data.Interfaces
{
    public interface IUserService
    {
        Task CreateAsync(UserInputViewModel obj);
    }
}
