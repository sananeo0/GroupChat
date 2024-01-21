using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GroupChat.Controllers
{
    public class HomeController : Controller
    {
      

        public IActionResult Index()
        {
            return View();
        }
       
    }
}
