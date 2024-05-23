using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Default.Statistic
{
    public class StatisticList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            //Context kullanacağız fazla bir bilgi taşıma işlemi veya veri ekleme çıkarma gibi bir işlem olamaycağından ötürü.
            using var c = new Context();
            ViewBag.destinationStatistic = c.Destinations.Count();
            ViewBag.guideStatistic = c.Guides.Count();
            return View();
        }
    }
}
