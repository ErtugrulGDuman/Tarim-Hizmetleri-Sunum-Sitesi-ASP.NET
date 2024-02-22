using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentationNet6.ViewComponents
{
	public class _NavBarPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
