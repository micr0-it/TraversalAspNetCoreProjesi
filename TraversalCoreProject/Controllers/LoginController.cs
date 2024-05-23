using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.Models;

namespace TraversalCoreProject.Controllers
{
    [AllowAnonymous] //Altında bulunduğu metodlara erişimin yetkisiz şekilde kullandırabiliyor
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(UserRegisterViewModel param) //Identity ile ilgili işlemlerde async Task olarak tanımlıyoruz. //Ayrıca entity bağımlılığını kaldırmak içinde AppUser entity vermeyeceğiz parametreye, viewmodel oluşturacağız.
        {
            AppUser appUser = new AppUser()
            {
                Name = param.Name,
                Surname = param.Surname,
                Email = param.Mail,
                UserName = param.UserName
            };
            if(param.Pwd == param.ConfirmPwd)
            {
                var result = await _userManager.CreateAsync(appUser, param.Pwd); //Biz pwd'yi yukarıda almadık neden şimdi biz burada registerı yaptık şifremizde hashleneceği için buraya attığımız şifre hashlenerek kaydolacak
                if (result.Succeeded)
                {
                    return RedirectToAction("SignIn");
                }   
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("",item.Description);
                    }
                }
            }
            return View(param);
        }
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(UserLoginViewModel param)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(param.UserName, param.Pwd, false, true);
                if (result.Succeeded)
                    return RedirectToAction("Index", "Profile", new {area = "Member"});
                else
                    return RedirectToAction("SignIn", "Login");
            }
            return View();
        }
    }
}
