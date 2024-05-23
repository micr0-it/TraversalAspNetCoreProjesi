using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Destination.Destination
{
    public class CommentList : ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());
        public IViewComponentResult Invoke(int id)
        {
            var datas = commentManager.TGetDestinationByID(id);
            ViewBag.CommentCount = datas.Count;
            return View(datas);
        }
    }
}
