using Edukator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents.DefaultContact
{
    public class _DefaultContactMapInfoPartial:ViewComponent
    {
        private readonly IMapInfoService _mapInfoService;

        public _DefaultContactMapInfoPartial(IMapInfoService mapInfoService)
        {
            _mapInfoService = mapInfoService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _mapInfoService.TGetList();
            return View(values);
        }
    }
}
