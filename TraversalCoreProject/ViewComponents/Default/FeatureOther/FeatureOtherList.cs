using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Default.FeatureOther
{
    public class FeatureOtherList : ViewComponent
    {
        FeatureOtherManager featureOtherManager = new FeatureOtherManager(new EfFeatureOtherDal());
        public IViewComponentResult Invoke()
        {
            var datas = featureOtherManager.TGetList();
            return View(datas);
        }
    }
}
