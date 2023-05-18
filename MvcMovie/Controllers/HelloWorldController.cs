using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

// Creo otro controlador
//public class OtherController : Controller
//{
//	public IActionResult OtherAction()
//	{
//		return Content("This is the Other Action...");
//	}
//}