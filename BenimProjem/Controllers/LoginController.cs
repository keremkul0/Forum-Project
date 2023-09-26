using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BenimProjem.Controllers
{
    public class LoginController : Controller
    {
        private readonly UserManager<User> _userManager;
        public IActionResult Index()
        {
            return View();
        }
    }
}
