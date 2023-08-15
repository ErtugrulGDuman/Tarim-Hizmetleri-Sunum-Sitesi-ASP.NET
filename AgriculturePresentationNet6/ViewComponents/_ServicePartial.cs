using BusinessLayer.Abstract;
using DataAccessLayer.Concrete.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentationNet6.ViewComponents
{
	public class _ServicePartial : ViewComponent
	{
		private readonly IServiceService _serviceService;

		public _ServicePartial(IServiceService serviceService)
		{
			_serviceService = serviceService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _serviceService.GetListAll();
			return View(values);
		}
	}
}
