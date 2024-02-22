using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentationNet6.Controllers
{
    [AllowAnonymous]
    public class DefaultController1 : Controller
    {
        private readonly IContactService _contactService;

		public DefaultController1(IContactService contactService)
		{
			_contactService = contactService;
		}

		public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }
		[HttpPost]
		public IActionResult SendMessage(Contact contact)
		{
            contact.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            _contactService.Insert(contact);
			return RedirectToAction("Index", "DefaultController1");
		}
        public PartialViewResult ScriptPartial()
        {
            return PartialView(); 
        }
	}
}
