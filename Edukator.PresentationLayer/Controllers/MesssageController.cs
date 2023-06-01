using Edukator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.Controllers
{
    public class MesssageController : Controller
    {
        private readonly IMessageService _messageService;

        public MesssageController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public IActionResult Index()
        {
            var values = _messageService.TGetList();
            return View(values);
        }
        public IActionResult MessageDetails(int id)
        {
            var value = _messageService.TGetById(id);
            return View(value);
        }

        public IActionResult DeleteMessage(int id)
        {
            var value = _messageService.TGetById(id);
            _messageService.TDelete(value);
            return RedirectToAction("Index");
        }
    }
}
