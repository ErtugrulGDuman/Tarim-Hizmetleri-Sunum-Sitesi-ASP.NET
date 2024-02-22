using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentationNet6.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
