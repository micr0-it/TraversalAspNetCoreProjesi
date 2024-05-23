using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.Areas.Member.Models;

namespace TraversalCoreProject.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var datas = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel uEVM = new UserEditViewModel();
            uEVM.Name = datas.Name;
            uEVM.Surname = datas.Surname;
            uEVM.PhoneNumber = datas.PhoneNumber;
            uEVM.Mail = datas.Email;
            uEVM.ImgUrl = datas.Img;
            return View(uEVM);
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel uEVM)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            #region User Image Güncelleme
            if(uEVM.Img != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(uEVM.Img.FileName);
                var imgName = Guid.NewGuid() + extension;
                var saveLocation = resource + "/wwwroot/userimg/" + imgName;
                var stream = new FileStream(saveLocation, FileMode.Create);
                await uEVM.Img.CopyToAsync(stream);
                user.Img = imgName;
            }
            #endregion

            user.Name = uEVM.Name;
            user.Surname = uEVM.Surname;
            user.PhoneNumber = uEVM.PhoneNumber;
            user.Email = uEVM.Mail;

            #region Pwd Güncelleme
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, uEVM.Pwd);
            #endregion

            var result = await _userManager.UpdateAsync(user);
            if(result.Succeeded)
                return RedirectToAction("SignIn","Login");
            return View();
        }
    }
}
