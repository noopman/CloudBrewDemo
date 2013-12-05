using System.Web.Mvc;

namespace Vanilla.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.Message = string.Empty;
			return View();
		}
	}
}