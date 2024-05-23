using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.Member.Controllers
{
    [Area("Member")]
    [AllowAnonymous] //şimdilik geliştirme yaparken burası yetkisiz olsun daha sonra ayarlacağız
    public class CommentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
