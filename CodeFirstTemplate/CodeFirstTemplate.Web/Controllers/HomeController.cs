namespace CodeFirstTemplate.Web.Controllers
{
    using System.Collections.Generic;
    using System.Web.Mvc;
    using CodeFirstTemplate.Services.Interfaces;
    using Models;

    public class HomeController : BaseController
    {
        private readonly IUsersServices usersServices;

        public HomeController(IUsersServices usersServices)
        {
            this.usersServices = usersServices;
        }

        public ActionResult Index()
        {
            var users = this.usersServices.GetAll();
            var usersViewModel = this.Mapper.Map<List<UserViewModel>>(users);
            return View(usersViewModel);
        }

    }
}