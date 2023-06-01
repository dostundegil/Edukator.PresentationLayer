using Edukator.BusinessLayer.Abstract;
using Edukator.EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.Controllers
{
    public class DefaultContactController : Controller
    {
        private readonly IMessageService _messageService;

        public DefaultContactController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult SendMessage(Message message)
        {
            _messageService.TInsert(message);
            return RedirectToAction("Index");
        }
    }
}
