using Service.Models.User;
using Service.Serializer;
namespace Service.Interface.User
{
    public interface IUserServiceInterface
    {
        Task<Response<List<UserModels>>> GetUsers();
    }
}
