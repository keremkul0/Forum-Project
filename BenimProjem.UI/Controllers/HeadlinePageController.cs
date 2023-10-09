using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BenimProjem.UI.Controllers
{
    public class HeadlinePageController : Controller
    {
        private readonly IHeadlineService _headlineService;

        public HeadlinePageController(IHeadlineService headlineService)
        {
            _headlineService = headlineService;
        }

        [HttpGet]
        public IActionResult Index(int id)
        {
            var headline = _headlineService.GetHeadlineComments(id);
            return View(headline);
        }
    }
}
