namespace CodeFirstTemplate.Services.Services
{
    using System;
    using System.Linq;
    using CodeFirstTemplate.DATA.Models;
    using CodeFirstTemplate.Services.Interfaces;
    using DATA.Repositories;
    using Microsoft.AspNet.Identity;

    public class UsersServices : IUsersService
    {
        private readonly UserManager<User> userManager;
        private readonly IDbRepository<User, string> usersRepository;

        public UsersServices(UserManager<User> userManager, IDbRepository<User, string> usersRepository)
        {
            this.userManager = userManager;
            this.usersRepository = usersRepository;
        }

        public IQueryable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
