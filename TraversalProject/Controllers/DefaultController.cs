using Microsoft.AspNetCore.Mvc;

namespace TraversalProject.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();

            //20. videoda kaldık
        }
    }
}
