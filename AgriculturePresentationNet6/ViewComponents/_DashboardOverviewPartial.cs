using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentationNet6.ViewComponents
{
    public class _DashboardOverviewPartial : ViewComponent
    {
        AgricultureContext context = new AgricultureContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.teamCount = context.Teams.Count();
            ViewBag.serviceCount = context.Services.Count();
            ViewBag.messageCount = context.Contacts.Count();
            ViewBag.currentMonthMessage = 3;

            ViewBag.announcementTrue = context.Announcements.Where(x => x.Status == true).Count();
            ViewBag.announcementFalse = context.Announcements.Where(x => x.Status == false).Count();

            ViewBag.Gelistirici = context.Teams.Where(x => x.Title == ".Net Developer").Select(y => y.PersonName).FirstOrDefault();
            ViewBag.Psikiyatrist = context.Teams.Where(x => x.Title == "Psikiyatrist").Select(y => y.PersonName).FirstOrDefault();
            ViewBag.bhfxt = context.Teams.Where(x => x.Title == "bhfxt").Select(y => y.PersonName).FirstOrDefault();
            ViewBag.bhzdrhhbdz = context.Teams.Where(x => x.Title == "bhzdrhhbdz").Select(y => y.PersonName).FirstOrDefault();
            return View();
        }
    }
}
