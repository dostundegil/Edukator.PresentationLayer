using Edukator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents.AboutUs
{
    public class _AboutDescPartial:ViewComponent
    {
        private readonly IAboutUsService _aboutUsService;

        public _AboutDescPartial(IAboutUsService aboutUsService)
        {
            _aboutUsService = aboutUsService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _aboutUsService.TGetList();
            return View(values);
        }
    }
}
