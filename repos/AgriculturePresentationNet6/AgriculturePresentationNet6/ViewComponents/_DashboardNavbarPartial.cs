using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentationNet6.ViewComponents
{
    public class _DashboardNavbarPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
