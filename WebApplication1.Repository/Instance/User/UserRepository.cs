using Microsoft.EntityFrameworkCore;
using WebApplication1.Repository.Entities;
using WebApplication1.Repository.Interface.User;

namespace WebApplication1.Repository.Instance.User
{
    public class UserRepository : IUserRepositoryInterface
    {
        private readonly AppContextDataBase _context;
        public UserRepository(AppContextDataBase context)
        {
            _context = context;
        }
        public async Task<List<UserEntities>> GetUsersAsync()
        {
            var res =  _context.Users
               .Select(user => new UserEntities
               {
                   Id = user.Id,
                   Name = user.Name,
                   CreatedAt = user.CreatedAt
               });
            // ToQueryString 轉原生sql code
            var test = res.ToQueryString();
            return await res.ToListAsync();
        }
    }
}
