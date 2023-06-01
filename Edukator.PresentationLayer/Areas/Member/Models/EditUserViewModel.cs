using Microsoft.AspNetCore.Http;

namespace Edukator.PresentationLayer.Areas.Member.Models
{
    public class EditUserViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile Image { get; set; }

        public bool ChangePassword { get; set; }
    }
}
