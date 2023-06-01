using Edukator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents.AboutUs
{
    public class _WhyChooseUsPartial:ViewComponent
    {
        private readonly IAboutUsService _aboutUsService;

        public _WhyChooseUsPartial(IAboutUsService aboutUsService)
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
