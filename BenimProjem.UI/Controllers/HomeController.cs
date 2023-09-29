using BenimProjem.UI.Models;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BenimProjem.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHeadlineService _headlineService;

        public HomeController(ILogger<HomeController> logger, IHeadlineService headlineService)
        {
            _logger = logger;
            _headlineService = headlineService;
        }

        public IActionResult Index()
        {
            var headlineList = _headlineService.TGetAll();
                
            return View(new HeadlineCommentViewModel { HeadlineList= headlineList });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}