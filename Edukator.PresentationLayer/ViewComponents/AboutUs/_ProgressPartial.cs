using Edukator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents.AboutUs
{
    public class _ProgressPartial:ViewComponent
    {
        private readonly IAboutUsService _aboutUsService;

        public _ProgressPartial(IAboutUsService aboutUsService)
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
