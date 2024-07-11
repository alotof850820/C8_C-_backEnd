using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Repository.Entities;

namespace WebApplication1.Repository.Interface.User
{
    public interface IUserRepositoryInterface
    {
        public Task<List<UserEntities>> GetUsersAsync();
    }
}
