using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class DefaultController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
