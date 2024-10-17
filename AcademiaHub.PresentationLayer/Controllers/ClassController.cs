using Microsoft.AspNetCore.Mvc;

namespace AcademiaHub.PresentationLayer.Controllers
{
    public class ClassController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
