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
        private readonly ICommentService _commentService;
        public HomeController(ILogger<HomeController> logger, IHeadlineService headlineService, ICommentService commentService)
        {
            _logger = logger;
            _headlineService = headlineService;
            _commentService = commentService;
        }
        [HttpGet] 
        public IActionResult Index()
        {
            var headlineList = _headlineService.GetHeadLinesWithComments();
            return View(headlineList);
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