using Microsoft.AspNetCore.Mvc;

namespace apiUI.Controllers
{
    public class AdminLayoutModelViewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult scripts()
        {
            return PartialView();
        }
        public PartialViewResult head()
        {
            return PartialView();
        }
        public PartialViewResult navbar()
        {
            return PartialView();
        }
    }
}
