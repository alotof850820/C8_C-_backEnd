using WebApplication1.Serializer;
using WebApplication1.Models.UserModels;
using Service.Interface.User;

namespace WebApplication1.Instance.User
{
    public static class UserAppInstance 
    {

        public static async Task<Response<List<UserAppModels>>>GetAppUsers(IUserServiceInterface usersService)
        {
            try
            {
                var users = await usersService.GetUsers();

                var response = users.Data?.Select(user => new UserAppModels
                {
                    Id = user.Id,
                
                }).ToList();

                return new Response<List<UserAppModels>>
                {
                    Status = 200,
                    Data = response,
                    Msg = "成功拿到用戶"
                };
            }
            catch (Exception ex)
            {
                return new Response<List<UserAppModels>>
                {
                    Status = 500,
                    Data = null,
                    Msg = $"fail: {ex.Message}"
                };
            }
        }
    }
}