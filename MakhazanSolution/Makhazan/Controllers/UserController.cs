using Microsoft.AspNetCore.Mvc;

namespace Makhazan.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
