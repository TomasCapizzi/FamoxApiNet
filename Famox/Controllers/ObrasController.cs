using Microsoft.AspNetCore.Mvc;

namespace Famox.Controllers
{
    public class ObrasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
