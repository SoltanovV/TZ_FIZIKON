using Microsoft.AspNetCore.Mvc;

namespace TZ_FIZIKON.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
