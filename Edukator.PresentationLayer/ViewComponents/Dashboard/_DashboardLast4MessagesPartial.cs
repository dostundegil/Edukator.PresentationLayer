using Edukator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents.Dashboard
{
    public class _DashboardLast4MessagesPartial:ViewComponent
    {
        private readonly IMessageService _messageService;

        public _DashboardLast4MessagesPartial(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _messageService.TGetLast4Messages();
            return View(values);
        }
    }
}
