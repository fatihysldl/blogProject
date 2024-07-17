using Microsoft.AspNetCore.Mvc;

namespace apiUI.Areas.userLayout.Controllers
{
    [Area("userLayout")]
    public class partialsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult head()
        {
            return View();
        }
        public IActionResult footer()
        {
            return View();
        }
    }
}
