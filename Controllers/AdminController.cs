using Microsoft.AspNetCore.Mvc;

namespace FPTJOB.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
