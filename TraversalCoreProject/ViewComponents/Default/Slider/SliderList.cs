using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Default.Slider
{
    public class SliderList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
