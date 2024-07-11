using Service.Serializer;
using Service.Models.User;
using WebApplication1.Repository.Instance.User;
using Service.Interface.User;
using WebApplication1.Repository.Interface.User;

namespace Service.Instance.User
{
    public class UserService : IUserServiceInterface
    {
        private readonly IUserRepositoryInterface _userRepository;

        public UserService(IUserRepositoryInterface userRepository)
        { 
            _userRepository = userRepository;
        }

        public async Task<Response<List<UserModels>>> GetUsers()
        {
            {
                try
                {
                    var users = await _userRepository.GetUsersAsync();

                    Console.WriteLine("Users returned from GetUsersAsync:");
                    Console.WriteLine(users);

                    var userResponses = users.Select(user => new UserModels
                    {
                        Id = user.Id,
                        UserName = user.Name,
                        CreatedAt = user.CreatedAt
                        // Map other properties as needed
                    }).ToList();

                    return new Response<List<UserModels>>
                    {
                        Status = 200,
                        Data = userResponses,
                        Msg = "成功拿到用戶"
                    };
                }
                catch (Exception ex)
                {
                    return new Response<List<UserModels>>
                    {
                        Status = 500,
                        Data = null,
                        Msg = $"获取用户失败: {ex.Message}"
                    };
                }
            }
        }
    }
}
