using CommunityOfMars.Data;
using CommunityOfMars.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace CommunityOfMars.Controllers
{
    public class HomeController : Controller
    {
        //MarsDBContext context;
        IMessagesRepository messagesRepo;

        public HomeController(IMessagesRepository m)
        {
            //context = c;
            messagesRepo = m;
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
        public IActionResult Messages()
        {
            var messages = messagesRepo.GetMessages();
            return View(messages);
        }

        [HttpPost]
        public IActionResult Messages(string toname)
        {
            List<Message> messages = (from m in messagesRepo.GetMessages()
                                      where m.Sender.UserName == toname
                                      select m).ToList();
            return View("Messages", messages);
        }

        public IActionResult Message()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Message(Message message)
        {
            message.Date = DateOnly.FromDateTime(DateTime.Now);
            messagesRepo.StoreMessage(message);
            return RedirectToAction("Messages");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}