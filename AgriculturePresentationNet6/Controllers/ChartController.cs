using AgriculturePresentationNet6.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentationNet6.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ProductChart()
        {
            List<ProductClass> productClasses = new List<ProductClass>();
            productClasses.Add(new ProductClass()
            {
                productname = "Buğday",
                productvalue = 975
            });
            productClasses.Add(new ProductClass()
            {
                productname = "Mercimek",
                productvalue = 540
            });
            productClasses.Add(new ProductClass()
            {
                productname = "Arpa",
                productvalue = 310
            });
            productClasses.Add(new ProductClass()
            {
                productname = "Pirinç",
                productvalue = 630
            });
            productClasses.Add(new ProductClass()
            {
                productname = "Domates",
                productvalue = 810
            });
            return Json(new { jsonlist = productClasses });
        }
    }
}
