using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Controllers
{
    public class DestinationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        public IActionResult Index()
        {
            var datas = destinationManager.TGetList();
            return View(datas);
        }
        [HttpGet]
        public IActionResult DetailsDestinations(int id)
        {
            ViewBag.id = id; //Bunun sebebi ViewComponent'e id değerini taşımamız gerektiği için.
            var destination = destinationManager.TGetByID(id);
            return View(destination);
        }
        [HttpPost]
        public IActionResult DetailsDestinations(Destination destination)
        {
            return View();
        }
    }
}
