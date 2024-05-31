using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TraversalCoreProject.Areas.Member.Controllers
{
    [Area("Member")]
    public class ReservationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        ReservationManager reservationManager = new ReservationManager(new EfReservationDal());
        private readonly UserManager<AppUser> _userManager;

        public ReservationController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> CurrentReservations()
        {
            var datas = await _userManager.FindByNameAsync(User.Identity.Name);
            var datasList = reservationManager.TGetListWithReservationByAccepted(datas.Id);
            return View(datasList);
        }
        public async Task<IActionResult> PreviousReservations()
        {
            var datas = await _userManager.FindByNameAsync(User.Identity.Name);
            var datasList = reservationManager.TGetListWithReservationByPrevious(datas.Id);
            return View(datasList);
        }
        public async Task<IActionResult> ApprovalReservations()
        {
            var datas = await _userManager.FindByNameAsync(User.Identity.Name);
            var datasList = reservationManager.TGetListWithReservationByWaitApproval(datas.Id);
            return View(datasList);
        }
        [HttpGet]
        public IActionResult NewReservations()
        {
            List<SelectListItem> datas = (from x in destinationManager.TGetList()
                                          select new SelectListItem
                                          {
                                                Text = x.City,
                                                Value = x.DestinationID.ToString()
                                          }).ToList();
            ViewBag.Data = datas;
            return View();
        }
        [HttpPost]
        public IActionResult NewReservations(Reservation param)
        {
            param.AppUserId = 6;
            //Birden fazla onay durumu olacaktır ama rezervasyon ilk oluşturulduğunda her zaman "Onay Bekliyor" şeklinde açılacağından burada işlemi ataayalım.
            param.Status = "Onay Bekliyor";
            reservationManager.TAdd(param);
            return RedirectToAction("ActiveReservations");
        }
    }
}
