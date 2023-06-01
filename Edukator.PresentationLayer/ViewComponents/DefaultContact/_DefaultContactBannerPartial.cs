using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents.DefaultContact
{
    public class _DefaultContactBannerPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
