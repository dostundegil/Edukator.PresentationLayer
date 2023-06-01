using Edukator.EntityLayer.Concrate;
using Edukator.PresentationLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System;
using System.Threading.Tasks;
using Edukator.PresentationLayer.Areas.Member.Models;

namespace Edukator.PresentationLayer.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[Controller]/[action]")]
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
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            EditUserViewModel userEditViewModel = new EditUserViewModel();
            userEditViewModel.Name = values.Name;
            userEditViewModel.Surname = values.Surname;
            userEditViewModel.ImageUrl = values.ImageUrl;
            userEditViewModel.Mail = values.Email;
            userEditViewModel.Username = values.UserName;
            return View(userEditViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Index(EditUserViewModel p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (p.Image != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(p.Image.FileName);
                var imagename = Guid.NewGuid() + extension;
                var saveLocation = resource + "/wwwroot/userimages/" + imagename;
                var stream = new FileStream(saveLocation, FileMode.Create);
                await p.Image.CopyToAsync(stream);
                user.ImageUrl = "/userimages/" + imagename;
            }
            user.Name = p.Name;
            user.UserName = p.Username;
            user.Email = p.Mail;
            if (p.ChangePassword)
            {
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.Password);
            }
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Dashboard");
            }
            return View();
        }
    }
}
