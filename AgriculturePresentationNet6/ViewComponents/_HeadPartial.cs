using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentationNet6.ViewComponents
{
	public class _HeadPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
