using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentationNet6.ViewComponents
{
    public class _DashboardHeaderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
