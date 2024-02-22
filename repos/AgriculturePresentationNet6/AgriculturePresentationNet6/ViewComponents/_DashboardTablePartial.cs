using Microsoft.AspNetCore.Mvc;
using EntityLayer.Concrete;
using BusinessLayer.Abstract;

namespace AgriculturePresentationNet6.ViewComponents
{
    public class _DashboardTablePartial : ViewComponent
    {
        private readonly IContactService _contactService;

        public _DashboardTablePartial(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _contactService.GetListAll();
            return View(values);
        }
    }
}