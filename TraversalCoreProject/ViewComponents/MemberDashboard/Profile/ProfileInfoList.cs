using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.MemberDashboard.Profile
{
    public class ProfileInfoList : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileInfoList(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var datas = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.Data1 = datas.Name + "" + datas.Surname;
            ViewBag.Data2 = datas.UserName;
            ViewBag.Data3 = datas.PhoneNumber;
            ViewBag.Data4 = datas.Email;
            return View();
        }
    }
}
