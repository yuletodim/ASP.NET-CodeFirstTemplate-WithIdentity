namespace CodeFirstTemplate.Web.Controllers
{
    using System.Web.Mvc;
    using CodeFirstTemplate.Services.Interfaces;

    public class HomeController : Controller
    {
        private readonly IContestsService contestsService; 

        public HomeController(IContestsService contestsService)
        {
            this.contestsService = contestsService;
        }

        public ActionResult Index()
        {
            var contests = this.contestsService.GetAll();
            return View(contests);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}