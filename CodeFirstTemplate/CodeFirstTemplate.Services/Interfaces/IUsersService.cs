using System.Linq;
using CodeFirstTemplate.DATA.Models;

namespace CodeFirstTemplate.Services.Interfaces
{
    public interface IUsersService
    {
        IQueryable<User> GetAll();

        User GetById(string id);
    }
}
