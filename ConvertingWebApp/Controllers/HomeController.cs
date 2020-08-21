using Microsoft.AspNetCore.Mvc;
namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}