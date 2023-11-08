using CommunityOfMars.Data;
using CommunityOfMars.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace CommunityOfMars.Controllers
{
    public class HomeController : Controller
    {
        MarsDBContext context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(MarsDBContext c, ILogger<HomeController> logger)
        {
            context = c;
            _logger = logger;
        }

        public IActionResult Index(string messageId)
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult History()
        {
            return View();
        }

        //TODO: Do something with the messageId
        public IActionResult Messages(string messageId)
        {
            var model = context.Messages
                .Include(message => message.Sender)
                .Include(message => message.Receiver)
                .ToList();
            return View(model);
        }

        public IActionResult Message()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Message(Message message)
        {
            message.Date = DateOnly.FromDateTime(DateTime.Now);
            context.Messages.Add(message);
            context.SaveChanges();
            return RedirectToAction("Messages", new { messageId = message.MessageId});
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}