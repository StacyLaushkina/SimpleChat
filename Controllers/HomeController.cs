using System.Web.Mvc;
using SimpleChat.Models;

namespace SimpleChat.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(User user)
        {
            return RedirectToAction("Index", "Chat", new { userId = user.Id });
        }
        public ActionResult Chat()
        {
            return View();
        }
    }
}