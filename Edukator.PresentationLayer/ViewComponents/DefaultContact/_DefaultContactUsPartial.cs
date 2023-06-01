using Edukator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents.DefaultContact
{
    public class _DefaultContactUsPartial:ViewComponent
    {
        private readonly IContactInfoService _contactInfoService;

        public _DefaultContactUsPartial(IContactInfoService contactInfoService)
        {
            _contactInfoService = contactInfoService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _contactInfoService.TGetList();
            return View(values);
        }
    }
}
