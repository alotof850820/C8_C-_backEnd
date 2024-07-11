using Service.Interface.User;
using WebApplication1.Models.UserModels;
using WebApplication1.Serializer;

namespace WebApplication1.Interface.User
{
    public interface IUserAppInterface
    {
        Task<Response<List<UserAppModels>>> GetAppUsers();
    }
}
