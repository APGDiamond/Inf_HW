using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MailDI.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly IEmailInterface _emailService;
        public HomeController(IEmailInterface emailService)
        {
            _emailService = emailService;
        }
        [Route("sendmessage")]
        public async Task<IActionResult> SendMessage()
        {
            if (ModelState.IsValid)
            {
                await _emailService.SendEmailAsync("almaz1733@yandex.ru", "Тема письма", "Тест письма: тест!");
                ViewBag.Succes = true;
            }
            return RedirectToAction("get");
        }
        [HttpGet]
        public string Get()
        {
            return "Письмо отправлено";
        }
    }
}
